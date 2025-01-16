namespace DotnetViewComponents.ViewModels.NHS
{
    public class BreadcrumbsModel
    {
        public BreadcrumbsModel(string title, string url) {
            Title = title;
            Url = url;
        }

        public string Title { get; set; }

        public string Url { get; set; }
    }
}
