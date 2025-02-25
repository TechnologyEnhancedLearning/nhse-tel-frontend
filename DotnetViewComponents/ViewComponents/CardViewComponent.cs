namespace DotnetViewComponents.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    public class CardViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            string title,
            string? description = null,
            string? imageSrc = null,
            int headingLevel = 2,
            bool hasArrow = false,
            bool isSecondary = false,
            bool isClickable = true)
        {
            var model = new CardViewModel
            (
                title,
                description,
                imageSrc,
                headingLevel,
                hasArrow,
                isSecondary,
                isClickable
            );
            return View(model);
        }
    }
}
