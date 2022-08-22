namespace TestAPI.Models
{
    public class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BankId { get; set; }
        public virtual Bank Bank { get; set; }
    }
}
