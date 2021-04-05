using System;

namespace Unit1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int Dodaj(int liczba1, int liczba2)
        {
            return liczba1 + liczba2;
            /* Można to też rozbić tak:
             * var wynik = liczba1 + liczba2;
             * return wynik;
             */
        }

        public static int ZwróćLiczbęDniMiędzyDatami(DateTime data1, DateTime data2)
        {
            // wskazówka: niekiedy, gdy nie zgadzają się typy, które są do siebie podobne,
            //            można zrobić tzw. rzutowanie typu, np. gdy mamy zmienną x typu double
            //            a potrzebujemy int, to uzyskamy ją zapisem (int)x;
            throw new NotImplementedException();
        }

        public static object CzyRokJestPrzestępny(int rok)
        {
            throw new NotImplementedException();
        }

        public static object ZwróćNazwęDniaTygodnia(DateTime data)
        {
            throw new NotImplementedException();
        }

        public static object CzyTekstJestLiczbąCałkowitą(string tekst)
        {
            throw new NotImplementedException();
        }

        public static object ZmieńNaHasło(string słowo)
        {
            // podpowiedź: użyj metody Replace
            throw new NotImplementedException();
        }

        public static object UsuńZnakiZNumeruTelefonu(string numerZeZnakami)
        {
            throw new NotImplementedException();
        }

        public static object ZDużejLitery(string tekst)
        {
            // 1. string ma metody ToUpper i ToLower
            // 2. w stringu można dostać się do n-tego znaku przez [], np.
            //   żeby odczytać pierwszy znak ze zmiennej tekst, użyj tekst[0] (liczymy od zera)
            // 3. kawałki stringa można do siebe dodawać, w wyniku czego otrzymujemy sklejony tekst
            throw new NotImplementedException();
        }
    }
}
