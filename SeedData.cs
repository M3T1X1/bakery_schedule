using System.Collections.Generic;
using Bakery_Schedule.modele;

namespace Bakery_Schedule.Data
{
    public static class SeedData
    {
        public static void Initialize(BakeryContext context)
        {
            context.Database.EnsureCreated();       

            if (context.Produkt.Any() || context.Adres.Any() || context.Stanowisko.Any() || context.Pracownik.Any())
                return; // Dane już istnieją

            var produkty = new List<Produkt>
            {
                new Produkt { Nazwa = "Chleb pszenny", ŚredniKosztProdukcji = 2.50m },
                new Produkt { Nazwa = "Bułka maślana", ŚredniKosztProdukcji = 0.80m },
                new Produkt { Nazwa = "Bagietka", ŚredniKosztProdukcji = 1.20m },
                new Produkt { Nazwa = "Chleb razowy", ŚredniKosztProdukcji = 2.70m },
                new Produkt { Nazwa = "Ciasto drożdżowe", ŚredniKosztProdukcji = 3.00m },
                new Produkt { Nazwa = "Rogal świętomarciński", ŚredniKosztProdukcji = 2.90m },
                new Produkt { Nazwa = "Chleb żytni", ŚredniKosztProdukcji = 2.40m },
                new Produkt { Nazwa = "Bułka kajzerka", ŚredniKosztProdukcji = 0.60m },
                new Produkt { Nazwa = "Ciastko czekoladowe", ŚredniKosztProdukcji = 1.50m },
                new Produkt { Nazwa = "Precel", ŚredniKosztProdukcji = 1.00m }
            };
            context.Produkt.AddRange(produkty);
            context.SaveChanges();

            var adresy = new List<Adres>
            {
                new Adres { Ulica = "Kwiatowa", NrMieszkania = "3", Klatka = "A", Miasto = "Poznań", NrDomu = "12" },
                new Adres { Ulica = "Lipowa", NrMieszkania = "5", Klatka = "B", Miasto = "Warszawa", NrDomu = "8" },
                new Adres { Ulica = "Długa", NrMieszkania = "2", Klatka = "", Miasto = "Gdańsk", NrDomu = "20" },
                new Adres { Ulica = "Szeroka", NrMieszkania = "1", Klatka = "C", Miasto = "Kraków", NrDomu = "4" },
                new Adres { Ulica = "Krótka", NrMieszkania = "7", Klatka = "", Miasto = "Łódź", NrDomu = "10" },
                new Adres { Ulica = "Zielona", NrMieszkania = "9", Klatka = "D", Miasto = "Wrocław", NrDomu = "6" },
                new Adres { Ulica = "Polna", NrMieszkania = "4", Klatka = "A", Miasto = "Katowice", NrDomu = "15" },
                new Adres { Ulica = "Leśna", NrMieszkania = "6", Klatka = "B", Miasto = "Szczecin", NrDomu = "18" },
                new Adres { Ulica = "Górna", NrMieszkania = "8", Klatka = "C", Miasto = "Lublin", NrDomu = "7" },
                new Adres { Ulica = "Dolna", NrMieszkania = "10", Klatka = "", Miasto = "Bydgoszcz", NrDomu = "3" }
            };
            context.Adres.AddRange(adresy);
            context.SaveChanges();

            var stanowiska = new List<Stanowisko>
            {
                new Stanowisko { NazwaStanowiska = "Piekarz", ZarobkiNaGodzine = 20.00m, Poziom = "Senior", Produkt = produkty[0] },
                new Stanowisko { NazwaStanowiska = "Cukiernik", ZarobkiNaGodzine = 22.00m, Poziom = "Mid", Produkt = produkty[4] },
                new Stanowisko { NazwaStanowiska = "Pomocnik", ZarobkiNaGodzine = 15.00m, Poziom = "Junior", Produkt = produkty[1] },
                new Stanowisko { NazwaStanowiska = "Magazynier", ZarobkiNaGodzine = 18.00m, Poziom = "Mid", Produkt = produkty[9] },
                new Stanowisko { NazwaStanowiska = "Kierowca", ZarobkiNaGodzine = 19.00m, Poziom = "Senior", Produkt = produkty[6] },
                new Stanowisko { NazwaStanowiska = "Sprzedawca", ZarobkiNaGodzine = 17.00m, Poziom = "Mid", Produkt = produkty[3] },
                new Stanowisko { NazwaStanowiska = "Dekorator", ZarobkiNaGodzine = 21.00m, Poziom = "Senior", Produkt = produkty[5] },
                new Stanowisko { NazwaStanowiska = "Kucharz", ZarobkiNaGodzine = 20.00m, Poziom = "Mid", Produkt = produkty[2] },
                new Stanowisko { NazwaStanowiska = "Operator maszyny", ZarobkiNaGodzine = 23.00m, Poziom = "Senior", Produkt = produkty[7] },
                new Stanowisko { NazwaStanowiska = "Zmywak", ZarobkiNaGodzine = 14.00m, Poziom = "Junior", Produkt = produkty[8] }
            };
            context.Stanowisko.AddRange(stanowiska);
            context.SaveChanges();

            var pracownicy = new List<Pracownik>
            {
                new Pracownik { Imie = "Jan", Nazwisko = "Kowalski", Telefon = "123456789", RodzajUmowy = "Umowa o pracę", LataDoswiadczenia = 5, Adres = adresy[0], Stanowisko = stanowiska[0] },
                new Pracownik { Imie = "Anna", Nazwisko = "Nowak", Telefon = "987654321", RodzajUmowy = "Umowa zlecenie", LataDoswiadczenia = 2, Adres = adresy[1], Stanowisko = stanowiska[1] },
                new Pracownik { Imie = "Piotr", Nazwisko = "Wiśniewski", Telefon = "555666777", RodzajUmowy = "Umowa o dzieło", LataDoswiadczenia = 3, Adres = adresy[2], Stanowisko = stanowiska[2] },
                new Pracownik { Imie = "Katarzyna", Nazwisko = "Wójcik", Telefon = "222333444", RodzajUmowy = "Umowa o pracę", LataDoswiadczenia = 4, Adres = adresy[3], Stanowisko = stanowiska[3] },
                new Pracownik { Imie = "Tomasz", Nazwisko = "Kamiński", Telefon = "888999000", RodzajUmowy = "Umowa zlecenie", LataDoswiadczenia = 1, Adres = adresy[4], Stanowisko = stanowiska[4] },
                new Pracownik { Imie = "Magdalena", Nazwisko = "Lewandowska", Telefon = "123123123", RodzajUmowy = "Umowa o dzieło", LataDoswiadczenia = 6, Adres = adresy[5], Stanowisko = stanowiska[5] },
                new Pracownik { Imie = "Marcin", Nazwisko = "Dąbrowski", Telefon = "321321321", RodzajUmowy = "Umowa o pracę", LataDoswiadczenia = 7, Adres = adresy[6], Stanowisko = stanowiska[6] },
                new Pracownik { Imie = "Ewa", Nazwisko = "Zielińska", Telefon = "456456456", RodzajUmowy = "Umowa zlecenie", LataDoswiadczenia = 2, Adres = adresy[7], Stanowisko = stanowiska[7] },
                new Pracownik { Imie = "Paweł", Nazwisko = "Szymański", Telefon = "789789789", RodzajUmowy = "Umowa o pracę", LataDoswiadczenia = 8, Adres = adresy[8], Stanowisko = stanowiska[8] },
                new Pracownik { Imie = "Joanna", Nazwisko = "Woźniak", Telefon = "111222333", RodzajUmowy = "Umowa o dzieło", LataDoswiadczenia = 5, Adres = adresy[9], Stanowisko = stanowiska[9] }
            };
            context.Pracownik.AddRange(pracownicy);
            context.SaveChanges();
        }
    }
}
