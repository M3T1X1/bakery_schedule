using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Bakery_Schedule.modele
{
    public class Zmiana
    {
        [Key]
        public int ID_zmiany { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan PoczatekZmiany { get; set; }
        public TimeSpan KoniecZmiany { get; set; }

        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public int? PracownikID_pracownika { get; set; }
        public Pracownik Pracownik { get; set; }
    }
}
