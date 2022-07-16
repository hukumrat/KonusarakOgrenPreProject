using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace MvcWebUI.ViewComponents
{
    public class ProductsViewComponent:ViewComponent
    {
        private readonly IProductService _productsService;
        public ProductsViewComponent(IProductService productsService)
        {
            _productsService = productsService;
        }

        public ViewViewComponentResult Invoke()
        {
            var products = _productsService.ListAllWithIncludes();
            return View(products);
        }
    }
}
