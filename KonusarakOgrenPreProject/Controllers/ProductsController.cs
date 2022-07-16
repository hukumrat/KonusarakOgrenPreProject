using Business.Abstract;
using KonusarakOgrenPreProject.Areas.Admin.Models;
using KonusarakOgrenPreProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.ViewModels;
using System.Diagnostics;

namespace KonusarakOgrenPreProject.Controllers
{
    [Authorize(Roles = "sysadmin, admin, customer")]
    public class ProductsController : Controller
    {
        private IProductService _productService;
        private ICommentService _commentService;

        public ProductsController(IProductService productService, ICommentService commentService)
        {
            _productService = productService;
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Buy()
        {
            return RedirectToAction("Login", "Account");
        }

        [HttpPost]
        public IActionResult Buy(int id)
        {
            var product = _productService.GetById(id);
            product.Quantity--;
            _productService.ProductUpdate(product);
            return RedirectToAction("Login", "Account");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var product = _productService.GetById(id);
            _productService.ProductDelete(product);
            return RedirectToAction("Login", "Account");
        }

        [HttpGet]
        public IActionResult Update()
        {
            return RedirectToAction("Login", "Account");
        }

        [HttpPost]
        public IActionResult Update(ProductsEditViewModel model)
        {
            var products = _productService.ListAllWithIncludes();
            foreach (var product in products)
            {
                if (product.Name == model.Name)
                {
                    product.Quantity = model.Quantity;
                    product.Weight = model.Weight;
                    product.Color = model.Color;
                    product.Brand = model.Brand;
                    product.Description = model.Description;
                    _productService.ProductUpdate(product);
                }
            }
            return RedirectToAction("Login", "Account");
        }

        [HttpGet]
        public IActionResult Comment()
        {
            return RedirectToAction("Login", "Account");
        }

        [HttpPost]
        public IActionResult Comment(CommentViewModel model)
        {
            var products = _productService.ListAllWithIncludes();
            foreach (var product in products)
            {
                if (product.Name == model.Name)
                {
                    Comment comment = new Comment()
                    {
                        Description = model.Description,
                        ProductId = product.Id
                    };
                    _commentService.CommentAdd(comment);
                }
            }
            return RedirectToAction("Login", "Account");
        }
    }
}