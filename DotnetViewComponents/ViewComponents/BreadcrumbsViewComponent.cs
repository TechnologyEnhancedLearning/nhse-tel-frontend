namespace DotnetViewComponents.ViewComponents
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    /// <summary>
    /// A ViewComponent that renders a breadcrumb navigation based on the provided links.
    /// </summary>
    public class BreadcrumbsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(List<(string Title, string spController, string aspAction, Dictionary<string, string>? aspRouteData)> links)
        {
            var model = new BreadcrumbsViewModel(links);

            return View(model);
        }
    }
}
