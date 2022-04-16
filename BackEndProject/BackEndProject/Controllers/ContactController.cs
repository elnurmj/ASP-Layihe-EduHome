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
        public ContactController(ICommentService commentService)
        {
            _commentService = commentService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateComment(string name, string comment)
        {
            await _commentService.GetComment(name, comment);
            return RedirectToAction(nameof(Index));
        } 
    }
}
