using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Ondalıklı Değişkenler

            //double number=4.85;
            //Console.WriteLine(number);



            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.75;
            //tomatoPrice = 6.99;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice+ "TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice +"TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + "TL");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + "TL");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + "TL");

            //double appleGram,orangeGram,strawberryGram, potatoGram, tomatoGram;

            //Console.WriteLine();

            //appleGram = 1.234;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;


            //Console.WriteLine("Alınan ürün : Elma - "+ "Birim Fiyat: "+ applePrice+ "- Gramaj: " + appleGram+ " - Toplam Tutar: "+ appleTotalPrice);
            //Console.WriteLine("Alınan ürün : Portakal - "+ "Birim Fiyat: "+ orangePrice+ "- Gramaj: " + orangeGram+ " - Toplam Tutar: "+ orangeTotalPrice);
            //Console.WriteLine("Alınan ürün : Çilek - "+ "Birim Fiyat: "+ strawberryPrice+ "- Gramaj: " + strawberryGram+ " - Toplam Tutar: "+ strawberryTotalPrice);
            //Console.WriteLine("Alınan ürün : Patates - "+ "Birim Fiyat: "+ potatoPrice+ "- Gramaj: " + potatoGram+ " - Toplam Tutar: "+ potatoTotalPrice);
            //Console.WriteLine("Alınan ürün : Domates - "+ "Birim Fiyat: "+ tomatoPrice+ "- Gramaj: " + tomatoGram+ " - Toplam Tutar: "+ tomatoTotalPrice);

            //double shoppingTotalPrice=appleTotalPrice+orangeTotalPrice+strawberryTotalPrice+potatoTotalPrice+tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice + "TL");

            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bİlgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yaş Bilgisi: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber + " - Yolcu Ad Soyad: " + passengerName + " " + 
            //    passengerSurname + " " + passengerCity + " / " + passengerDistrict + " " + passengerAge);




            #endregion


            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.WriteLine("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice= shoesCount*shoesPrice+ computerCount*computerPrice+ chairCount*chairPrice+ tvCount*tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar" + totalPrice + "TL");

            #endregion

            #region Klavyeden Double Ondalıklı Sayı İşlemleri 

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. Sınav Notunu Giriniz: ");
            //exam1= double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);


            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz: ");
            //gender = char.Parse(Console.ReadLine());
            
            //Console.WriteLine("Seçtiğiniz Cinsiyet: "+ gender);
            #endregion
            Console.Read();


           

        }
    }
}
