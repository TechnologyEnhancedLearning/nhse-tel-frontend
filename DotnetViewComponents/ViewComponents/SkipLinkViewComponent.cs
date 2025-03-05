namespace DotnetViewComponents.ViewComponents
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    public class SkipLinkViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            string maincContentID,
            string text = "Skip to main content")
        {
            var model = new SkipLinkViewModel(maincContentID, text);

            return View(model);
        }
    }
}
