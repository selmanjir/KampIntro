using System;

namespace Ternary_Operatörü
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example
            //Console.Write("[1-10] arasında sayı giriniz :");
            //int sayi = int.Parse(Console.ReadLine());
            //string cevap = "";
            //cevap += sayi == 7 ? "Tebrikler doğru bildiniz" : "Yanlış cevap";
            //Console.WriteLine(cevap);
           
            

            Console.WriteLine("Bir doğal sayi giriniz :  ");
            int sayi = int.Parse(Console.ReadLine());
            string cevap = "";
            cevap += sayi == 8 ? "Doğru sayıyı bildiniz ! " : " Yanlış cevap";
            Console.WriteLine(cevap);
        }
        
    }
}
