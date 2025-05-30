using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Bakery_Schedule.modele
{
    public class Adres
    {
        [Key]
        public int ID_adresu { get; set; }
        public string Ulica { get; set; }
        public string NrMieszkania { get; set; }
        public string Klatka { get; set; }
        public string Miasto { get; set; }
        public string NrDomu { get; set; }

        public ICollection<Pracownik> Pracownicy { get; set; }
        public string PelnyAdres => $"{Ulica} {Miasto}";
    }
}
