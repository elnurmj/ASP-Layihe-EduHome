using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProject.Services.Interfaces
{
    public interface ICommentService
    {
        Task GetComment(string name, string comment);
    }
}
