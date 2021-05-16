using System;
using System.Collections.Generic;

namespace Code_Pratice
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> Ogrenci = new Dictionary<int, string>();
            Ogrenci.Add(101, "Selman Jir CAN");
            Ogrenci.Add(102, "Ardıl ELKAAN");
            Ogrenci.Add(103, "Ezgi KERİMOĞLU");
            Ogrenci.Add(104, "Zilan PEKTAŞ");
            Ogrenci.Add(105, "Recep DEMİRÖREN");
            Ogrenci.Add(106, "Anıl ENGİN");

            Console.WriteLine("Öğrenci numarasını girizin : ");
            int No = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(Ogrenci[No]);
            }
            catch (Exception)
            {
                Console.WriteLine("Böyle bir öğrenci bulunmamaktadır.");

            }
            //Methods
            bool numaraSorgulama = Ogrenci.ContainsKey(No);
            if (numaraSorgulama == true)
            {
                Console.WriteLine("Böyle bir öğrenci var.");
            }
            else
            {
                Console.WriteLine("Böyle bir öğrenci yok");
            }
            /////////////////////////////////////////
            Console.WriteLine("Öğrencinin tam adını giriniz : ");
            string isim =(Console.ReadLine());

            bool isimSorgulama = Ogrenci.ContainsValue(isim);
            if (isimSorgulama == true)
            {
                Console.WriteLine("Böyle bir öğrenci var.");
            }
            else
            {
                Console.WriteLine("Böyle bir öğrenci yok");
            }
            /////////////////////////////////////////
            int ogrenciSayisi = Ogrenci.Count;
            Console.WriteLine("Öğrenci sayısı : " + ogrenciSayisi);
        }
    }
}
