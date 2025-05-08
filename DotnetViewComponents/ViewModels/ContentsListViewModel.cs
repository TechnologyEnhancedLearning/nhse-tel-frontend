namespace DotnetViewComponents.ViewModels
{
    public class ContentsListViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsListViewModel"/> class.
        /// </summary>
        /// <param name="name">The title of the contents list.</param>
        /// <param name="listItems">The set of items in the contents-list.</param>
        public ContentsListViewModel(
            string name,
            IEnumerable<ContentsListItemViewModel> listItems)
        {
            Name = name;
            ListItems = listItems;
        }

        /// <summary>
        /// Gets or sets the title of the contents-list.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the set of items in the contents-list.
        /// </summary>
        public IEnumerable<ContentsListItemViewModel> ListItems { get; set; }
    }

}
