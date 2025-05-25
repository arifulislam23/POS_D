using System.ComponentModel.DataAnnotations;

namespace POS.DataModel
{
    public class Products
    {
        [Key]
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public int ProductQuantity { get; set; }      
        public int ProductPrice { get; set; }
        public string? ProductDetails { get; set; }
    }
}
