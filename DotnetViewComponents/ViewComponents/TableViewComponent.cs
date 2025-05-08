namespace DotnetViewComponents.ViewComponents
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    /// <summary>
    /// A ViewComponent that renders a table based on the provided title and rows of data.
    /// </summary>
    public class TableViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            string title,
            List<List<TableColumnModel>> rows,
            bool isResponsive = false,
            bool hasNumericData = false)
        {
            var model = new TableViewModel(title, rows, isResponsive, hasNumericData);

            return View(model);
        }
    }
}
