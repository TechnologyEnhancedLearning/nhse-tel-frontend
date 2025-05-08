namespace DotnetViewComponents.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    /// <summary>
    /// A ViewComponent that renders inset text based on the provided HTML content.
    /// </summary>
    public class InsetTextViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string contentHtml)
        {
            var model = new InsetTextViewModel(contentHtml);
            return View(model);
        }
    }
}
