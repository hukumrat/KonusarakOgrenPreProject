using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace MvcWebUI.ViewComponents
{
    public class CommentViewComponent: ViewComponent
    {
        public ViewViewComponentResult Invoke()
        {
            return View();
        }
    }
}
