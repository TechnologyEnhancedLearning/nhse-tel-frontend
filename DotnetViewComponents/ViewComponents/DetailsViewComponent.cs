namespace DotnetViewComponents.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    /// <summary>
    /// A ViewComponent that displays details using a summary and content.
    /// </summary>
    public class DetailsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            string summary,
            string content
        )
        {
            var model = new DetailsViewModel(summary, content);

            return View(model);
        }
    }
}
