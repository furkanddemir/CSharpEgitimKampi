using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _08_Metots
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //Metot olduğunu anlamak için sonu () olmalı
            //Mor renkli küp metottur.
            //Geriye değer döndürmeyen metotlar --> Void 

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Furkan Demir");
            //    Console.WriteLine("Merve Çınar");
            //    Console.WriteLine("Ahmet Öztürk");
            //}
            //CustomerList();


            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();




            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);           }
            //WriteMethod("Furkan Demir");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}

            //CustomerCard("Furkan", "Demir");
            //CustomerCard("Murat", "Yücedağ");



            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1,int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 6, 9); 



            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}
            //CustomerName();

            //string studentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";
            //    return name + " " + surname;
            //}
            //Console.WriteLine(studentCard());

            #endregion


            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo="Ülke: "+ countryName+ " - Başkent: "+ capital+ " - Bayrak rengi: " + flagColor;
            //    return cardInfo;

            //}
            //string x, y, z;

            //Console.Write("Ülke adını giriniz: ");
            //x=Console.ReadLine();

            //Console.Write("Başkent adını giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak rengi giriniz: ");
            //z = Console.ReadLine();
            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı - Beyaz");
            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(10, 29));
            //Console.WriteLine(Sum(74, 72));
            //Console.WriteLine(Sum(81, 25));
            //Console.WriteLine(Sum(31, 28));
            //Console.WriteLine(Sum(31, 25));
            #endregion

            #region Örnek uygulama
            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " isimli öğrenci sınavı geçti. Ortalama: " + result;
                }
                else
                {
                    return student + " isimli öğrenci sınavdan kaldı. Ortalama: " + result;
                }q
            }

            Console.WriteLine(ExamResult("Furkan", 23, 33, 55));
            Console.WriteLine(ExamResult("Mustafa", 77, 35, 55));
            Console.ReadLine();
            #endregion
            Console.Read();

        }
    }
}
