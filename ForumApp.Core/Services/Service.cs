using ForumApp.Core.Contracts;
using ForumApp.Core.Models;
using ForumApp.Infrastructure.Data;
using ForumApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ForumApp.Core.Services
{
    public class Service : IFormService
    {
        private readonly ForumAppDbContext _context;
        public Service(ForumAppDbContext context)
        {
            _context = context;  
        }
        public async Task AddPostAsync(PostViewModel model)
        {
            if (model == null)
            {
                throw new ArgumentException("Invalid post.");
            }
            var post = new Post() 
            {
                Title = model.Title,
                Content = model.Content,
            };
            await _context.Posts.AddAsync(post);
            _context.SaveChangesAsync();
        }

        public async Task DeletePostAsync(int id)
        {
            var entity = await _context.Posts.FindAsync(id);
            if (entity == null)
            {
                throw new ArgumentException("Invalid post.");
            }

            _context.Posts.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<PostViewModel>> GetAllAsync()
        {
            return await _context.Posts
                .AsNoTracking()
                .Select(p => new PostViewModel {Id =p.Id, Title = p.Title, Content = p.Content})
                .ToListAsync();
        }

        public async Task<PostViewModel> GetById(int id)
        {
            var entity = await _context.Posts.FindAsync(id);
            if (entity == null)
            {
                throw new ArgumentException("Invalid post.");
            }
            return new PostViewModel() {Id= entity.Id, Title = entity.Title, Content = entity.Content};
        }

        public async Task UpdatePostAsync(PostViewModel model)
        {
            var entity = await _context.Posts.FindAsync(model.Id);

            if (entity == null)
            {
                throw new ArgumentException("Invalid post.");
            }
            
            entity.Title = model.Title;
            entity.Content = model.Content;

            await _context.SaveChangesAsync();
        }
    }
}
