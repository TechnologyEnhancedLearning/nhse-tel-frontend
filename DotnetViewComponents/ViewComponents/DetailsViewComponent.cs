namespace DotnetViewComponents.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

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
