using DuzceUniTez.Data;
using DuzceUniTez.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUniTez.Seeder
{
    public static class DataSeed
    {
        public static void Seed(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();

            var context = scope.ServiceProvider.GetService<AppDbContext>();

            //context.Database.Migrate();

            if (context.Fakulteler.Count() == 0)
            {
                context.Fakulteler.AddRange(
                    new List<Fakulte>() {
                         new Fakulte() { 
                             FakulteAd="Eğitim Fakültesi", 
                             FakulteAciklama="Eğitim Fakültesi 28.03.1983 tarihli ve 2809 sayılı Kanun’un ek 30. maddesine göre Bakanlar Kurulu’nca 04.04.2011 tarihinde kurulmuştur (15.04.2011 tarih ve 27906 sayılı Resmi Gazete).2012-2013 Eğitim-Öğretim Yılında Sınıf Öğretmenliği Lisans alanında 71 öğrenciyle eğitime başlamıştır. Aynı yılda  Pedagojik Formasyon Sertifika Programı açılmıştır. Fakülte öğretim üyelerince  Sosyal Bilimler Enstitüsü bünyesinde Yüksek Lisans eğitimi verilmektedir. Dekanlık ve eğitim faaliyetleri, Konuralp yerleşkesinde bulunan Teknoloji Fakültesi binası A Blokta sürdürülmektedir. ", 
                             FakulteMail="ogrenciisleri.ef@duzce.edu.tr",
                             FakulteTel="0380 542 13 55" , 
                             FakulteAdres="Düzce Üniversitesi Konuralp Yerleşkesi Konuralp Merkez/Düzce 81620",
                             FakulteResim="img_07-01-2022-16-18-54.jpg"
                         },

                         new Fakulte() { 
                             FakulteAd="Fen Edebiyat Fakültesi",
                             FakulteAciklama="17 Mart 2006 tarih ve 26111 sayılı Resmi Gazete’de yayınlanan 5467 sayılı Yasa ile kurulan Üniversitemiz bünyesinde yer alan Fakültemizde, YÖK’ün 07.12.2007 tarihli toplantısıyla alınan kararla ilk olarak Biyoloji, Fizik, Kimya, Matematik, Psikoloji, Sosyoloji ile Türk Dili ve Edebiyatı olmak üzere 7 bölümün açılmasına karar verilmiştir. Ayrıca YÖK’ün 02.06.2010 tarihli toplantısında alınan karar ile bu bölümlere Arkeoloji ve Tarih Bölümü, 07.09.2011 tarihli toplantısında alınan kararla da Sanat Tarihi Bölümü ve 05.07.2012 Tarihinde de Kafkas Dilleri ve Kültürleri Bölümü ve Felsefe Bölümü de açılarak Fakültemizdeki bölüm sayısı 12’ye yükselmiştir.",
                             FakulteMail="ogrenciisleri.fe@duzce.edu.tr",
                             FakulteTel="0380 541 24 04",
                             FakulteAdres="Düzce Üniversitesi Konuralp Yerleşkesi Konuralp Merkez/Düzce 81620",
                             FakulteResim="img_07-01-2022-16-18-38.jpg"
                         },

                         new Fakulte() { 
                             FakulteAd="İlahiyat Fakültesi",
                             FakulteAciklama="Düzce Üniversitesi bünyesinde “İlahiyat Fakültesi” açılması Üniversitemiz Senatosunun 12.12.2012 tarih ve 17 nolu toplantısında 2012/148 sayılı Kararı ile uygun görülmüş olup, söz konusu karar Üniversitemiz tarafından 17.12.2012 tarih ve 00.00/101.102-4041-9984 sayılı yazı ile  Yükseköğretim Kurulu Başkanlığına gönderilmiştir. Fakültemizin açılması ile ilgili dosya Yükseköğretim Kurulu Başkanlığı tarafından kabul edilmiş ve Yükseköğretim Kurumlarına bağlı olarak kurulması; Milli Eğitim Bakanlığı’na sunulmuş ve Yükseköğretim Kurumlarına bağlı olarak kurulması; Milli Eğitim Bakanlığı’nın teklif yazıları üzerine, 28.03.1983 tarih ve 2809 sayılı Kanunun ek 30.uncu maddesine göre, Bakanlar Kurulu’nca 29.04.2013 tarih ve 2013/4716 Karar Sayılı Kararıyla  Düzce Üniversitesi İlahiyat Fakültesi’nin açılması kararlaştırılmış, bu Karar 31 Mayıs 2013 Cuma günü 28663 saylı Resmi Gazetede yayımlanarak yürürlüğe girmiştir.",
                             FakulteMail="ogrenciisleri.ilf@duzce.edu.tr",
                             FakulteTel="0380 542 11 70" ,
                             FakulteAdres="Düzce Üniversitesi Konuralp Yerleşkesi Konuralp Merkez/Düzce 81620",
                             FakulteResim="img_07-01-2022-16-18-27.jpg"
                         },

                         new Fakulte() { 
                             FakulteAd="İşletme Fakültesi",
                             FakulteAciklama="Düzce Üniversitesi İşletme Fakültesi, 26 Şubat 2010 tarih ve 27505 sayılı Resmi Gazetede yayımlanan 2010/103 sayılı Bakanlar Kurulu kararı ile kurulmuş ve 2010-2011 Akademik Yılı'nda İşletme Bölümü ile lisans öğretimine başlamıştır. Fakültemiz; İşletme, Sağlık Yönetimi, Sigortacılık ve Sosyal Güvenlik, Uluslararası Ticaret ve Yönetim Bilişim Sistemleri olmak üzere beş bölümden oluşmaktadır.",
                             FakulteMail="ogrenciisleri.if@duzce.edu.tr",
                             FakulteTel="0380 542 13 70" ,
                             FakulteAdres="Düzce Üniversitesi Konuralp Yerleşkesi Konuralp Merkez/Düzce 81620",
                             FakulteResim=""
                         },

                         new Fakulte() { 
                             FakulteAd="Mühendislik Fakültesi",
                             FakulteAciklama="Düzce Üniversitesi Mühendislik Fakültesi 9 Mayıs 2008 tarihinde kurulmuş, 2009-2010 eğitim-öğretim yılından itibaren öğrenci almaya, 2013 yılından itibaren ilk mezunlarını vermeye başlamıştır.",
                             FakulteMail="ogrenciisleri.mf@duzce.edu.tr",
                             FakulteTel="0380 542 10 36" ,
                             FakulteAdres="Düzce Üniversitesi Konuralp Yerleşkesi Konuralp Merkez/Düzce 81620",
                             FakulteResim="img_07-01-2022-16-18-11.jpg"
                         },

                         new Fakulte() { 
                             FakulteAd="Orman Fakültesi",
                             FakulteAciklama="1992 yılında Abant İzzet Baysal Üniversitesi’ne bağlı olarak Düzce’de kurulan, daha sonra 2006 yılında kurulan Düzce Üniversitesi bünyesine dahil olan fakültemizde; Ağaç İşleri Endüstri Mühendisliği Bölümü, Peyzaj Mimarlığı Bölümü, Orman Endüstri Mühendisliği Bölümü, Orman Mühendisliği Bölümü; lisans ve lisansüstü düzeyde öğretim faaliyeti vermektedir.",
                             FakulteMail="ogrenciisleri.of@duzce.edu.tr",
                             FakulteTel="0380 542 11 37" ,
                             FakulteAdres="Düzce Üniversitesi Konuralp Yerleşkesi Konuralp Merkez/Düzce 81620",
                             FakulteResim="img_07-01-2022-16-18-02.jpg"
                         },

                         new Fakulte() { FakulteAd="Sağlık Bilimleri Fakültesi",
                             FakulteAciklama="Fakültemiz 1996 yılındaki Sağlık Şurasında alınan karardan sonra; 10 Ekim 1996 tarih ve 96/8655 sayılı Bakanlar Kurulu Kararı ile Sağlık Meslek Liselerinin Sağlık Yüksekokullarına dönüştürülmesi sonucunda Düzce Sağlık Meslek Lisesi de Düzce Sağlık Yüksekokulu adıyla A.İ.B.Ü. ‘ne bağlanmıştır. 10 yıl boyunca adı geçen Üniversite için hizmet verdikten sonra 2006 yılında Düzce Üniversitesi’nin kurulmasıyla Üniversitemiz bünyesinde eğitim-öğretim faaliyetini sürdürmektedir. 12 Ocak 2017 tarih ve 29946 sayılı Resmi Gazetede yayımlanan 12 Aralık 2016 tarih ve 9648 sayılı Bakanlar Kurulu Kararı ile Sağlık Yüksekokulu kapatılarak yerine Sağlık Bilimleri Fakültesi kurulmuştur.",
                             FakulteMail="ogrenciisleri.sbf@duzce.edu.tr",
                             FakulteTel="0380 542 11 41" ,
                             FakulteAdres="Düzce Üniversitesi Konuralp Yerleşkesi Konuralp Merkez/Düzce 81620",
                             FakulteResim="img_07-01-2022-16-17-52.jpg"
                         },

                         new Fakulte() { 
                             FakulteAd="Spor Bilimleri Fakültesi",
                             FakulteAciklama="Fakültemiz, 03.07.2011 tarih ve 27983 sayılı Resmi Gazetede yayınlanan Bakanlar Kurulu Kararı ile Beden Eğitimi ve Spor Yüksekokulu olarak kurulmuştur. 25.01.2016 tarihli ve 2016/8562 sayılı kararname ile akademik faaliyetlerini Spor Bilimleri Fakültesi adıyla sürdürmektedir. ",
                             FakulteMail="ogrenciisleri.spbf@duzce.edu.tr",
                             FakulteTel="0380 542 11 45" ,
                             FakulteAdres="Düzce Üniversitesi Konuralp Yerleşkesi Konuralp Merkez/Düzce 81620",
                             FakulteResim="img_07-01-2022-16-17-46.jpg"
                         },

                         new Fakulte() { 
                             FakulteAd="Tıp Fakültesi",
                             FakulteAciklama="Tıp Fakültesi  1992 yılında Abant İzzet Baysal Üniversitesi’ne bağlı olarak kurulmuş  ve 1996 yılında Eğitim-Öğretim faaliyetlerine başlamıştır. Tıp Fakültemiz 2006 yılında çıkan 5467 sayılı kanunla yeni kurulan Düzce Üniversitesi’ne bağlanmıştır.",
                             FakulteMail="ogrenciisleri.tipf@duzce.edu.tr",
                             FakulteTel="0380 542 14 16" ,
                             FakulteAdres="Düzce Üniversitesi Konuralp Yerleşkesi Konuralp Merkez/Düzce 81620",
                             FakulteResim="img_07-01-2022-16-18-46.jpg"
                         },

                         new Fakulte() { 
                             FakulteAd="Ziraat Fakültesi",
                             FakulteAciklama="Ziraat Fakültesi; 23 Mart 2012 tarih ve 28242 sayılı Resmi Gazetede yayımlanan 2012/2883 sayılı Bakanlar Kurulu Kararı ile ¨Ziraat ve Doğa Bilimleri Fakültesi¨ adı ile kurulmuştur. 2809 sayılı Yükseköğretim Kurumları Teşkilatı Kanunu’nun ek 30. maddesi gereğince 27 Mart 2020 tarih ve 2319 sayılı Cumhurbaşkanı Kararı ile adı 'Ziraat Fakültesi' olarak değiştirilmiştir.",
                             FakulteMail="ogrenciisleri.zf@duzce.edu.tr",
                             FakulteTel="0380 541 22 94" ,
                             FakulteAdres="Düzce Üniversitesi Konuralp Yerleşkesi Konuralp Merkez/Düzce 81620",
                             FakulteResim="img_07-01-2022-16-17-38.jpg"
                         },
                    });

                context.Enstituler.AddRange(
                    new List<Enstitu>() {
                         new Enstitu() {
                            EnsitutuAd = "Lisansüstü Eğitim Enstitüsü",
                            EnsitutuAciklama = "17 Mart 2006 tarih ve 26111 sayılı Resmi Gazete’de yayınlanan 5467 sayılı yasa ile Düzce Üniversitesi kurulduktan sonra 23.08.2007 tarihinden itibaren Düzce Üniversitesi bünyesinde yer alan Sosyal Bilimler Enstitüsü, 2547 sayılı Yükseköğretim Yasasının 19. maddesi gereğince 18.01.2007 tarihinde Eğitim-Öğretimine başlayan Sağlık Bilimleri Enstitüsü, 17/03/2006 tarihinde kurulmuş olan Fen Bilimleri Enstitüsü ve 01.11.2016 tarihli Resmi Gazete’de yer alan Bakanlar Kurulu Kararı ile kurulmuş olan Güzel Sanatlar Enstitüsü 29.06.2021 tarih ve 31526 sayılı Resmi Gazetede yayımlanarak yürürlüğe giren 4180 sayılı Cumhurbaşkanlığı Kararı ile kapatılmış Düzce Üniversitesi Lisansüstü Eğitim Enstitüsü kurulmuştur.",
                            EnsitutuMail ="lisansustu@duzce.edu.tr",
                            EnsitutuTel = "0380 542 14 37",
                            EnsitutuAdres = "Düzce Üniversitesi Konuralp Yerleşkesi Konuralp Merkez/Düzce 81620",
                            EnsitutuResim="img_07-01-2022-16-25-42.jpg"
                         },
                    });

                context.YuksekOkullar.AddRange(
                    new List<YuksekOkul>() {
                         new YuksekOkul() {
                            YuksekOkulAd = "Akçakoca Turizm İş. ve Otelcilik Y.",
                            YuksekOkulAciklama = "Akçakoca Turizm İşletmeciliği ve Otelcilik Yüksekokulu, 11.07.1992 gün ve 3837 sayılı kanun ile Abant İzzet Baysal Üniversitesi'ne bağlı olarak kurulmuş, 29 Kasım 1993'te Eğitim- Öğretim faaliyetine başlamıştır. 17.03.2006'da 5467 sayılı kanun ile Düzce Üniversitesi'ne bağlanmıştır. 2006-2007 öğretim yılından itibaren Düzce Üniversitesi Akçakoca Yerleşkesinde faaliyetlerini sürdürmektedir.",
                            YuksekOkulMail = "turizm@duzce.edu.tr",
                            YuksekOkulTel = "0380 611 29 99",
                            YuksekOkulAdres = "Akçakoca Yerleşkesi Osmaniye Mahallesi Atatürk Cad. No: 221 Akçakoca/Düzce 81650",
                            YuksekOkulResim="img_07-01-2022-16-27-12.jpg"
                         },
                         new YuksekOkul() {
                            YuksekOkulAd = "Hakime Erciyas Yabancı Diller Y.",
                            YuksekOkulAciklama = "Düzce Üniversitesi Hakime Erciyas Yabancı Diller Yüksekokulu 22 Ağustos 2010 tarih ve 27680 sayılı Resmi Gazetede yayımlanan 2010/776 sayılı Bakanlar Kurulu Kararı ile kurulmuştur. Hakime Erciyas Yabancı Diller Yüksekokulu Konuralp Kampüsü içinde yer alan binasında hizmet vermektedir.",
                            YuksekOkulMail = "ogrenciisleri.ydy@duzce.edu.tr",
                            YuksekOkulTel = "0380 542 11 63",
                            YuksekOkulAdres = "Konuralp Yerleşkesi Merkez/DÜZCE 81620",
                            YuksekOkulResim="img_07-01-2022-16-27-05.jpg"
                         },
                    });

                context.MeslekYuksekOkullar.AddRange(
                    new List<MeslekYuksekOkul>() {
                         new MeslekYuksekOkul() { 
                            MeslekYuksekOkulAd = "Akçakoca Meslek Yüksekokulu",
                            MeslekYuksekOkulAciklama = "Akçakoca Meslek Yüksekokulu 11.07.1992 tarih ve 3837 sayılı Kanun ile kurulmuştur. 17.03.2006’da 5467 sayılı Kanun ile Düzce Üniversitesi’ne bağlanmıştır. 2006-2007 Öğretim Yılında itibaren Düzce Üniversitesi Akçakoca Yerleşkesinde faaliyetlerini sürdürmektedir.",
                            MeslekYuksekOkulMail = "akmyo@duzce.edu.tr",
                            MeslekYuksekOkulTel = "0380 611 84 19",
                            MeslekYuksekOkulAdres = "DÜZCE ÜNİVERSİTESİ AKÇAKOCA YERLEŞKESİ, Osmaniye Mah. Atatürk Cad. No 221",
                            MeslekYuksekOkulResim="img_07-01-2022-16-31-21.jpg"
                         },
                         new MeslekYuksekOkul() {
                            MeslekYuksekOkulAd = "Çilimli Meslek Yüksekokulu",
                            MeslekYuksekOkulAciklama = "2008 yılında kurulan Çilimli Meslek Yüksekokulu Çilimli ilçe merkezinde 8.933,45 m2 açık, 1098 m2 kapalı alana sahiptir.  Üç katlı olan okul binasında altı adet derslik, yedi adet idari oda, 29 adet bilgisayarın bulunduğu bir adet bilgisayar laboratuvarı, öğrencilere uygulama imkânı sunan bir adet Toprak-Bitki-Su analiz laboratuvarı mevcuttur. Ayrıca bir adet basketbol sahası, Bitkisel ve Hayvansal Üretim Bölüm uygulamaları için 130 m2’lik  bir sera ile, öğrencilerimizin ve personelimizin kullanımına yönelik  105 m²’lik bir kantin ve yemekhane bulunmaktadır.",
                            MeslekYuksekOkulMail = "akmyo@duzce.edu.tr",
                            MeslekYuksekOkulTel = "0380 611 84 19",
                            MeslekYuksekOkulAdres = "DÜZCE ÜNİVERSİTESİ AKÇAKOCA YERLEŞKESİ, Osmaniye Mah. Atatürk Cad. No 221",
                            MeslekYuksekOkulResim="img_07-01-2022-16-31-36.jpg"
                         },
                         new MeslekYuksekOkul() {
                            MeslekYuksekOkulAd = "Cumayeri Meslek Yüksekokulu",
                            MeslekYuksekOkulAciklama = "Yükseköğretim Kurulu Başkanlığı’nın Yükseköğretim Genel Kurulu 07.12.2007 tarihli toplantısında Düzce İli Cumayeri İlçesinde, Düzce Üniversitesine bağlı Cumayeri Meslek Yüksekokulunun kurulması yönünde karar almıştır. Cumayeri Belediyesi’nin Düzce Üniversitesi’ne tahsis etmiş olduğu 3768 m2’si açık, 1540 m2’si kapalı hizmet binası olmak üzere toplam 5308 m2 alanda eğitim-öğretim faaliyetine başlamıştır. 2015 yılı Eylül ayında Üniversitemiz ile Cumayeri Belediyesi ve bağışçı Nevhiz PAK arasında imzalanan protokol gereğince yapımına başlanan 2600 m2 kapalı alan çalışması 2016 yılında tamamlanmıştır.",
                            MeslekYuksekOkulMail = "akmyo@duzce.edu.tr",
                            MeslekYuksekOkulTel = "0380 611 84 19",
                            MeslekYuksekOkulAdres = "DÜZCE ÜNİVERSİTESİ AKÇAKOCA YERLEŞKESİ, Osmaniye Mah. Atatürk Cad. No 221",
                            MeslekYuksekOkulResim="img_07-01-2022-16-31-14.jpg"
                         },
                         new MeslekYuksekOkul() {
                            MeslekYuksekOkulAd = "Gölyaka Meslek Yüksekokulu",
                            MeslekYuksekOkulAciklama = "Gölyaka Meslek Yüksekokulu, Yükseköğretim Kurumu’nun 19.03.2008 tarih ve 927/6489 sayılı olur kararı ile Teknik Programların bünyesinde Bilgisayar Programcılığı programı ve İktisadi Programların bünyesinde Turizm ve Otel işletmeciliği ve E-Ticaret Programları açılması yönünde karar alınmış ve 23.10.2008 yılında resmi açılışı gerçekleştirilmiştir.",
                            MeslekYuksekOkulMail = "akmyo@duzce.edu.tr",
                            MeslekYuksekOkulTel = "0380 611 84 19",
                            MeslekYuksekOkulAdres = "DÜZCE ÜNİVERSİTESİ AKÇAKOCA YERLEŞKESİ, Osmaniye Mah. Atatürk Cad. No 221",
                            MeslekYuksekOkulResim="img_07-01-2022-16-31-08.jpg"
                         },
                         new MeslekYuksekOkul() {
                            MeslekYuksekOkulAd = "Gümüşova Meslek Yüksekokulu",
                            MeslekYuksekOkulAciklama = "Gümüşova Meslek Yüksekokulu 2008 yılında, Düzce ilinin Gümüşova ilçesinde, ilk olarak Makine Resim Konstrüksiyon, Metalurji, İş Sağlığı ve Güvenliği programlarıyla kurulmuştur. Sonrasında eklenen yeni programlarla; Metalurji, Makine Resim Konstrüksiyon, Kaynak Teknolojisi, İş Sağlığı ve Güvenliği ve Üretimde Kalite Kontrol olmak üzere 5 program ve 413 kayıtlı öğrencisiyle eğitim ve öğretime devam edilmektedir.",
                            MeslekYuksekOkulMail = "akmyo@duzce.edu.tr",
                            MeslekYuksekOkulTel = "0380 611 84 19",
                            MeslekYuksekOkulAdres = "DÜZCE ÜNİVERSİTESİ AKÇAKOCA YERLEŞKESİ, Osmaniye Mah. Atatürk Cad. No 221",
                            MeslekYuksekOkulResim="img_07-01-2022-16-31-00.jpg"
                         },
                         new MeslekYuksekOkul() {
                            MeslekYuksekOkulAd = "Kaynaşlı Meslek Yüksekokulu",
                            MeslekYuksekOkulAciklama = "Kaynaşlı Meslek Yüksekokulu (KMYO); Düzce Üniversitesi’nin 2006 yılında eğitime açılmasıyla Kaynaşlı’ da 2007 yılında başlatılan meslek yüksekokulu kurma çalışmaları sonucunda, 2547 sayılı Kanunun 2880 sayılı Kanunla değişik 7/d- 2. maddesi uyarınca 2008 yılında kurulmuştur.",
                            MeslekYuksekOkulMail = "akmyo@duzce.edu.tr",
                            MeslekYuksekOkulTel = "0380 611 84 19",
                            MeslekYuksekOkulAdres = "DÜZCE ÜNİVERSİTESİ AKÇAKOCA YERLEŞKESİ, Osmaniye Mah. Atatürk Cad. No 221",
                            MeslekYuksekOkulResim="img_07-01-2022-16-31-30.jpg"
                         },
                    });

                context.Duyurular.AddRange(
                    new List<Duyuru>() {
                         new Duyuru() { 
                             DuyuruBaslik="Üniversitemiz Hastanesi’nde Büyük Bakım Onarım Başladı", 
                             DuyuruAciklama="Üniversitemiz Hastanesi, hasta ve hasta yakınlarına daha kaliteli, güvenli ve modern bir ortamda sağlık hizmeti sunabilmek amacıyla büyük bakım ve onarım çalışmalarına başladı.",
                             DuyuruResim = "img_07-01-2022-16-07-47.png"
                         },

                         new Duyuru() { 
                             DuyuruBaslik="Öğrencilerimiz “Açık Mutfak”ta",
                             DuyuruAciklama="Her alanda olduğu gibi beslenme hizmetlerinde de şeffaflığa verdiği önemi gösteren Üniversitemiz, “Açık Mutfak: Yemeğim Nasıl Pişiyor?” etkinliği kapsamında öğrencilerini, Konuralp Yerleşkesi Karavana Mutfağı’nda konuk etti.",
                             DuyuruResim = "img_07-01-2022-16-11-26.png"
                         },

                         new Duyuru() { 
                             DuyuruBaslik="Üniversitemiz Süs ve Tıbbi Bitkiler Botanik Bahçesi’nde Bitkilendirme Çalışmalarına Başlandı",
                             DuyuruAciklama="Alt yapısı Üniversitemiz Rektörlüğü tarafından tamamlanan, Orman Fakültemiz ile Süs ve Tıbbi Bitkiler Üretim Uygulama ve Araştırma Merkezimizin özverili çalışmaları ile sona gelinen “Üniversitemiz Süs ve Tıbbi Bitkiler Botanik Bahçesi” yatırımında ilk bitki dikimi, düzenlenen törenle gerçekleştirildi.",
                             DuyuruResim = "img_07-01-2022-16-11-10.png"
                         },

                         new Duyuru() { 
                             DuyuruBaslik="Kariyer Yolunda Bilgi ve Deneyimlerini Paylaştı",
                             DuyuruAciklama="Üniversitemiz Kariyer Geliştirme ve Mezun İzleme Uygulama Araştırma Merkezi Müdürü Dr. Öğr. Üyesi Senem Çolak Yazıcı, Düzce Uğur Fen ve Anadolu Lisesi Okullarının Kariyer Günleri etkinliğine katıldı.",
                             DuyuruResim = "img_07-01-2022-16-11-19.png"
                         },
                    });

                context.Etkinlikler.AddRange(
                    new List<Etkinlik>() {
                         new Etkinlik() { 
                             EtkinlikBaslik="Yemen’de Neler Oluyor?",
                             EtkinlikAciklama="Etkinliğe Katılmak İçin adresi ziyaret ediniz-https://3b.duzce.edu.tr/b/ahm-uvv-6zc",
                             EtkinlikResim="img_07-01-2022-16-12-45.png"
                         },

                         new Etkinlik() { 
                             EtkinlikBaslik="Uçak Motorları ve Havacılık Sanayi Tedarik Zinciri",
                             EtkinlikAciklama="Uçak Motorları ve Havacılık Sanayi Tedarik Zinciri",
                             EtkinlikResim="img_07-01-2022-16-12-52.png"
                         },

                         new Etkinlik() { 
                             EtkinlikBaslik="Hayatın Renkleri",
                             EtkinlikAciklama="Hayatın Renkleri radyo programına katılmayı unutmayın!",
                             EtkinlikResim="img_07-01-2022-16-12-58.png"
                         },
                    });

                context.Haberler.AddRange(
                    new List<Haber>() {
                         new Haber() {
                             HaberBaslik="Düzce Valisi Cevdet Atay ve Beraberindeki Heyet Rektörümüzü Ziyaret Etti",
                             HaberAciklama="Düzce Valisi Cevdet Atay, Cumhuriyet Başsavcısı Sedat Çelik, İl Jandarma Komutanı Albay Naci Akkaş, Düzce Ticaret ve Sanayi Odası Yönetim Kurulu Başkanı Tuncay Şahin Rektörümüz Prof. Dr. Nigar Demircan Çakar’ı ziyaret etti.",
                             HaberKategori="Diğer",
                             HaberResim="img_07-01-2022-16-15-03.png"
                         },

                         new Haber() {
                             HaberBaslik="Uluslararası Sezai Karakoç Sempozyumu",
                             HaberAciklama="Dicle Üniversitesi ev sahipliğinde Diyarbakır Valiliği, Dicle Üniversitesi, Ankara Hacı Bayram Veli Üniversitesi, Cihannüma Dayanışma ve İşbirliği Derneği ve Diyarbakır Büyükşehir Belediyesi'nin iştirakiyle; yakın zamanda ebediyete uğurladığımız merhum Sezai KARAKOÇ'un fikriyatı, hatırası, eserleri, ekonomik, toplumsal ve siyasal görüşleri ve bunların günümüze yansımalarını müzakere etmek üzere 26-28 Mayıs 2022 tarihlerinde, memleketi Diyarbakır'da “Uluslararası Sezai Karakoç Sempozyumu” düzenlenecektir.",
                             HaberKategori="Akademik",
                             HaberResim="img_07-01-2022-16-14-56.jpg"
                         },

                         new Haber() {
                             HaberBaslik="Üniversitemiz GreenMetric Endeksi’nde İlerleyişini Sürdürüyor",
                             HaberAciklama="Çevre düzenlemesi, enerji, iklim değişikliği, atık, su, ulaşım, eğitim ve karbon ayak izi ölçümleri gibi farklı alanlardaki çeşitli kriterlere göre sıralama yapan GreenMetric Endeksi’nde Üniversitemiz yine yerini aldı.",
                             HaberKategori="Diğer",
                             HaberResim="img_07-01-2022-16-15-14.png"
                         },

                         new Haber() {
                             HaberBaslik="Öğrencilerimiz “Açık Mutfak”ta",
                             HaberAciklama="Her alanda olduğu gibi beslenme hizmetlerinde de şeffaflığa verdiği önemi gösteren Üniversitemiz, “Açık Mutfak: Yemeğim Nasıl Pişiyor?” etkinliği kapsamında öğrencilerini, Konuralp Yerleşkesi Karavana Mutfağı’nda konuk etti.",
                             HaberKategori="Sağlık",
                             HaberResim="img_07-01-2022-16-15-09.png"
                         },
                    });
            }
            context.SaveChanges();

        }
    }
}
