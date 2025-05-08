namespace DotnetViewComponents.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    /// <summary>
    /// A ViewComponent that renders a card component.
    /// </summary>
    public class CardViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            string title,
            string? description = null,
            string? imageSrc = null,
            int headingLevel = 2,
            bool hasArrow = false,
            bool isSecondary = false,
            string? aspController = null,
            string? aspAction = null,
            Dictionary<string, string>? aspRouteData = null)
        {
            var model = new CardViewModel
            (
                title,
                description,
                imageSrc,
                headingLevel,
                hasArrow,
                isSecondary,
                aspController,
                aspAction,
                aspRouteData
            );
            return View(model);
        }
    }
}
