using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnSoruluSinavSistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SORULAR SINIFTAN ÇEKME
            Sorular[] sorular = new Sorular[10];
            Console.WriteLine("      GENEL KÜLTÜR SINAVINA HOŞGELDİNİZ ");
            Console.WriteLine();
            sorular[0] = new Sorular();
            sorular[0].numara = 1;
            sorular[0].soru = "Türkiye'nin Başkenti Neresidir ?";
            sorular[0].islem1 = "Elazığ";
            sorular[0].islem2 = "Eskişehir";
            sorular[0].islem3 = "Ankara";
            sorular[0].islem4 = "İstanbul";
            sorular[0].secim = 0;

            sorular[1] = new Sorular();
            sorular[1].numara = 2;
            sorular[1].soru = "Rusya'nın Başkenti Neresidir ?";
            sorular[1].islem1 = "Dinamo Kiev";
            sorular[1].islem2 = "Moskova";
            sorular[1].islem3 = "St.Petersburg";
            sorular[1].islem4 = "Novosibirsk";
            sorular[1].secim = 0;

            sorular[2] = new Sorular();
            sorular[2].numara = 3;
            sorular[2].soru = "Fransa'nın Başkenti Neresidir ?";
            sorular[2].islem1 = "Bordeaux";
            sorular[2].islem2 = "Paris";
            sorular[2].islem3 = "Nice";
            sorular[2].islem4 = "Marsilya";
            sorular[2].secim = 0;

            sorular[3] = new Sorular();
            sorular[3].numara = 4;
            sorular[3].soru = "Facebook'un Kurucusu Kimdir";
            sorular[3].islem1 = "Elon Musk";
            sorular[3].islem2 = "Steve Jobs";
            sorular[3].islem3 = "Bill Gates";
            sorular[3].islem4 = "Mark Zuckerberg";
            sorular[3].secim = 0;

            sorular[4] = new Sorular();
            sorular[4].numara = 5;
            sorular[4].soru = "Telefonun İcadı Kime Aittir ?";
            sorular[4].islem1 = "Nicole Tesla";
            sorular[4].islem2 = "Alexander Graham Bell";
            sorular[4].islem3 = "Martin Cooper";
            sorular[4].islem4 = "Elon Musk";
            sorular[4].secim = 0;

            sorular[5] = new Sorular();
            sorular[5].numara = 6;
            sorular[5].soru = "Selfie'nin Türkçe Anlamı Nedir ?";
            sorular[5].islem1 = "Ön Çekim";
            sorular[5].islem2 = "Yan Çekim";
            sorular[5].islem3 = "Öz Çekim";
            sorular[5].islem4 = "Fotoğraf";
            sorular[5].secim = 0;

            sorular[6] = new Sorular();
            sorular[6].numara = 7;
            sorular[6].soru = "“Sinekli Bakkal” Romanının Yazarı Aşağıdakilerden Hangisidir?";
            sorular[6].islem1 = "Reşat Nuri Güntekin";
            sorular[6].islem2 = "Halide Edip Adıvar";
            sorular[6].islem3 = "Ziya Gökalp";
            sorular[6].islem4 = "Ömer Seyfettin";
            sorular[6].secim = 0;

            sorular[7] = new Sorular();
            sorular[7].numara = 8;
            sorular[7].soru = "2003 Yılında Euro Vizyon Şarkı Yarışmasında Ülkemizi Temsil Eden ve Yarışmada Birinci Gelen Sanatçımız Kimdir?";
            sorular[7].islem1 = "Grup Athena";
            sorular[7].islem2 = "Sertap Erener";
            sorular[7].islem3 = "Şebnem Paker";
            sorular[7].islem4 = "Ajda Pekkan";
            sorular[7].secim = 0;

            sorular[8] = new Sorular();
            sorular[8].numara = 9;
            sorular[8].soru = " Mustafa Kemal Atatürk’ün Nüfusa Kayıtlı Olduğu İl Hangisidir?";
            sorular[8].islem1 = "Bursa";
            sorular[8].islem2 = "Ankara";
            sorular[8].islem3 = "İstanbul";
            sorular[8].islem4 = "Gaziantep";
            sorular[8].secim = 0;

            sorular[9] = new Sorular();
            sorular[9].numara = 10;
            sorular[9].soru = "Aşağıdakilerden Hangisi Dünya Sağlık Örgütünün Kısaltılmış İsmidir?";
            sorular[9].islem1 = "Uhw";
            sorular[9].islem2 = "Unıcef";
            sorular[9].islem3 = "Who";
            sorular[9].islem4 = "Nato";
            sorular[9].secim = 0;

            #endregion
            #region ÖĞRENCİ TANIMLAMA
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.ad = "";
            ogrenci.soyAd = "";
            ogrenci.ogrenciNo = "";

            Console.WriteLine(" LÜTFEN KONSOL EKRANINI TAM EKRAN YAPINIZ");
            Console.WriteLine();
            Console.WriteLine("ADINIZ ?");
            ogrenci.ad = Console.ReadLine();
            Console.WriteLine("SOYADINIZ ?");
            ogrenci.soyAd = Console.ReadLine();
            Console.WriteLine("öĞRENCİ NUMARANIZ ?");
            ogrenci.ogrenciNo = Console.ReadLine();
            Console.Clear();
            #endregion
            int secm = 0;
            Console.WriteLine($"Sayın {ogrenci.ad} GENEL KÜLTÜR SINAVINA HOŞGELDİN");
            Console.WriteLine();
            Console.WriteLine("SINAVDA 10 SORU VAR VE HER SORU 10 PUAN DEĞERİNDE, İSTEDİĞİNİZ SORUDAN BAŞLAYABİLİRSİNİZ BAŞLAMAK İSTEDİĞİNİZ SORUNUN NUMARASINI TUŞLAYARAK YANITLAYABİLİRSİNİZ");
            Console.WriteLine("BAŞARILAR :)");
            for (int i = 0; i < sorular.Length; i++)
            {
                Console.WriteLine($"{sorular[i].numara}-) {sorular[i].soru}");
                Console.WriteLine($"A-) {sorular[i].islem1}    B-) {sorular[i].islem2}    C-) {sorular[i].islem3}    D-) {sorular[i].islem4}");
                Console.WriteLine();
                secm = sorular[i].secim;
                

            }
            if (true)
            {
                Console.WriteLine("Çözmek İstediğin Soruyu Tuşla");
                secm = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(secm);
            }

        }
    }
}
