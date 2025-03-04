namespace DotnetViewComponents.ViewModels
{
    public class FooterItemViewModel
    {
        public FooterItemViewModel(
            string title,
            string? url = "#")
        {
            Title = title;
            Url = url;
        }

        public string Title { get; set; }

        public string? Url { get; set; }

    }
}
