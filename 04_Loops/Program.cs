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
            //for(i=1; i <=5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen Ekrana Yazılmasını İstediğiniz Adedi Giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}







            #endregion

            #region For Döngüsü İle Karar Yapıları

            //for(int i = 1; i<=100; i++)
            //{
            //    if(i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            //int totalValue = 0;
            //for(int i =1; i<=10; i++)
            //{
            //   totalValue += i;
            //}

            //Console.WriteLine(totalValue);

            //int totalValue = 0;
            //for(int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine(totalValue);

            //int count = 0;
            //for(int i =1; i<=50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(count);

            //int bacteria = 1;
            //int i;
            //for (i=1; i<=24; i++)
            //{
            //    bacteria *= 2;
            //    Console.WriteLine(i + ".Saat Sonunda: " + bacteria);    
            //}







            #endregion

            #region While Döngüsü

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;
            //while (i<=10)
            //{
            //    if(i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 0;
            //int totalValue=0;
            //while (i<=10)
            //{
            //    totalValue+= i;
            //    i++;
            //}
            //Console.WriteLine(totalValue);






            #endregion

            #region Örnek Sınav Sorusu

            //klavyeden girilen üç basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.

            //int basamak1, basamak2, basamak3, sayi, toplam;
            //Console.Write("Lütfen Üç Basamaklı Bir Sayı Giriniz: ");    
            //sayi = int.Parse(Console.ReadLine());
            //basamak1 = sayi % 10;
            //basamak2 = ((sayi % 100) - basamak1)/10;
            //basamak3 = sayi / 100;
            //toplam = basamak1 + basamak2 + basamak3;
            //Console.WriteLine("Basamaklar Toplamı: " + toplam);



            #endregion

            Console.Read();

        }
    }
}
