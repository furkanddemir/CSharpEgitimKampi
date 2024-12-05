using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //DeğişkenTürü [] DiziAdı = new DeğişkenTürü[ElemanSayısı]
            //string[] colors = new string[4];
            //colors[0] = "kırmızı";
            //colors[1] = "sarı";
            //colors[2] = "beyaz";
            //colors[3] = "mavi";

            //Console.WriteLine(colors[2]);


            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";
            //Console.WriteLine(cities[5]);

            //int[] numbers = new int[10];
            //numbers[0] = 10;
            //numbers[1] = 150;
            //numbers[2] = 410;
            //numbers[3] = 110;
            //numbers[7] = 170;
            //Console.WriteLine(numbers[7]);


            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };
            //Console.WriteLine(cities[2]);



            #endregion

            #region Dizideki Tüm Elemanları Listeleme
            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };
            //for (int i = 0; i < colors.Length; i++) 
            //{
            //    Console.WriteLine(colors[i]);
            //}


            //int[] numbers = { 4, 65, 342, 5636, 753, 3452, 234, 5245, 765, 34521, 21 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}



            //char[] symbols = { 'A', 'B', 'C', '*', '/' };
            //for (int i = 0; i < symbols.Length; i++) 
            //{
            //    Console.WriteLine(symbols[i]);
            //}


            //Dizideki en büyük elemanı bulan
            //int[] benimDizim = { 47, 85, 96, 51, 25, 6321, 4, 8, 65, 21, 356 };
            //int maxNumber = benimDizim[0];

            //for (int i = 0; i < benimDizim.Length; i++)
            //{
            //    if (benimDizim[i] > maxNumber)
            //    {
            //        maxNumber = benimDizim[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //string[] personeller = { "Furkan", "Ahmet", "Ayşe", "Buse", "Cem" };
            //Console.WriteLine(personeller.Length);

            //sort metotu diziyi küçükten büyüğe sıralar
            //int[] numbers = { 1, 23, 4234, 2432, 569, 123, 5, 6, 742, 35 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //reverse metotu diziyi tersten sıralar.
            //int[] numbers = { 1, 23, 4234, 2432, 569, 123, 5, 6, 742, 35 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            #endregion

            #region Dizi Metotları

            //Array
            //string[] insanlar = { "Furkan", "Merve", "Ali", "Çınar" };
            //int index = Array.IndexOf(insanlar, "Furkan");
            //Console.WriteLine(index);


            //Max Min
            //int[] numbers = { 1, 2, 23, 43, 46, 12, 732, 214, 2354, 123 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max()
            //+ "Dizinin en küçük elemanı : "+ numbers.Min());



            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[6];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. şehri giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("-------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}



            //Tam sayı dizisindeki tüm elemanların toplamı

            //int[] numbers = { 10, 3, 4234, 135, 645 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}Console.WriteLine(sum);




            //Listedeki tek ve çidft sayıları ayrı ayrı listeleme

            int[] numbers = { 21, 42, 3, 47, 5, 6, 76, 87, 98, 40 };

            Console.WriteLine("Çift Sayılar");
            

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Tek Sayılar");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }


            #endregion
            Console.Read();
        }
    }
}
