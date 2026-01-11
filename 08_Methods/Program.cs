using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar
            //Geriye değer döndürmeyen metotlar (void)
            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();


            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z= x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();





            #endregion
            #region Geriye Değer Döndürmeyen Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet Yıldırım");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName); 
            //}

            //CustomerCard("Methmet", "Yıldız");
            //CustomerCard("Ayşe", "Öztürk");






            #endregion
            #region Geriye Değer Döndürmeyen İnt Parametreli Metotlar

            //void Sum(int number1, int nubmer2, int number3)
            //{
            //    int result= number1 + nubmer2 + number3;
            //    Console.WriteLine("Toplam: " + result);
            //}

            //Sum(3, 5, 8);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surName= "Yıldız";
            //    return name + " " + surName;

            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capitalName,string flagColor)
            //{
            //    string cardInfo= "Ülke: " + countryName + " - Başkent: " + capitalName + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;

            //}
            //string x, y, z;
            //Console.WriteLine("Ülke Adını Giriniz:");
            //x= Console.ReadLine();

            //Console.WriteLine("Başkent Adını Giriniz:");
            //y = Console.ReadLine();

            //Console.WriteLine("Bayrak Rengini Giriniz:");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y,z));

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));







            #endregion

            #region Geri Değer Döndüren İnt Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(1, 2));
            //Console.WriteLine(Sum(15, 232));
            //Console.WriteLine(Sum(11, 27));
            //Console.WriteLine(Sum(123, 21));

            #endregion

            #region Örnek Uygulama
            //string ExamResults(string studentName, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3)/3;
            //        if(result>=50)
            //    {
            //        return studentName + " İsimli Öğrenci Sınavı Geçti" + " Not Ortalaması: "+ result;

            //    }
            //        else
            //    {
            //        return studentName + " İsimli Öğrenci Başarısız Oldu" + " Not Ortalaması: " + result;
            //    }
            //}


            //Console.WriteLine(ExamResults("Ali", 25, 41, 80));
            //Console.WriteLine(ExamResults("Ayşe", 60, 70, 80));
            #endregion


            Console.Read();
        }
    }
}
