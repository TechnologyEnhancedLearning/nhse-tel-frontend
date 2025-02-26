namespace DotnetViewComponents.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    public class TagViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            string name,
            string style = TagStyle.INPROGRESS)
        {
            var model = new TagViewModel(name, style);

            return View(model);
        }
    }
}
