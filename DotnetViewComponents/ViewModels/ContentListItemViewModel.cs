namespace DotnetViewComponents.ViewModels
{
    public class ContentsListItemViewModel
    {
        public ContentsListItemViewModel(
            string title,
            string url,
            bool isActive = false)
        {
            Title = title;
            Url = url;
            IsActive = isActive;
        }

        public string Title { get; set; }

        public string Url { get; set; }

        public bool IsActive { get; set; }
    }

}
