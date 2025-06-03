
namespace Bakery_Schedule
{
    public class Employee
    {
        public int Id { get; set; }                 
        public string FirstName { get; set; }      
        public string LastName { get; set; }        
        public string PhoneNumber { get; set; }    
        public string Position { get; set; }        
        public string ContractType { get; set; }   
        public int? YearsOfExperience { get; set; } 
        public string Department { get; set; }     
        public int? AddressId { get; set; }

        public string DisplayInfo
        {
            get
            {
                return $"{FirstName} {LastName} ({Position ?? "brak stanowiska"}) - Dział: {Department ?? "N/A"}";
            }
        }
    }
}