using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;
            //while (i <= 10)
            //{
            //Console.WriteLine("Merhaba Dünya");
            //i++;
            //}

            Product product1 = new Product();
            product1.Adi = "Tavuk";
            product1.Aciklamasi = "1 Kilo Tavuk Göğsü ";
            product1.Fiyati = 25;
            product1.StokSayisi = 7;

            Product product2 = new Product();
            product2.Adi = "Yulaf Ezmesi";
            product2.Aciklamasi = "Etli yulaf ezmesi 500 gr";
            product2.Fiyati = 11;
            product2.StokSayisi = 17;

            Product[] products = new Product[] { product1, product2 };

            int i = 0;
            while (i < products.Length)
            {
              Console.WriteLine(products[i].Adi + "  " + products[i].Aciklamasi + " " + products[i].Fiyati + " " + products[i].StokSayisi);
                i++;
            }

            Console.WriteLine("--------- While bitti ---------");

            
            for (int a = 0; a < products.Length; a++)
            {
                Console.WriteLine(products[a].Adi + " " + products[a].Aciklamasi + " " + products[a].Fiyati + " " + products[a].StokSayisi);
            }

            Console.WriteLine("-------- For bitti --------");

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi + " " + product.Aciklamasi + " " + product.Fiyati + " " + product.StokSayisi);
            }

            
        }
    }
 }
