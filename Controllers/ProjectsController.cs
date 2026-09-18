using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Data;
using MyPortfolio.Models;

namespace MyPortfolio.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Details(int id)
        {
            var project = PortfolioData.Projects.FirstOrDefault(p => p.Id == id);
            if (project == null) return NotFound();
            return View(project);
        }

        [HttpPost]
        [Authorize] // only logged-in users can comment
        [ValidateAntiForgeryToken]
        public IActionResult AddComment(int projectId, string author, string text)
        {
            var project = PortfolioData.Projects.FirstOrDefault(p => p.Id == projectId);
            if (project == null) return NotFound();

            if (!string.IsNullOrWhiteSpace(text))
            {
                project.Comments.Add(new Comment
                {
                    Id = PortfolioData.NextCommentId++,
                    ProjectId = projectId,
                    Author = string.IsNullOrWhiteSpace(author) ? "Anonymous" : author,
                    Text = text
                });
            }

            return RedirectToAction("Details", new { id = projectId });
        }
    }
}