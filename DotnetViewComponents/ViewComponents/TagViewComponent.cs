namespace DotnetViewComponents.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    /// <summary>
    /// A ViewComponent that renders a tag based on the provided name and styling.
    /// </summary>
    public class TagViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            string name,
            string styling = TagStyle.INPROGRESS)
        {
            var model = new TagViewModel(name, styling);

            return View(model);
        }
    }
}
