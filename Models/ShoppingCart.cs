using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace pharmacy.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        [ValidateNever]
        public Product Products { get; set; }
        [ValidateNever]
        public int ProductID { get; set; }
        //[ValidateNever]
        ////public ApplicationUser ApplicationUser { get; set; }
        //[ValidateNever]
        //public string ApplicationUserId  { get; set; }
        public int Count { get; set; }
    }
}
