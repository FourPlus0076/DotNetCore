using AperioIndia.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AperioIndia.Controllers
{
    public class AdminController : Controller
    {
        private readonly IProductRepository _productRepository;
        private string _fileName = string.Empty;
        private readonly IWebHostEnvironment _environment;
        public AdminController(IProductRepository productRepository, IWebHostEnvironment environment)
        {
            _productRepository = productRepository;
            _environment= environment;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddProductCategory()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddProductCategory(ProductCategory model, IFormFile PImage)
        {
            string filePath = string.Empty;
            if (PImage != null && PImage.Length > 0)
            {
                string uploadsFolder = Path.Combine(_environment.WebRootPath, "img");
                string uniqueFileName = Guid.NewGuid().ToString() + "_" + PImage.FileName;
                filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    PImage.CopyTo(fileStream);
                }
            }
            model.PImage = filePath;
                if (model.ID == 0)
                {                    
                    model.ModifiedBy = "";
                    int i = await _productRepository.ProductCategorySave(model);
                    TempData["msg"] = "Save Successfully";
                }
                else
                {
                   
                }
                return RedirectToAction("AddProductCategory");   
        }
        public IActionResult ListProductCategory()
        {
           return View();
        }       
    }
}
