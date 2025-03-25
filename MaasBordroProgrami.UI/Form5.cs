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
using System.Globalization;

namespace MaasBordroProgrami.UI
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public static List<MaasBordro> tumPersonelBordro = new List<MaasBordro>(); //Tüm personelin bordro bilgilerini tutan bir listedir.

        private void TumCalisanBordroHesapla()
        {
            var personelListesi = JSONDosya.PersonelListesiOku().ToList(); //JSON dosyasından personel bilgilerini alır.

            tumPersonelBordro.Clear();
            foreach (var personel in personelListesi)
            {
                //Tüm personellerin maaş bordrosu hesaplanır 
                MaasBordro maasBordro = new MaasBordro();
                maasBordro.PersonelIsmi = personel.AdSoyad;
                maasBordro.Kadro = personel.Kadro;
                maasBordro.CalismaSaati = personel.CalismaSaati;
                maasBordro.AnaOdeme = personel.MaasHesapla();
                maasBordro.MesaiUcreti = personel.MesaiHesapla();
                maasBordro.ToplamOdeme = personel.MaasHesapla() + personel.MesaiHesapla();

                tumPersonelBordro.Add(maasBordro); //Hesaplanan bilgiler listeye eklenir.
            }
        }

        /// <summary>
        /// ListView için başlıkları ve özellikleri ayarlayan metod
        /// </summary>
        private void TabloOlustur()
        {
            lstvTumPersonelBordrosu.View = View.Details;
            lstvTumPersonelBordrosu.GridLines = true;
            lstvTumPersonelBordrosu.Columns.Add("Personel İsmi", 220);
            lstvTumPersonelBordrosu.Columns.Add("Kadro", 220, HorizontalAlignment.Center);
            lstvTumPersonelBordrosu.Columns.Add("Çalışma Saati", 220, HorizontalAlignment.Center);
            lstvTumPersonelBordrosu.Columns.Add("Ana Ödeme", 220, HorizontalAlignment.Center);
            lstvTumPersonelBordrosu.Columns.Add("Mesai", 220, HorizontalAlignment.Center);
            lstvTumPersonelBordrosu.Columns.Add("Toplam Ödeme", 220, HorizontalAlignment.Center);
        }

        /// <summary>
        /// Bu metod içine gönderilen parametredeki listeyi ListView satılarına yazdırır.
        /// </summary>
        /// <param name="filtrelenmisPersoneller"></param>
        private void TabloyaAktar(List<MaasBordro> filtrelenmisPersoneller)
        {
            foreach (var filtrelenmisPersonel in filtrelenmisPersoneller)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = filtrelenmisPersonel.PersonelIsmi;
                listViewItem.SubItems.Add(filtrelenmisPersonel.Kadro);
                listViewItem.SubItems.Add(filtrelenmisPersonel.CalismaSaati.ToString());
                listViewItem.SubItems.Add(filtrelenmisPersonel.AnaOdeme.ToString("C"));
                listViewItem.SubItems.Add(filtrelenmisPersonel.MesaiUcreti.ToString("C"));
                listViewItem.SubItems.Add(filtrelenmisPersonel.ToplamOdeme.ToString("C"));

                lstvTumPersonelBordrosu.Items.Add(listViewItem);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            TabloOlustur();
            TumCalisanBordroHesapla();
            Temizle();
            TabloyaAktar(tumPersonelBordro);
        }

        private void btnTumPersoneller_Click(object sender, EventArgs e)
        {
            Temizle();
            TabloyaAktar(tumPersonelBordro);
        }

        private void btnAlfabetikSiralama_Click(object sender, EventArgs e)
        {
            Temizle();
            var alfabetikSiraliPersoneller = tumPersonelBordro.OrderBy(p => p.PersonelIsmi).ToList(); //İsme göre alfabetik sıralama(A'dan Z'ye)
            TabloyaAktar(alfabetikSiraliPersoneller);
        }

        private void btnCalismaSaatiSiralama_Click(object sender, EventArgs e)
        {
            Temizle();
            var calismaSaatineGoreSiralananPersoneller = tumPersonelBordro.OrderBy(p => p.CalismaSaati).ToList(); //Çalışma saatine göre küçükten büyüğe sıralanan personelleri bir liteye aktardım. 
            TabloyaAktar(calismaSaatineGoreSiralananPersoneller);
        }

        private void btnAzCalisanPersonel_Click(object sender, EventArgs e)
        {
            Temizle();
            var azCalisanPersoneller = tumPersonelBordro.Where(t => t.CalismaSaati <= 150).ToList(); //Çalışma saati 150 ve altında olan personelleri bir listeye aktardım.
            var azCalisanPersonellerSiralamasi = azCalisanPersoneller.OrderBy(a => a.CalismaSaati).ToList(); //Çalışma saati 150 saatten az olan personellerin olduğu listeyi çalışma saatine göre küçükten büyüğe doğru sıraladım ve bir listeye aktardım.
            TabloyaAktar(azCalisanPersonellerSiralamasi);
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
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance); //Türkçe karakterlerin düzgün görünmesini sağlar.

            SaveFileDialog saveFileDialog = new SaveFileDialog(); //Kullanıcının dosya kaydetmesi için bir dosya kaydetme penceresi açar.
            saveFileDialog.Filter = "PDF Dosyası|*.pdf"; //Yalnızca.pdf uzantılı dosyaların kaydedilmesine izin verir
            saveFileDialog.Title = "PDF Dosyası Kaydet"; //Kaydetme penceresinde ki başlığı belirler.

            if (saveFileDialog.ShowDialog() == DialogResult.OK) //Kullanıcı bir dosya seçip Kaydet tuşuna basarsa
            {
                Document document = new Document(); //PDF'in içeriğini tutan nesne oluşturulur.
                PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create)); //PDF'i belirtilen yola yazar.
                document.Open(); //Yazma işlemi başlar

                string arialTtf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf"); //Arial fontunun yolunu alır. PDF'e Türkçe karakter desteği vermek için bilgisayardaki Arial fontunu kullanır. 
                BaseFont bf = BaseFont.CreateFont(arialTtf, BaseFont.IDENTITY_H, BaseFont.EMBEDDED); //Unicode karakter kümesini destekleyen bir fontu PDF'e ekler. BaseFont.EMBEDDED : Başka pclerde sorunsuz görünmesini sağlar. Fontu gömer.

                //Font tanımları yapılır.
                iTextSharp.text.Font baslikFont = new iTextSharp.text.Font(bf, 18, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font kalinFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font normalFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font dateFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.ITALIC);

                //PDF başlığını oluşturur ve ortalar
                Paragraph baslik = new Paragraph("Personel Bordrosu Raporu", baslikFont);
                baslik.Alignment = Element.ALIGN_CENTER;
                baslik.SpacingAfter = 10f; //Başlıktan sonra boşluk bırak
                document.Add(baslik);

                //Tarih ve Saat Ekle                
                string currentDateTime = DateTime.Now.ToString("dd MMMM yyyy HH:mm");
                Paragraph date = new Paragraph("Oluşturulma Tarihi: " + currentDateTime, dateFont);
                date.Alignment = Element.ALIGN_RIGHT;
                date.SpacingAfter = 20f;
                document.Add(date);

                //Tablo Oluşturma
                PdfPTable table = new PdfPTable(lstvTumPersonelBordrosu.Columns.Count); //Sütun sayısı kadar kolon içeren bir tablo
                table.WidthPercentage = 100;

                //Başlıkları Ekle 
                foreach (ColumnHeader column in lstvTumPersonelBordrosu.Columns)
                {
                    //Her bir sütun başlığını PDF tablosuna ekler.
                    PdfPCell cell = new PdfPCell(new Phrase(column.Text, kalinFont));
                    cell.BackgroundColor = BaseColor.LIGHT_GRAY; //Gri arka plan
                    cell.HorizontalAlignment = Element.ALIGN_CENTER; //Ortala
                    table.AddCell(cell);
                }

                //Satırları Ekle
                foreach (ListViewItem listviewItem in lstvTumPersonelBordrosu.Items) //Satırları döner
                {
                    foreach (ListViewItem.ListViewSubItem subItem in listviewItem.SubItems) //Satır içindeki hücreleri tek tek döner
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(subItem.Text, normalFont));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                    }
                }

                document.Add(table); //Oluşturulan tabloyu PDF belgesine ekler.
                document.Close(); //PDF belgesini kapatır ve kaydeder.

                MessageBox.Show("PDF başarıyla kaydedildi!");
            }
        }

        public void ExcelOlustur()
        {
            using (var workbook = new XLWorkbook()) //Yeni bir Excel çalışma kitabı oluşturur.
            {
                var workSheet = workbook.AddWorksheet($"Bordro_Raporu_{DateTime.Now:yyyyMMdd}"); //Yeni bir çalışma sayfası ekler ve tarih bazlı adlandırılır.( Dinamik )

                //Başlıklar
                string[] headers = { "Personel İsmi", "Kadro", "Çalışma Saati", "Ana Ödeme", "Mesai", "Toplam Ödeme" };
                for (int i = 0; i < headers.Length; i++)
                {
                    var headerCell = workSheet.Cell(1, i + 1);
                    headerCell.Value = headers[i];

                    headerCell.Style.Font.Bold = true; //Kalın
                    headerCell.Style.Fill.BackgroundColor = XLColor.LightGray;
                    headerCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center; //Orta hiza
                }

                //Verileri Ekle
                int satir = 2;
                foreach (ListViewItem listViewItem in lstvTumPersonelBordrosu.Items)
                {
                    //Her bir satırı Excel'e yazdırır.
                    workSheet.Cell(satir, 1).Value = listViewItem.SubItems[0].Text;
                    workSheet.Cell(satir, 2).Value = listViewItem.SubItems[1].Text;
                    workSheet.Cell(satir, 3).Value = listViewItem.SubItems[2].Text;
                    workSheet.Cell(satir, 4).Value = listViewItem.SubItems[3].Text;
                    workSheet.Cell(satir, 5).Value = listViewItem.SubItems[4].Text;
                    workSheet.Cell(satir, 6).Value = listViewItem.SubItems[5].Text;
                    satir++;
                }

                workSheet.Columns().AdjustToContents(); //Otomatik sütun genişliği ayarla

                //Tabloya Kenarlık Ekle
                var range = workSheet.Range(1, 1, satir - 1, headers.Length);
                range.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                range.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                //Oluşturulma Tarihi Ekle
                workSheet.Cell(satir + 1, 1).Value = $"Rapor Oluşturulma Tarihi: {DateTime.Now:dd MMMM yyyy HH:mm}";
                workSheet.Cell(satir + 1, 1).Style.Font.Italic = true;
                workSheet.Range(satir + 1, 1, satir + 1, headers.Length).Merge();

                using (SaveFileDialog saveFileDialog = new SaveFileDialog()) //Kullanıcıya kayıt yeri seçtirir.
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

        /// <summary>
        /// Bu metod Excel ve PDF dosyası oluşturup bunları e-posta ile gönderir.
        /// </summary>
        public void MailGonderExcelPDF()
        {
            try
            {
                //Masaüstünde dosya yollarını alır.
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string excelDosyaYolu = Path.Combine(desktopPath, "BordroRaporu.xlsx"); //C:\Users\KullanıcıAdı\Desktop\BordroRaporu.xlsx
                string pdfDosyaYolu = Path.Combine(desktopPath, "BordroRaporu.pdf"); //C:\Users\KullanıcıAdı\Desktop\BordroRaporu.pdf

                //EXCEL DOSYASI OLUŞTURMA
                using (var workbook = new XLWorkbook()) //ClosedXML kütüphanesinden bir Excel çalışma kitabı oluşturur.
                {
                    var worksheet = workbook.Worksheets.Add("Bordro Raporu"); //Yeni bir çalışma sayfası ekler.

                    //Excel Başlıkları
                    for (int col = 0; col < lstvTumPersonelBordrosu.Columns.Count; col++) //ListView'deki sütun sayısı kadar döner
                    {
                        var headerCell = worksheet.Cell(1, col + 1);
                        headerCell.Value = lstvTumPersonelBordrosu.Columns[col].Text; //Başlıkları Excel'e yazdırır.
                        headerCell.Style.Font.Bold = true;
                        headerCell.Style.Fill.BackgroundColor = XLColor.LightGray;
                        headerCell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    }

                    //Excel İçeriği
                    int row = 2;
                    foreach (ListViewItem listviewitem in lstvTumPersonelBordrosu.Items) //ListView içindeki tüm satırları döner.
                    {
                        for (int i = 0; i < listviewitem.SubItems.Count; i++) //Her satırdaki hücreleri döner.
                        {
                            var cell = worksheet.Cell(row, i + 1); //Hücreye listView'den gelen metni yazar.
                            cell.Value = listviewitem.SubItems[i].Text;
                            cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        }
                        row++;
                    }
                    worksheet.Columns().AdjustToContents(); //Tüm sütun genişliğini içeriğe göre ayarlar.
                    workbook.SaveAs(excelDosyaYolu); //Excel dosyasını belirtilen yolda kaydeder.
                }

                //PDF DOSYASI OLUŞTURMA
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance); //Türkçe karakter sorununu önler.
                using (FileStream fs = new FileStream(pdfDosyaYolu, FileMode.Create, FileAccess.Write, FileShare.None)) //PDF dosyası oluşturur veyazma modunda açar.
                {
                    Document document = new Document();
                    PdfWriter.GetInstance(document, fs); //PDF nesnesini oluşturur ve dosya akışına bağlar.
                    document.Open(); //PDF belgesini yazmak için açar.

                    //Türkçe Karakter Desteği ve Font
                    string arialTtf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf"); //Arial fontunu bulur.
                    BaseFont bf = BaseFont.CreateFont(arialTtf, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

                    iTextSharp.text.Font baslikFont = new iTextSharp.text.Font(bf, 18, iTextSharp.text.Font.BOLD);
                    iTextSharp.text.Font kalinFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD);
                    iTextSharp.text.Font normalFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);
                    iTextSharp.text.Font dateFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.ITALIC);

                    //Başlık Ekleme
                    Paragraph baslik = new Paragraph("Personel Bordrosu Raporu", baslikFont);
                    baslik.Alignment = Element.ALIGN_CENTER;
                    baslik.SpacingAfter = 10f;
                    document.Add(baslik);

                    //Tarih Ekleme
                    string currentDateTime = DateTime.Now.ToString("dd MMMM yyyy HH:mm");
                    Paragraph date = new Paragraph("Oluşturulma Tarihi: " + currentDateTime, dateFont);
                    date.Alignment = Element.ALIGN_RIGHT;
                    date.SpacingAfter = 20f;
                    document.Add(date);

                    //Tablo Oluşturma
                    PdfPTable table = new PdfPTable(lstvTumPersonelBordrosu.Columns.Count); //ListView sütun sayısı kadar kolon içeren bir PDF tablosu oluşturulur.
                    table.WidthPercentage = 100;

                    //Tablo Başlıkları
                    foreach (ColumnHeader column in lstvTumPersonelBordrosu.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.Text, kalinFont));
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                    }

                    //Tablo Satırları
                    foreach (ListViewItem listviewItem in lstvTumPersonelBordrosu.Items) //ListView'de ki satırları döner.
                    {
                        foreach (ListViewItem.ListViewSubItem subItem in listviewItem.SubItems) //Satırlardaki hücreleri döner
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(subItem.Text, normalFont));
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            table.AddCell(cell);
                        }
                    }

                    document.Add(table); //Tabloyu PDF'e ekler.
                    document.Close();
                }

                //Mail Hazırlama ve Gönderme
                MailMessage mail = new MailMessage();
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("berkayarslanyzl@gmail.com");
                mail.To.Add("linaa.arslann@gmail.com");
                mail.Body = "Maaş bordro raporu ektedir.";

                //Excel ve PDF dosyaları maile eklenir.
                mail.Attachments.Add(new Attachment(excelDosyaYolu));
                mail.Attachments.Add(new Attachment(pdfDosyaYolu));

                //Mail Sunucu Ayarları
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential("berkayarslanyzl@gmail.com", "dvkcizljotgfubov");
                smtpClient.EnableSsl = true;
                smtpClient.Send(mail); //Mail gönderilir.

                MessageBox.Show("Mail başarıyla gönderildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Mail gönderimi sırasında bir hata oluştur.\n Hata mesajı : {ex.Message}");
            }
        }

        private void btnAnaSayfayaGeriGec_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void Temizle()
        {
            lstvTumPersonelBordrosu.Items.Clear();
        }
    }


}


