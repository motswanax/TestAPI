using System.Collections.Generic;

namespace TestAPI.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }

        public List<Bank> Banks { get; set; }
    }
}
