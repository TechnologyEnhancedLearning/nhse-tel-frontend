namespace DotnetViewComponents.ViewModels
{
    public class BreadcrumbsViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BreadcrumbsViewModel"/> class.
        /// It receives a list of of string tuples containing the name/title of the link and the url path to it.
        /// </summary>
        /// <param name="links">A list of tuples representing the breadcrumb links where each tuple contains a title
        /// and a URL in the form of asp-controller, asp-action and asp-routeData.</param>
        public BreadcrumbsViewModel(List<(string title, string aspController, string aspAction, Dictionary<string, string>? aspRouteData)> links)
        {
            Links = links;
        }

        /// <summary>
        /// Gets or sets the list of breadcrumb links.
        /// Each link is represented as a tuple containing the title, ASP.NET controller, ASP.NET action, and optional route data.
        /// </summary>
        public List<(string Title, string aspController, string aspAction, Dictionary<string, string>? aspRouteData)> Links { get; set; }

    }
}
