namespace DotnetViewComponents.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

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
