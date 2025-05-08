namespace DotnetViewComponents.ViewComponents
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    /// <summary>
    /// A ViewComponent that renders a "Do" or "Don't" list based on the provided rules.
    /// </summary>
    public class DoDontListViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            bool isDo,
            List<string> ruleSet)
        {

            var model = new DoDontListViewModel(isDo, ruleSet);

            return View(model);
        }
    }
}
