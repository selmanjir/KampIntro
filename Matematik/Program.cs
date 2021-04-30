using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            Toplama toplaIslemi = new Toplama();
            toplaIslemi.Topla(10,8);

            toplaIslemi.Topla(15,7);

            Cıkarma cıkarIslemi = new Cıkarma();

            cıkarIslemi.Cıkar(10, 8);
            cıkarIslemi.Cıkar(15, 7);


            Carpma carpmaIslemi = new Carpma();

            carpmaIslemi.Carp(10, 8);
            carpmaIslemi.Carp(15, 7);

            Bolme bolmeIslemi = new Bolme();

            bolmeIslemi.Bol(10, 8);
            bolmeIslemi.Bol(15, 7);
        }
    }
}
