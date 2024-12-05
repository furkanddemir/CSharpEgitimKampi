using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //int i;

            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 1; i < 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i = 3; i <= 50; i +=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue=int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}

            #endregion


            #region For Döngüsü ile Karar Yapıları

            //for (int i = 1; i<= 100; i++){
            //    if (i % 5 == 0) {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;
            //for(int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            //int totalValue = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("------");
            //Console.WriteLine(totalValue);

            //int count = 0;

            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //int bakteri = 1;
            //for (int i = 1; i<=24;i++)
            //{
            //    bakteri *= 2;
            //    Console.WriteLine(i+ ".saat sonunda: " + bakteri + " bakteri bulunmaktadır.");
            //}
            #endregion

            #region While Döngüsü

            //While(Şart)
            //{
            //İşlemler
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10) {
            //    if (i % 3 == 0) {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while(i <= 10)
            //{
            //    sum+=i;
            //    i++;
            //}
            //Console.WriteLine(sum);




            #endregion

            #region Örnek Sınav Sorusu

            //Klavyeden girilen üç basamaklı sayınının basamaklarının
            //toplamını hesaplayan kodu yazın.

            //int sayi1;
            //Console.Write("3 basamaklı sayı girin: ");
            //sayi1=int.Parse(Console.ReadLine());
            //int birler, onlar, yuzler;
            //int toplam;

            //birler = sayi1 % 10;
            //onlar = (sayi1 % 100)/10;
            //yuzler = sayi1 / 100;

            //Console.WriteLine(birler + "-" + onlar + "-" + yuzler);
            //toplam=birler+onlar+yuzler;
            //Console.WriteLine(toplam);

            #endregion

            //Girilen iki sayı arasındaki tek sayıları yazdıran program 

            //int sayi1,sayi2;
            //Console.Write("1. sayıyı girin: ");
            //sayi1=int.Parse(Console.ReadLine());

            //Console.Write("2. sayıyı girin: ");
            //sayi2 = int.Parse(Console.ReadLine());

            //for (int i = sayi1; i <= sayi2; i += 1)
            //{
            //    if (i % 2 != 0) // Tek sayı kontrolü
            //        Console.WriteLine(i);
            //}
            Console.Read();
        }
    }
}
