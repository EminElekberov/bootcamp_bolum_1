using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm_projesi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int bakiye = 1000;
            Console.WriteLine("xogeldiniz. ");
            Console.WriteLine("etmek isdediyiniz islemi girin. ");
            while (bakiye > 0)
            {
                
                
                Console.WriteLine("1- bakiye goruntuleme ");
                Console.WriteLine("2- pul  cekme ");
                Console.WriteLine("3-pul yatirma ");
                Console.WriteLine("4-exit ");
                string secim = Console.ReadLine();
                if (secim == "1")
                {
                    Console.WriteLine("sizin bakiyeniz: " + bakiye + "azn");
                    Console.ReadLine();
                }
                else if (secim == "2")
                {
                    Console.WriteLine("cekmek isdediyiniz miqdari girin: ");
                    int cekil_bakiye = Convert.ToInt32(Console.ReadLine());
                    if (cekil_bakiye <= bakiye)
                    {
                        Console.WriteLine("qalan mebleg: " + (bakiye - cekil_bakiye));
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("sizin hesabinizda bu qeder pul yoxdur.");
                    }
                }
                else if (secim == "3")
                {
                    Console.WriteLine("yatirmaq isdediyiniz meblegi girin: ");
                    int yatirlicaq_meb = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("guncel bakiyeniz: " + (bakiye + yatirlicaq_meb));
                }
                else if (secim == "4")
                {
                    Console.WriteLine("siz cixis yaptiniz yine bekleriz :)");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("gecersiz islem girdiniz. lutfen yeniden deneyin");
                    Console.ReadLine();
                }
            }
            

            //switch ile yazaq indide
            /*
            int bakiye = 1000;
            Console.WriteLine("xogeldiniz");
            Console.WriteLine("etmek isdediyiniz islemi girin. ");
            Console.WriteLine("1- bakiye goruntuleme ");
            Console.WriteLine("2- pul  cekme ");
            Console.WriteLine("3-pul yatirma ");
            Console.WriteLine("4-exit ");
            string secim = Console.ReadLine();
            switch (secim)
            {
                case "1":
                    Console.WriteLine("bakiyeniz : "+bakiye);
                    Console.ReadLine();
                    break;

                case "2":
                    Console.WriteLine("cekmek isdediyiniz miqdari girin");
                    int cekil_tutar = Convert.ToInt32(Console.ReadLine());
                    if (cekil_tutar > bakiye)
                    {
                        Console.WriteLine("bu meblegde pulunuz yoxdur.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("qalan bakiyeniz: "+(bakiye-cekil_tutar));
                        Console.ReadLine();
                    }
                    break;
                case "3":
                    Console.WriteLine("yatirmaq isdediyiniz miqdari secin");
                    int yat_mebleg = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("yeni bakiyeniz: "+(bakiye+yat_mebleg));
                    Console.ReadLine();
                    break;
                case "4":
                    Console.WriteLine("hesabinizdan cixis yapilir xo gunler");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("lutfen duzgun kodu girin");
                    Console.ReadLine();
                    break;

            }
            */
        }
    }
}
