using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesapmakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
            Console.WriteLine("Toplama için 1 e bas ");
            Console.WriteLine("Çıkarma için 2 ye bas");
            Console.WriteLine("Çarpma için 3 e bas");
            Console.WriteLine("Bölme için 4 e bas");

            decimal action = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("1.sayıyı giriniz");
            decimal sayi1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("2.sayıyı giriniz");
            decimal sayi2 = Convert.ToDecimal(Console.ReadLine());
            decimal result = 0;

            switch (action)
            {
                case 1:
                    {
                        result = Toplama(sayi1, sayi2);
                        break;
                    }
                case 2:
                    {
                        result = Çıkarma(sayi1, sayi2);
                        break;
                    }
                case 3:
                    {
                        result = Çarpma(sayi1, sayi2);
                        break;
                    }
                case 4:
                    {
                        result = Bölme(sayi1, sayi2);
                        break;
                    }
                default:
                    Console.WriteLine("Yanlış!Tekrar Deneyiniz");
                    break;
            }
            Console.WriteLine("Sonuç {0}", result);
            Console.ReadKey();
        }

        public static decimal Toplama(decimal sayi1, decimal sayi2)
        {
            decimal result = sayi1 + sayi2;
            return result;
        }

        public static decimal Çıkarma(decimal sayi1, decimal sayi2)
        {
            decimal result = sayi1 - sayi2;
            return result;
        }

        public static decimal Çarpma(decimal sayi1, decimal sayi2)
        {
            decimal result = sayi1 * sayi2;
            return result;
        }

        public static decimal Bölme(decimal sayi1, decimal sayi2)
        {
            decimal result = sayi1 / sayi2;
            return result;
        }
    }
}
