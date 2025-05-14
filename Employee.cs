// W pliku Employee.cs lub w ramach namespace Bakery_Schedule
namespace Bakery_Schedule
{
    public class Employee
    {
        public int Id { get; set; }                 // Z Pracownicy.ID_pracownika
        public string FirstName { get; set; }       // Z Pracownicy.Imie
        public string LastName { get; set; }        // Z Pracownicy.Nazwisko
        public string PhoneNumber { get; set; }     // Z Pracownicy.telefon
        public string Position { get; set; }        // Z Stanowiska.nazwa_stanowiska
        public string ContractType { get; set; }    // Z Pracownicy.rodzaj_umowy
        public int? YearsOfExperience { get; set; } // Z Pracownicy.lata_doswiadczenia (nullable, jeśli może być puste)
        public string Department { get; set; }      // Np. z Produkty.Nazwa (przez Stanowiska)

        // Właściwość do wyświetlania w ComboBox
        // Dostosuj ten format według swoich potrzeb.
        public string DisplayInfo
        {
            get
            {
                // Przykład 1: Imię, Nazwisko, Stanowisko, Dział
                return $"{FirstName} {LastName} ({Position ?? "brak stanowiska"}) - Dział: {Department ?? "N/A"}";

                // Przykład 2: Bardziej szczegółowy
                // return $"{FirstName} {LastName} | Stanowisko: {Position ?? "N/A"} | Telefon: {PhoneNumber ?? "N/A"} | Umowa: {ContractType ?? "N/A"}";
            }
        }
    }
}