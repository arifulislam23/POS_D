using System.ComponentModel.DataAnnotations;

namespace POS.DataModel
{
    public class Customers
    {
        [Key]
        public int CustomerID { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerAddress { get; set; }
        public int CustomerPhone { get; set; }
        public string? CustomerEmail { get; set; }
        public DateTime BirthDate { get; set; }
        public string? CustomerExtraDetails { get; set; }
        
        
    }
}
