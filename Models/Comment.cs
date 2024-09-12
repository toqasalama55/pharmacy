namespace pharmacy.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string? CommentContent { get; set; }
        public int? PostID { get; set; }
        public Post? Posts { get; set; }
        public DateTime? CommentDate   { get; set; }
        public int? DoctorID { get; set; }
        public Doctor? Doctors { get; set; }
    }
}
