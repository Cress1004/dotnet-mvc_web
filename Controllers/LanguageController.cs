using System.Threading.Tasks;
using dotnet_mvc_web.Models;
using dotnet_mvc_web.Repository;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_mvc_web.Controllers
{
    public class LanguageController : Controller
    {
        private readonly LanguageRepository _languageRepository = null;
        public LanguageController(LanguageRepository languageRepository)
        {
            _languageRepository = languageRepository;
        }
        public async Task<ViewResult> GetLanguages()
        {
            var data = await _languageRepository.GetLanguages();
            return View(data);
        }
        public ViewResult AddNewLanguage(bool isSuccess = false, int languageId = 0)
        {
            ViewBag.IsSuccess = isSuccess;
            ViewBag.LanguageId = languageId;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddNewLanguage(LanguageModel language) 
        {
            if (ModelState.IsValid)
            {
                int id = await _languageRepository.AddNewLanguage(language);
                if (id > 0)
                {
                    return RedirectToAction(nameof(AddNewLanguage), new {isSuccess = true, languageId = id });
                }
            }
            return View();
        }
    }
}