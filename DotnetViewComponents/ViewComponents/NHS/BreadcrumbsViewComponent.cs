using DotnetViewComponents.ViewModels.NHS;

namespace DotnetViewComponents.ViewComponents.NHS
{
    public class BreadcrumbsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(List<BreadcrumbsModel> breadcrumbs)
        {
            return View(breadcrumbs);
        }
    }
}
