using ForumApp.Core.Contracts;
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
