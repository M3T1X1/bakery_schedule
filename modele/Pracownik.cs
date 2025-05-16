using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


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

        public int? ID_adresu { get; set; }
        public Adres Adres { get; set; }

        public int? ID_stanowiska { get; set; }
        public Stanowisko Stanowisko { get; set; }

        public string FullName => $"{Imie} {Nazwisko}";
        public string DisplayName => $"{Imie} {Nazwisko} ({Telefon})";


        public ICollection<Zmiana> Zmiany { get; set; }
    }
}
