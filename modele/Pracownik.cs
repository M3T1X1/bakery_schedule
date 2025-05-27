using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bakery_Schedule.modele
{
    public class Pracownik
    {
        [Key]
        public int ID_pracownika { get; set; }

        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Telefon { get; set; }
        public string RodzajUmowy { get; set; }
        public int LataDoswiadczenia { get; set; }

        // Klucz obcy do adresu (może być null)
        [ForeignKey(nameof(Adres))]
        public int? ID_adresu { get; set; }
        public Adres Adres { get; set; }

        // Klucz obcy do stanowiska (może być null)
        [ForeignKey(nameof(Stanowisko))]
        public int? ID_stanowiska { get; set; }
        public Stanowisko Stanowisko { get; set; }

        // Pomocnicze właściwości do wyświetlania
        [NotMapped]
        public string FullName => $"{Imie} {Nazwisko}";

        [NotMapped]
        public string DisplayName => $"{Imie} {Nazwisko} ({Telefon})";

        // Kolekcja zmian powiązanych z pracownikiem
        public ICollection<Zmiana> Zmiany { get; set; }
    }
}
