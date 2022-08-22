using System.Collections.Generic;

namespace TestAPI.Models
{
    public class Bank
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        public virtual List<Branch> Branches { get; set; }
    }
}
