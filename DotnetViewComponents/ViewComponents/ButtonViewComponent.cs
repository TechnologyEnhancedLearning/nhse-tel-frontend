namespace DotnetViewComponents.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    /// <summary>
    /// A ViewComponent that renders a button.
    /// </summary>
    public class ButtonViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            string text,
            string style,
            string styling = ButtonStyle.PRIMARY,
            string? aspController = null,
            string? aspAction = null,
            Dictionary<string, string>? aspRouteData = null,
            bool preventDoubleClick = false)
        {
            var model = new ButtonViewModel(text, aspController, aspAction, aspRouteData, styling, style, preventDoubleClick);

            return View(model);
        }
    }
}
