using ForumApp.Core.Contracts;
using ForumApp.Core.Models;
using ForumApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Core.Services
{
    public class Service : IFormService
    {
        private readonly ForumAppDbContext _context;
        public Service(ForumAppDbContext context)
        {
            _context = context;  
        }
        public Task AddPostAsync(PostViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeletePostAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PostViewModel>> GetAllAsync()
        {
            return await _context.Posts
                .AsNoTracking()
                .Select(p => new PostViewModel {Title = p.Title, Content = p.Content})
                .ToListAsync();
        }

        public async Task<PostViewModel> GetById(int id)
        {
            var entity = await _context.Posts.FindAsync(id);
            if (entity == null)
            {
                throw new ArgumentException("Error!");
            }
            return new PostViewModel() { Title = entity.Title, Content = entity.Content};
        }

        public Task UpdatePostAsync(PostViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
