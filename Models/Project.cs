using System.Xml.Linq;

namespace MyPortfolio.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string GitHubUrl { get; set; } = "";
        public string ThumbnailPath { get; set; } = "";
        public List<Comment> Comments { get; set; } = new();
    }
}