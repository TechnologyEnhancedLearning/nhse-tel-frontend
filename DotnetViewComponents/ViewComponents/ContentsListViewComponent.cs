namespace DotnetViewComponents.ViewComponents
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    public class ContentsListViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            string name,
            IEnumerable<ContentsListItemViewModel> listItems)
        {
            var model = new ContentsListViewModel(name, listItems);

            return View(model);
        }
    }
}
