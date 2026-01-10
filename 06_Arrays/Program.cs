using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //string[] colors= new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";    
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            //---------------------------------------------------------------------------------

            //string[] cities = new string[5];
            //cities[0]= "Milano";
            //cities[1]= "Budapeşte";
            //cities[2]= "Prag";
            //cities[3]= "Amsterdam";
            //cities[4]= "Brüksel";

            //Console.WriteLine(cities[3]);
            //---------------------------------------------------------------------------------

            //int[] numbers = new int[10];
            //numbers[0] = 5;
            //numbers[1] = 52;
            //numbers[2] = 24;
            //numbers[3] = 86;
            //numbers[4] = 12;
            //numbers[5] = 6;
            //numbers[6] = 34;
            //numbers[7] = 64;
            //numbers[8] = 40;
            //numbers[9] = 78;

            //Console.WriteLine(numbers[6]);
            //---------------------------------------------------------------------------------

            //string[] cities= {"İstanbul","Ankara","İzmir","Bursa","Antalya" };
            //Console.WriteLine(cities[4]);

            #endregion
            #region Dizideki Tüm Elemanları Listeleme

            //string[]colors= { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for(int i=0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}
            //---------------------------------------------------------------------------------

            //int[] numbers= { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for(int i =0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //        Console.WriteLine(numbers[i]);
            //}
            //---------------------------------------------------------------------------------

            //char[] symbols = { 'A', 'B', 'C', '*', '/', '-' };
            //for(int i =0; i <symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}
            //---------------------------------------------------------------------------------

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            //int maxNumber = myArray[0];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber) 
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);
            //---------------------------------------------------------------------------------

            //string[] people = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            //Console.WriteLine(people.Length);

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);
            //for(int i=0; i<numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //-----------------------------------------------------------------------------------


            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}




            #endregion
            #region Dizi Metodlar
            //string[] people = { "Ali", "Buse", "Ayşe", "Merve", "Çınar", "Kaya" };
            //int index = Array.IndexOf(people, "Merve");

            //Console.WriteLine(index);

            //int[] number = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: " + number.Max() + "Dizinin En Küçük Elemanı: " + number.Min());

            #endregion
            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];
            //for ( int i= 0; i<cities.Length; i++)
            //{
            //    Console.WriteLine($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();

            //}
            //Console.WriteLine();
            //Console.WriteLine("--------------");
            //  for(int i =0; i<cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for(int i =0; i<numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };
            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine("------------");
            //for(int i=0; i<numbers.Length; i++)
            //{
            //    if (numbers[i]%2==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine("------------");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}



            #endregion
            Console.Read();
        }
    }
}
