using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 tane yıldız oluşturma

            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}
            #endregion
            #region Yan Yana 10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("* ");
            //}
            #endregion
            #region her satırda 10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("* * * * * * * * * *");
            //}
            #endregion
            #region Alt alta 10 tane yıldız oluşturma            

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {

            //            Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}
            //---------------------------------------------------------------------------------

            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= 9; j++)
            //    {
            //        if (i + j <= 14 & i + j >= 6 & (i <= 7 | j <= 7) & i - j <= 4 & j - i <= 4)
            //            Console.Write("*");
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion
            #region Ters Dik Üçgen

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 5; j >= 1; j--)
            //    {
            //        if (i <= j)
            //            Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}

            //for(int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        if (i + j <= 6)
            //            Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}





            #endregion
            #region Piramit

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 9; j++)
            //    {
            //        if (i+j<=4+2*i & j-i>=6-2*i)
            //            Console.Write("*");
            //        else
            //        {
            //            Console.Write(" ");
            //        }

            //    }
            //    Console.WriteLine();
            //}

            #endregion
            #region Ters Piramit
            //int n = 5;
            //for (int  i = 1;  i <=n;  i++)
            //{
            //    for(int j=9; j>0; j--)
            //    {
            //        if (j >= 11-i | i-1>=j)
            //            Console.Write(" ");
            //        else
            //            Console.Write("*");
            //    }
            //    Console.WriteLine();


            //}

            //for (int i =1; i<=5; i++)
            //{
            //    for (int j=1; j<=i-1; j++)
            //    {                     Console.Write(" ");
            //    }
            //    for (int k=9; k>=2*i-1; k--)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            #endregion
            Console.Read();
        }
    }
}
