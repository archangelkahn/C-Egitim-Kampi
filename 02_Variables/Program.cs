using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.InputEncoding = Encoding.UTF8;
            #region Double Variable


            //double number;
            //number = 4.85;
            //Console.WriteLine(number);
            //Console.Read();

            //Console.WriteLine("****** Fiyat Listesi ******");
            //Console.WriteLine();

            //double applePrice,orangePrice,pearPrice,bananaPrice,tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //pearPrice= 8.75;
            //bananaPrice= 10.25;
            //tomatoPrice= 5.50;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + "₺");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + "₺");
            //Console.WriteLine("---- Armut Birim Fiyatı: " + pearPrice + "₺");
            //Console.WriteLine("---- Muz Birim Fiyatı: " + bananaPrice + "₺");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + "₺");
            //Console.WriteLine();
            //Console.WriteLine("****** Fiyat Listesi ******");

            //double appleKilogram , orangeKilogram , pearKilogram , bananaKilogram , tomatoKilogram;

            //appleKilogram = 1.245;
            //orangeKilogram = 2.650;
            //pearKilogram = 0.980;
            //bananaKilogram = 1.750;
            //tomatoKilogram = 3.200;

            //double appleTotalPrice = appleKilogram * applePrice;
            //double orangeTotalPrice = orangeKilogram * orangePrice;
            //double pearTotalPrice = pearKilogram * pearPrice;
            //double bananaTotalPrice = bananaKilogram * bananaPrice;
            //double tomatoTotalPrice = tomatoKilogram * tomatoPrice;
            //double totalPrice = appleTotalPrice + orangeTotalPrice + pearTotalPrice + bananaTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine("Ürün Hesabı");
            //Console.WriteLine("--------------------------------");

            //Console.WriteLine("---- Elma Toplam Fiyatı: " + appleTotalPrice + "₺");
            //Console.WriteLine("---- Portakal Toplam Fiyatı: " + orangeTotalPrice + "₺");
            //Console.WriteLine("---- Armut Toplam Fiyatı: " + pearTotalPrice + "₺");
            //Console.WriteLine("---- Muz Toplam Fiyatı: " + bananaTotalPrice + "₺");
            //Console.WriteLine("---- Domates Toplam Fiyatı: " + tomatoTotalPrice + "₺");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("Toplam Ücret: "+totalPrice + "₺");

            //Console.Read();







            #endregion

            #region Char Variables

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            //Console.Read();

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler
            //Console.Write("**** CSharp Havayolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yaş Bilgisi: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcu TC Kimlik NO: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("------------------------");
            //Console.WriteLine("Yolcu TC Kimlik NO: " +passengerIdentityNumber + " - " + "Yolcu Ad Soyadı: " + passengerName + " " + passengerSurname + " / " + passengerCity +" "+ passengerDistrict +" / "+ passengerAge);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvPrice * tvCount;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + "₺");






            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen 1.Sınav Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3)/3;

            //Console.WriteLine();
            //Console.WriteLine("Yıl Sonu Ortalaması: " + result);




            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);




            #endregion


            Console.Read();
        }
    }
}
