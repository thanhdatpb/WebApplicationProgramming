using HelloProject.Services;
using HelloProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HelloProject.Controllers
{
    public class ProductController : Controller
    {
        ProductService service;
        public ProductController()
        {
            service = new ProductService();
        }
        public IActionResult Index(String? keyWord)
        {
            ProductViewModel model = new ProductViewModel();
            model.KeyWord = keyWord;
            model.Products = service.GetProducts(keyWord);
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            //Xoa san pham
            var rs = ProductService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
