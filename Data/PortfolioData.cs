using MyPortfolio.Models;
using System.Collections.Generic;

namespace MyPortfolio.Data
{
    public static class PortfolioData
    {
        public static List<Project> Projects = new()
        {
            new Project
            {
                Id = 1,
                Title = "Flip card Quiz",
                Description = "A reviewer site containing twenty questions, Made with MVC application format in visual studio",
                GitHubUrl = "https://github.com/KevinRoque1/IT_ELECTIVE_2_BSIT31E1_PREFINAL_EXAM_ROQUE_KEVIN_CLERCK.git",
                ThumbnailPath = "/images/1.png"
            },
            new Project
            {
                Id = 2,
                Title = "Spiderman Comic Store",
                Description = "A basic MVC application with the purpose of being a POS system",
                GitHubUrl = "https://github.com/KevinRoque1/IT_ELECTIVE_2_MIDTERM_H1_H2_H3_ROQUE_KEVIN_CLERCK.git",
                ThumbnailPath = "/images/2.png"
            },
            new Project
            {
                Id = 3,
                Title = "Attendee Monitoring",
                Description = "A basic MVC application with the purpose of being a Attendee Monitoring system without a database",
                GitHubUrl = "https://github.com/KevinRoque1/IT_ELECTIVE_2_MIDTERM_EXAM_8_ROQUE_KEVIN_CLERCK.git",
                ThumbnailPath = "/images/3.png"
            },
            new Project
            {
                Id = 4,
                Title = "Model Binding Demo",
                Description = "A basic ASP.NET Core MVC Model Binding with the purpose of having a working Log in",
                GitHubUrl = "https://github.com/KevinRoque1/IT_ELECTIVE_BSIT_BSIT31E1_ROQUE_KEVIN_CLERCK.git",
                ThumbnailPath = "/images/4.png"
            },
            new Project
            {
                Id = 5,
                Title = "Registrar Document Request System",
                Description = "A Registrar Document Request System Made in VB.NET and Visual Studio",
                GitHubUrl = "https://github.com/alliyahdevera/Registrar_Document_Request_System.git",
                ThumbnailPath = "/images/5.png"
            },
            new Project
            {
                Id = 6,
                Title = "Cookie Based Authentication",
                Description = "Authorization and Authentication using Cookie-based Authorization",
                GitHubUrl = "https://github.com/KevinRoque1/IT_ELECTIVE_2_MIDTERM_Q3_ROQUE_KEVIN_CLERCK.git",
                ThumbnailPath = "/images/6.png"
            }
        };

        public static int NextCommentId = 1;
    }
}