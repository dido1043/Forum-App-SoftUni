using ForumApp.Core.Contracts;
using ForumApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Core.Services
{
    public class Service : IFormService
    {
        public Task AddPostAsync(PostViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeletePostAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PostViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PostViewModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePostAsync(PostViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
