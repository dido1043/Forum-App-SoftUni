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
            if (model == null)
            {
                throw new ArgumentException("Error");
            }
            await _formService.AddPostAsync(model);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await _formService.GetById(id);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(PostViewModel model, int id)
        {
            if (ModelState.IsValid == false || model.Id != id)
            {
                return View(model);
            }
            await _formService.UpdatePostAsync(model);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {

            await _formService.DeletePostAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
