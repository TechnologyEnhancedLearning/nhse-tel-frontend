namespace DotnetViewComponents.ViewModels
{
    using System.Collections.Generic;
    public class SummaryListViewModel
    {
        public SummaryListViewModel(
            IEnumerable<SummaryListItemViewModel> summaryListItem,
            bool hasBorder = true)
        {
            SummaryListItem = summaryListItem;
            HasBorder = hasBorder;
        }

        public IEnumerable<SummaryListItemViewModel> SummaryListItem { get; set; }

        public bool HasBorder { get; set; }
    }
}
