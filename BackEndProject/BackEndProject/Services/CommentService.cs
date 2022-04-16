using BackEndProject.Datas;
using BackEndProject.Models;
using BackEndProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProject.Services
{
    public class CommentService:ICommentService
    {
        private readonly AppDbContext _context;
        public CommentService(AppDbContext context)
        {
            _context = context;
        }

        public async Task GetComment(string name,string comment)
        {
            Comment newComment = new Comment
            {
                Name = name,
                CommentSection = comment,
            };

            await _context.Comments.AddAsync(newComment);
            await _context.SaveChangesAsync();
        }
    }
}
