using ForumApp.Core.Models;

namespace ForumApp.Core.Contracts
{
    public interface IFormService 
    {
        Task<IEnumerable<PostViewModel>> GetAllAsync();
        Task<PostViewModel> GetById(int id);
        Task AddPostAsync(PostViewModel model);

        Task UpdatePostAsync(PostViewModel model);

        Task DeletePostAsync(int id);
    }
}
