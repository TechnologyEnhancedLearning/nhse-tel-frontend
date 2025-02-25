namespace DotnetViewComponents.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    public class SummaryListViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(IEnumerable<SummaryListItemViewModel> summaryListItem,
            bool hasBorder = true)
        {
            var model = new SummaryListViewModel
            (
                summaryListItem,
                hasBorder
            );

            return View(model);
        }
    }
}
