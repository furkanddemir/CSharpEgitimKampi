using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1;2;3;4)

            //1. Parametre : Değişken Türü
            //2. Parametre : Değişken Adı
            //3. Parametre : In komutu
            //4. Parametre : Liste,Koleksiyon veya Dizi adı


            //string[] cities = { "Milano", "Roma", "İstanbul", "Kayseri", "Ankara" };
            //foreach (string x in cities) 
            //{
            //    Console.WriteLine(x);
            //}




            //int[] numbers = { 1, 23, 23, 4647, 5423, 123546, 7423, 83, 12 };
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}



            //int[] numbers = { 1, 23, 23, 4647, 5423, 123546, 7423, 83, 12 };
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}


            //int[] numbers = { 1, 23, 23, 4647, 5423, 123546, 7423, 83, 12 };
            //int total = 0;
            //foreach (int i in numbers) 
            //{
            //    total += i; 
            //} 
            //Console.WriteLine(total);+


            //Liste oluşturma
            //List<int> numbers = new List<int>()
            //{
            //1,2,3,4,5,6,7,8
            //};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Bir kelimeyi harflerine ayıran kod
            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}
            #endregion

            #region Örnek Sınav Sistemi Uygulaması
            //GENEL TEKRAR
            //Klavyeden alınan öğrenci sayısı ve sınav notları ile oratalamını hesaplama
            //Dizi, döngü, karar  yapısı

            Console.Write("***** C# EĞitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("--------------------------------");
            Console.Write("Sınıfınızda kaç Öğrenci var ?: ");
            int studentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------");


            //Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentNames=new string[studentCount];
            double[] studentExamAvg=new double[studentCount];

            for(int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i+1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;


                //Her öğrenci için 3 sınav notu girişi
                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j+1}. sınav notunu giriniz: ");
                    double value=double.Parse(Console.ReadLine());
                    totalExamResult += value;//notları topluyoruz.
                }

                studentExamAvg[i] = totalExamResult/3;
                Console.WriteLine();
            }
            //Sınav Ortalamaları
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("-------------------------------------------------");

                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması :{studentExamAvg[i]}");

                //Öğrencicin ortalaması ve geçip kalma durumları
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı.");
                }
                Console.WriteLine("-------------------------------------------------");
            }


            #endregion
            Console.Read();
        }
    }
}
