namespace MyPortfolio.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Author { get; set; } = "";
        public string Text { get; set; } = "";
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}