using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Unit1
{
    public class Tests
    {
        [Fact]
        public void Dodaj_ZParametrami2I2_Zwraca4()
        {
            // Arrange - przygotowanie do testu
            var l1 = 2;
            var l2 = 2;

            // Act - uruchomienie testowanego kodu
            var wynik = Program.Dodaj(l1, l2);

            // Assert - sprawdzenie czy wynik się zgadza
            Assert.Equal(4, wynik);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(3, 5, 8)]
        public void Dodaj_ZwracaSumę(int liczba1, int liczba2, int spodziewanyWynik)
        {
            // Act
            var wynik = Program.Dodaj(liczba1, liczba2);

            // Assert
            Assert.Equal(spodziewanyWynik, wynik);
        }

        [Theory]
        [InlineData(1, 1, 2021, 31, 1, 2021, 31)]
        [InlineData(1, 2, 2021, 1, 3, 2021, 29)]
        [InlineData(1, 1, 2021, 31, 12, 2021, 365)]
        [InlineData(1, 1, 2020, 31, 12, 2020, 366)]
        public void ZwróćLiczbęDniMiędzyDatami_ZwracaLiczbęDni(
            int dzień1, int miesiąc1, int rok1,
            int dzień2, int miesiąc2, int rok2,
            int spodziewanaLiczbaDni)
        {
            // Arrange
            var data1 = new DateTime(rok1, miesiąc1, dzień1);
            var data2 = new DateTime(rok2, miesiąc2, dzień2);

            // Act
            var liczbaDni = Program.ZwróćLiczbęDniMiędzyDatami(data1, data2);

            // Assert
            Assert.Equal(spodziewanaLiczbaDni, liczbaDni);
        }

        [Theory]
        [InlineData(2021, false)]
        [InlineData(2020, true)]
        [InlineData(2000, false)]
        public void CzyRokJestPrzestępny_ZwracaCzyRokJestPrzestępny(int rok, bool spodziewanyWynik)
        {
            // Act
            var wynik = Program.CzyRokJestPrzestępny(rok);

            // Assert
            Assert.Equal(spodziewanyWynik, wynik);
        }

        [Theory]
        [InlineData(5, 4, 2021, "poniedziałek")]
        [InlineData(1, 1, 2021, "piątek")]
        [InlineData(25, 12, 2020, "piątek")]
        public void ZwróćNazwęDniaTygodnia_ZwracaDzieńTygodnia(int dzień, int miesiąc, int rok, string spodziewanyWynik)
        {
            var data = new DateTime(rok, miesiąc, dzień);

            var dzieńTygodnia = Program.ZwróćNazwęDniaTygodnia(data);

            Assert.Equal(spodziewanyWynik, dzieńTygodnia);
        }

        [Theory]
        [InlineData("dupa", false)]
        [InlineData("pięć", false)]
        [InlineData(" 5", false)]
        [InlineData("5", true)]
        [InlineData("1234", true)]
        public void CzyTekstJestLiczbąCałkowitą_ZLiczbąWyrażonąCyframi_ZwracaTrue(string tekst, bool spodziewanyWynik)
        {
            var wynik = Program.CzyTekstJestLiczbąCałkowitą(tekst);

            Assert.Equal(spodziewanyWynik, wynik);
        }

        [Theory]
        [InlineData("Michał", "M*ch@ł")]
        [InlineData("Abra<adabra", "Abr@<@d@br@")]
        [InlineData("Szczypiorek", "Szczyp*0re<")]
        public void ZmieńNaHasło_PodmieniaPewneZnakiWTekście(string słowo, string hasło)
        {
            var wynik = Program.ZmieńNaHasło(słowo);

            Assert.Equal(hasło, wynik);
        }

        [Theory]
        [InlineData("655-655-655", "655655655")]
        [InlineData("800 123 234", "800123234")]
        [InlineData("(12) 34 55 679", "123455679")]
        public void FormatujNumerTelefonu_ZwracaSameCyfry(string numerZeZnakami, string spodziewanyNumer)
        {
            var numer = Program.UsuńZnakiZNumeruTelefonu(numerZeZnakami);

            Assert.Equal(spodziewanyNumer, numer);
        }

        [Theory]
        [InlineData("+48 123 234 345", "0048123234345")]
        public void FormatujNumerTelefonu_ZmieniaPlusNa00(string numerZPlusem, string spodziewanyNumer)
        {
            var numer = Program.UsuńZnakiZNumeruTelefonu(numerZPlusem);

            Assert.Equal(spodziewanyNumer, numer);
        }

        [Theory]
        [InlineData("KUBA", "Kuba")]
        [InlineData("michał", "Michał")]
        [InlineData("luCjan", "Lucjan")]
        public void ZDużejLitery_ZwracaTekstZPierwsząDużąLiterąIResztąMałymi(string tekst, string spodziewanyWynik)
        {
            var imię = Program.ZDużejLitery(tekst);

            Assert.Equal(spodziewanyWynik, imię);
        }
    }
}
