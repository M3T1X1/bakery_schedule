using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery_Schedule.modele
{
    public class Produkt
    {
        [Key]
        public int ID_produktu { get; set; }
        public string Nazwa { get; set; }
        public decimal ŚredniKosztProdukcji { get; set; }

        public ICollection<Stanowisko> Stanowiska { get; set; }
    }

}
