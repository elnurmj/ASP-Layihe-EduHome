using BackEndProject.Datas;
using BackEndProject.Models;
using BackEndProject.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProject.Controllers
{
    public class ContactController : Controller
    {
        private readonly ICommentService _commentService;
        public ContactController(ICommentService commentService, AppDbContext context)
        {
            _commentService = commentService;
        }
        public async Task<IActionResult> Index()
        {
            List<Comment> comments = await _commentService.GetComments();
            return View(comments);
        }

        [HttpPost]
        public async Task<IActionResult> CreateComment(string name, string comment)
        {
            await _commentService.PostComments(name, comment);
            return RedirectToAction(nameof(Index));
        }
    }
}
