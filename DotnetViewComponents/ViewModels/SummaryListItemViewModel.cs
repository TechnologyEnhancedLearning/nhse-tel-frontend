namespace DotnetViewComponents.ViewModels
{
    public class SummaryListItemViewModel
    {
        public SummaryListItemViewModel(
            string title,
            string description,
            string? actionName = null,
            string? actionUrl = null)
        {
            Title = title;
            Description = description;
            ActionName = actionName;
            ActionUrl = actionUrl;
        }

        public string Title { get; set; }

        public string Description { get; set; }

        public string? ActionName { get; set; }

        public string? ActionUrl { get; set; }
    }
}
