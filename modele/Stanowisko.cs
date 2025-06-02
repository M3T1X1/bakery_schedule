using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace Bakery_Schedule.modele
{
    public class Stanowisko
    {
        [Key]
        public int ID_stanowiska { get; set; }
        public string NazwaStanowiska { get; set; }
        public decimal ZarobkiNaGodzine { get; set; }
        public string Poziom { get; set; }

        [ForeignKey("Produkt")]
        public int? ID_produktu { get; set; }
        public Produkt Produkt { get; set; }

        public ICollection<Pracownik> Pracownicy { get; set; }
    }
}
