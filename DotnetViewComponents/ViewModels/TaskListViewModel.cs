namespace DotnetViewComponents.ViewModels
{
    public class TaskListViewModel
    {
        public TaskListViewModel(
            IEnumerable<TaskListItemViewModel> listItems)
        {
            ListItems = listItems;
        }

        public IEnumerable<TaskListItemViewModel> ListItems { get; set; }
    }
}
