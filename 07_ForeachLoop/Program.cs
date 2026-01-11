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

            //string[] cities= { "İstanbul", "Ankara", "İzmir", "Bursa", "Antalya", "Adana" };
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers= { 5, 12, 9, 45, 78, 32, 14, 23, 67, 89 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 5, 12, 9, 45, 78, 32, 14, 23, 67, 89 };

            //foreach (int number in numbers)
            //{
            //    if(number%2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //int[] numbers= { 5, 12, 9, 45, 78, 32, 14, 23, 67, 89 };
            //int total = 0;
            //foreach (int number in numbers)
            //{
            //    total += number;

            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int> ()
            //{
            //     5, 12, 9, 45, 78, 32, 14, 23, 67, 89
            //};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word="Merhaba";
            //foreach (char letter in word)
            //{
            //    Console.WriteLine(letter);
            //}

            #endregion
            #region Örnek Sınav Sistemi
            //Console.Write("***** C# Eğitim Kampı Sınav Sistemi ***** ");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //// Sayısını kullanıcıdan alacağımız kısım
            //Console.WriteLine("-----------------------------------------");
            //Console.Write("Sınıfınızdaki Öğrenci Sayısını Giriniz: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("-----------------------------------------");

            ////Öğrenci isim ve not ortalamalarını saklayacak değer
            //string[] studentNames = new string[studentCount];

            //double[] studentExamAvg = new double[studentCount];


            //for(int i=0; i<studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. Öğrencinin Adını Giriniz: ");
            //    studentNames[i] = Console.ReadLine();
            //    Console.WriteLine("-----------------------------------------");

            //    double totalExamResult = 0;
                
            //    //Her öğrenci için 3 sınav girişi
            //    for (int j=0; j<3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");                   
            //        totalExamResult += double.Parse(Console.ReadLine());
            //    }
            //    studentExamAvg[i] = totalExamResult / 3;
            //    Console.WriteLine("-----------------------------------------");
            //}            

            ////Öğrencilerin Ortalaması ve geçip kalma durumları

            //for (int i=0; i<studentCount; i++)
            //{
            //    Console.WriteLine("-----------------------------------------");
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");

            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");

            //    }
            //    Console.WriteLine("-----------------------------------------");
            //}

            #endregion
            Console.Read();
        }
    }
}
