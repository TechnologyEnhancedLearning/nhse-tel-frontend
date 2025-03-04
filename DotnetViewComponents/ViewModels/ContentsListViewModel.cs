namespace DotnetViewComponents.ViewModels
{
    public class ContentsListViewModel
    {
        public ContentsListViewModel(
            string name,
            IEnumerable<ContentsListItemViewModel> listItems)
        {
            Name = name;
            ListItems = listItems;
        }

        public string Name { get; set; }

        public IEnumerable<ContentsListItemViewModel> ListItems { get; set; }
    }

}
