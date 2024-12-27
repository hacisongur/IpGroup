using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ProgrammersBlog.Services.Abstract;
using ProgrammersBlog.Shared.Utilities.Results.ComplexTypes;
using System.Linq;
using ProgrammersBlog.Entities.Dtos;
using System.Collections.Generic;
using ProgrammersBlog.Entities.Concrete;

namespace ProgrammersBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HizmetBinasiController : Controller
    {
        private readonly ICategoryService _categoryService;

        public HizmetBinasiController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _categoryService.GetAllByNonDeletedAsync();
            if (result.ResultStatus == ResultStatus.Success)
            {
                var filteredCategories = result.Data.Categories
                    .Where(c => c.Bina == "Ana Hizmet Binası").ToList();

                return View(new CategoryListDto
                {
                    Categories = filteredCategories,
                    ResultStatus = result.ResultStatus
                });
            }
            return View(new CategoryListDto
            {
                Categories = new List<Category>(),
                ResultStatus = ResultStatus.Error
            });
        }

    }
}
