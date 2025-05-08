namespace DotnetViewComponents.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    /// <summary>
    /// A ViewComponent that renders pagination controls based on the current page and total pages.
    /// </summary>
    public class PaginationViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            int currentPage,
            int totalPage,
            string prevUrl,
            string nextUrl)
        {
            var model = new PaginationViewModel(currentPage, totalPage, prevUrl, nextUrl);

            return View(model);
        }
    }
}
