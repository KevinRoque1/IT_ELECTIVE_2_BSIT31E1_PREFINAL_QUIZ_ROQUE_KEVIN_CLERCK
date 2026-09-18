using MyPortfolio.Models;

namespace MyPortfolio.Data
{
    public static class PortfolioData
    {
        public static List<Project> Projects = new()
        {
            new Project
            {
                Id = 1,
                Title = "Task Tracker API",
                Description = "A REST API for managing tasks, built with ASP.NET Core and EF Core.",
                GitHubUrl = "https://github.com/yourname/task-tracker-api",
                ThumbnailPath = "/images/task-tracker.png"
            },
            new Project
            {
                Id = 2,
                Title = "Weather Dashboard",
                Description = "A React + .NET dashboard pulling live weather data via a public API.",
                GitHubUrl = "https://github.com/yourname/weather-dashboard",
                ThumbnailPath = "/images/weather-dashboard.png"
            }
            // add  projects 
        };

        public static int NextCommentId = 1;
    }
}