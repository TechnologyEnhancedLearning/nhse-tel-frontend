namespace DotnetViewComponents.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    public class ImageViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            string src,
            string alt,
            string caption,
            string? sizes = null,
            string? srcSet = null,
            string? additionalAttributes = null)
        {
            var model = new ImageViewModel(src, alt, caption, sizes, srcSet, additionalAttributes);

            return View(model);
        }
    }
}
