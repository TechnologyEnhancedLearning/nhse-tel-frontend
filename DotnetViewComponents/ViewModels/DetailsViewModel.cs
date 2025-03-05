namespace DotnetViewComponents.ViewModels
{
    public class DetailsViewModel
    {
        public DetailsViewModel(
            string summary,
            string content
        )
        {
            Summary = summary;
            Content = content;
        }

        public string Summary { get; set; }

        public string Content { get; set; }
    }
}
