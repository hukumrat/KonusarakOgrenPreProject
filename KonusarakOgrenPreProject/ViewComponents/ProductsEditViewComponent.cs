using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MvcWebUI.ViewModels;

namespace MvcWebUI.ViewComponents
{
    public class ProductsEditViewComponent: ViewComponent
    {
        private readonly IProductService _productsService;
        public ProductsEditViewComponent(IProductService productsService)
        {
            _productsService = productsService;
        }


        public ViewViewComponentResult Invoke()
        {

            return View();
        }
    }
}
