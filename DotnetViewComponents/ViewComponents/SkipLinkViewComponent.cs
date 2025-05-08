namespace DotnetViewComponents.ViewComponents
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    /// <summary>
    /// A ViewComponent that renders a skip link to allow users to jump to the main content of a page.
    /// </summary>
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
