namespace DotnetViewComponents.ViewComponents
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    /// <summary>
    /// A ViewComponent that renders a set of tabs based on the provided title and list of tabs.
    /// </summary>
    public class TabsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            string title,
            List<TabViewModel> tabsList)
        {
            var model = new TabsViewModel(title, tabsList);

            return View(model);
        }
    }
}
