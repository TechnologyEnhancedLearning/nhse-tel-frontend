namespace DotnetViewComponents.ViewComponents
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    public class DoDontListViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            bool isDo,
            string[] ruleSet)
        {

            var model = new DoDontListViewModel(isDo, ruleSet);

            return View(model);
        }
    }
}
