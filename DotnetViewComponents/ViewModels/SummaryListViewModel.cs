namespace DotnetViewComponents.ViewModels
{
    using System.Collections.Generic;
    public class SummaryListViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryListViewModel"/> class.
        /// </summary>
        /// <param name="summaryListItem">The collection of summary list items.</param>
        /// <param name="hasBorder">Indicates whether the summary list has a border.</param>
        public SummaryListViewModel(
            IEnumerable<SummaryListItemViewModel> summaryListItem,
            bool hasBorder)
        {
            SummaryListItem = summaryListItem;
            HasBorder = hasBorder;
        }

        /// <summary>
        /// Gets or sets the collection of summary list items.
        /// </summary>
        public IEnumerable<SummaryListItemViewModel> SummaryListItem { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the summary list has a border.
        /// </summary>
        public bool HasBorder { get; set; }
    }
}
