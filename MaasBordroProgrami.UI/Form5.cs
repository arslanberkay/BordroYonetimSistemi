using iTextSharp.text;
using iTextSharp.text.pdf;
using MaasBordroProgrami.Core.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.Net.Mail;
using Microsoft.VisualBasic.Devices;
using System.Net;

namespace MaasBordroProgrami.UI
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public static List<MaasBordro> tumPersonelBordro = new List<MaasBordro>();

        private void TumCalisanBordroHesapla()
        {
            var personelListesi = JSONDosya.PersonelListesiOku().ToList();

            tumPersonelBordro.Clear();
            foreach (var item in personelListesi)
            {
                MaasBordro maasBordro = new MaasBordro();
                maasBordro.PersonelIsmi = item.AdSoyad;
                maasBordro.Kadro = item.Kadro;
                maasBordro.CalismaSaati = item.CalismaSaati;
                maasBordro.AnaOdeme = item.MaasHesapla();
                maasBordro.MesaiUcreti = item.MesaiHesapla();
                maasBordro.ToplamOdeme = item.MaasHesapla() + item.MesaiHesapla();

                tumPersonelBordro.Add(maasBordro);
            }
        }

        private void TabloOlustur()
        {
            lstvTumPersonelBordrosu.View = View.Details;
            lstvTumPersonelBordrosu.GridLines = true;
            lstvTumPersonelBordrosu.Columns.Add("Personel İsmi", 225);
            lstvTumPersonelBordrosu.Columns.Add("Kadro", 225, HorizontalAlignment.Center);
            lstvTumPersonelBordrosu.Columns.Add("Çalışma Saati", 225, HorizontalAlignment.Center);
            lstvTumPersonelBordrosu.Columns.Add("Ana Ödeme", 225, HorizontalAlignment.Center);
            lstvTumPersonelBordrosu.Columns.Add("Mesai", 225, HorizontalAlignment.Center);
            lstvTumPersonelBordrosu.Columns.Add("Toplam Ödeme", 225, HorizontalAlignment.Center);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            TabloOlustur();
            TumCalisanBordroHesapla();

            lstvTumPersonelBordrosu.Items.Clear();
            foreach (var personel in tumPersonelBordro)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = personel.PersonelIsmi;
                listViewItem.SubItems.Add(personel.Kadro);
                listViewItem.SubItems.Add(personel.CalismaSaati.ToString());
                listViewItem.SubItems.Add(personel.AnaOdeme.ToString());
                listViewItem.SubItems.Add(personel.MesaiUcreti.ToString());
                listViewItem.SubItems.Add(personel.ToplamOdeme.ToString());

                lstvTumPersonelBordrosu.Items.Add(listViewItem);
            }
        }

        private void btnAnaSayfayaGeriGec_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void btnPdfOlustur_Click(object sender, EventArgs e)
        {
            PDFOlustur();
        }

        private void btnExcelOlustur_Click(object sender, EventArgs e)
        {
            ExcelOlustur();
        }

        private void btnMailGonder_Click(object sender, EventArgs e)
        {
            MailGonderExcelPDF();
        }

        public void PDFOlustur()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Dosyası|*.pdf";
            saveFileDialog.Title = "PDF Dosyası Kaydet";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Document document = new Document();
                PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));
                document.Open();

                string arialTtf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                BaseFont bf = BaseFont.CreateFont(arialTtf, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

                iTextSharp.text.Font baslikFont = new iTextSharp.text.Font(bf, 18, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font kalinFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font normalFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font dateFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.ITALIC);

                Paragraph baslik = new Paragraph("Personel Bordrosu Raporu", baslikFont);
                baslik.Alignment = Element.ALIGN_CENTER;
                baslik.SpacingAfter = 10f;
                document.Add(baslik);

                string currentDateTime = DateTime.Now.ToString("dd MMMM yyyy HH:mm");
                Paragraph date = new Paragraph("Oluşturulma Tarihi: " + currentDateTime, dateFont);
                date.Alignment = Element.ALIGN_RIGHT;
                date.SpacingAfter = 20f;
                document.Add(date);

                PdfPTable table = new PdfPTable(lstvTumPersonelBordrosu.Columns.Count);
                table.WidthPercentage = 100;

                foreach (ColumnHeader column in lstvTumPersonelBordrosu.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.Text, kalinFont));
                    cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }

                foreach (ListViewItem listviewItem in lstvTumPersonelBordrosu.Items)
                {
                    foreach (ListViewItem.ListViewSubItem subItem in listviewItem.SubItems)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(subItem.Text, normalFont));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                    }
                }

                document.Add(table);
                document.Close();

                MessageBox.Show("PDF başarıyla kaydedildi!");
            }
        }

        public void ExcelOlustur()
        {
            using (var workbook = new XLWorkbook())
            {
                var workSheet = workbook.AddWorksheet($"Bordro_Raporu_{DateTime.Now:yyyyMMdd}");

                string[] headers = { "Personel İsmi", "Kadro", "Çalışma Saati", "Ana Ödeme", "Mesai", "Toplam Ödeme" };
                for (int i = 0; i < headers.Length; i++)
                {
                    var headerCell = workSheet.Cell(1, i + 1);
                    headerCell.Value = headers[i];

                    headerCell.Style.Font.Bold = true;
                    headerCell.Style.Fill.BackgroundColor = XLColor.LightGray;
                    headerCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                }
                int satir = 2;
                foreach (ListViewItem item in lstvTumPersonelBordrosu.Items)
                {
                    workSheet.Cell(satir, 1).Value = item.SubItems[0].Text;
                    workSheet.Cell(satir, 2).Value = item.SubItems[1].Text;
                    workSheet.Cell(satir, 3).Value = item.SubItems[2].Text;
                    workSheet.Cell(satir, 4).Value = item.SubItems[3].Text;
                    workSheet.Cell(satir, 5).Value = item.SubItems[4].Text;
                    workSheet.Cell(satir, 6).Value = item.SubItems[5].Text;
                    satir++;
                }

                workSheet.Columns().AdjustToContents();

                var range = workSheet.Range(1, 1, satir - 1, headers.Length);
                range.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                range.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                workSheet.Cell(satir + 1, 1).Value = $"Rapor Oluşturulma Tarihi: {DateTime.Now:dd MMMM yyyy HH:mm}";
                workSheet.Cell(satir + 1, 1).Style.Font.Italic = true;
                workSheet.Range(satir + 1, 1, satir + 1, headers.Length).Merge();

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|.xlsx";
                    saveFileDialog.Title = "Excel Dosyasını Kaydet";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        workbook.SaveAs(filePath);
                        MessageBox.Show("Excel dosyası başarıyla oluşturuldu.");
                    }
                }
            }
        }

        public void MailGonderExcelPDF()
        {
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string excelDosyaYolu = Path.Combine(desktopPath, "BordroRaporu.xlsx");
                string pdfDosyaYolu = Path.Combine(desktopPath, "BordroRaporu.pdf");

                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Bordro Raporu");

                    for (int col = 0; col < lstvTumPersonelBordrosu.Columns.Count; col++)
                    {
                        var headerCell = worksheet.Cell(1, col + 1);
                        headerCell.Value = lstvTumPersonelBordrosu.Columns[col].Text;
                        headerCell.Style.Font.Bold = true;
                        headerCell.Style.Fill.BackgroundColor = XLColor.LightBlue;
                        headerCell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    }

                    int row = 2;
                    foreach (ListViewItem listviewitem in lstvTumPersonelBordrosu.Items)
                    {
                        for (int i = 0; i < listviewitem.SubItems.Count; i++)
                        {
                            var cell = worksheet.Cell(row, i + 1);
                            cell.Value = listviewitem.SubItems[i].Text;
                            cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        }
                        row++;
                    }
                    worksheet.Columns().AdjustToContents();
                    workbook.SaveAs(excelDosyaYolu);
                }

                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

                using (FileStream fs = new FileStream(pdfDosyaYolu, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    Document document = new Document();
                    PdfWriter.GetInstance(document, fs);
                    document.Open();

                    string arialTtf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                    BaseFont bf = BaseFont.CreateFont(arialTtf, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

                    iTextSharp.text.Font baslikFont = new iTextSharp.text.Font(bf, 18, iTextSharp.text.Font.BOLD);
                    iTextSharp.text.Font kalinFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD);
                    iTextSharp.text.Font normalFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);
                    iTextSharp.text.Font dateFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.ITALIC);

                    Paragraph baslik = new Paragraph("Personel Bordrosu Raporu", baslikFont);
                    baslik.Alignment = Element.ALIGN_CENTER;
                    baslik.SpacingAfter = 10f;
                    document.Add(baslik);

                    string currentDateTime = DateTime.Now.ToString("dd MMMM yyyy HH:mm");
                    Paragraph date = new Paragraph("Oluşturulma Tarihi: " + currentDateTime, dateFont);
                    date.Alignment = Element.ALIGN_RIGHT;
                    date.SpacingAfter = 20f;
                    document.Add(date);

                    PdfPTable table = new PdfPTable(lstvTumPersonelBordrosu.Columns.Count);
                    table.WidthPercentage = 100;

                    foreach (ColumnHeader column in lstvTumPersonelBordrosu.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.Text, kalinFont));
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                    }

                    foreach (ListViewItem listviewItem in lstvTumPersonelBordrosu.Items)
                    {
                        foreach (ListViewItem.ListViewSubItem subItem in listviewItem.SubItems)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(subItem.Text, normalFont));
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            table.AddCell(cell);
                        }
                    }

                    document.Add(table);
                    document.Close();
                }

                MailMessage mail = new MailMessage();
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("berkayarslanyzl@gmail.com");
                mail.To.Add("linaa.arslann@gmail.com");
                mail.Body = "Maaş bordro raporu ektedir.";

                mail.Attachments.Add(new Attachment(excelDosyaYolu));
                mail.Attachments.Add(new Attachment(pdfDosyaYolu));

                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential("berkayarslanyzl@gmail.com", "dvkcizljotgfubov");
                smtpClient.EnableSsl = true;
                smtpClient.Send(mail);

                MessageBox.Show("Mail başarıyla gönderildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Mail gönderimi sırasında bir hata oluştur.\n Hata mesajı : {ex.Message}");
            }
        }



    }


}


