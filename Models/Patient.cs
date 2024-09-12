namespace pharmacy.Models
{
    public class Patient
    {
        public int PatientID { get; set; }
        public string PatientName { get; set; }
        public decimal? Height { get; set;}
        public decimal? Weight { get; set;}
        public string? address { get; set;}
        public DateTime? CreatedDate { get; set;}
        public int? PostID { get; set;}
        public ICollection<Post>? Post { get; set;}
        public ICollection<Order>? orders { get; set;}
    }
    
}
