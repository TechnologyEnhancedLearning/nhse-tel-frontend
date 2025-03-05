namespace DotnetViewComponents.ViewComponents
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    public class TaskListViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            IEnumerable<TaskListItemViewModel> listItems)
        {
            var model = new TaskListViewModel(listItems);

            return View(model);
        }
    }
}
