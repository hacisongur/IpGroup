using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProgrammersBlog.Mvc.Areas.Admin.Models;
using ProgrammersBlog.Services.Abstract;
using ProgrammersBlog.Shared.Utilities.Results.ComplexTypes;

namespace ProgrammersBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Editor")]
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;

        public HomeController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            // Bina bazında kategori sayıları
            var anahizmetCount = (await _categoryService.GetCategoryCountByBinaAsync("Ana Hizmet Binası")).Data;
            var ekBinaCount = (await _categoryService.GetCategoryCountByBinaAsync("Ek Hizmet Binası")).Data;
            var makinaIkmalCount = (await _categoryService.GetCategoryCountByBinaAsync("Makine İkmal")).Data;
            var zabitaCount = (await _categoryService.GetCategoryCountByBinaAsync("Zabıta Müdürlüğü")).Data;

            // View'e sadece bina bazında kategori sayıları gönderiliyor
            return View(new DashboardViewModel
            {
                AnahizmetCount = anahizmetCount,
                EkBinaCount = ekBinaCount,
                MakinaIkmalCount = makinaIkmalCount,
                ZabitaCount = zabitaCount
            });
        }
    }
}
