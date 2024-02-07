using ForumApp.Core.Contracts;
using ForumApp.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace ForumApp.Controllers
{
    public class PostController : Controller
    {
        private readonly IFormService _formService;
        public PostController(IFormService formService)
        {
            _formService = formService;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _formService.GetAllAsync();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new PostViewModel();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Add(PostViewModel model)
        { 
            await _formService.AddPostAsync(model);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit()
        {
            return View();
        }
        //todo create post method

        [HttpGet]
        public async Task<IActionResult> Delete()
        {
            return View();
        }
        //todo create post method
    }
}
