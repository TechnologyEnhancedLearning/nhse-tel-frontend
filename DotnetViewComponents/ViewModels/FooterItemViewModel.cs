namespace DotnetViewComponents.ViewModels
{
    public class FooterItemViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FooterItemViewModel"/> class.
        /// </summary>
        /// <param name="title">The title of the footer item.</param>
        /// <param name="aspController">The ASP.NET controller for the link.</param>
        /// <param name="aspAction">The ASP.NET action for the link.</param>
        /// <param name="aspRouteData">A dictionary containing additional route data for the link.</param>
        public FooterItemViewModel(
            string title,
            string aspController,
            string aspAction,
            Dictionary<string, string> aspRouteData)
        {
            Title = title;
            AspController = aspController;
            AspAction = aspAction;
            AspRouteData = aspRouteData;
        }

        /// <summary>
        /// Gets or sets the title of the link.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the asp-controller of the link.
        /// </summary>
        public string AspController { get; set; }

        /// <summary>
        /// Gets or sets the asp-action of the link.
        /// </summary>
        public string AspAction { get; set; }

        /// <summary>
        /// Gets or sets the asp-all-route-data of the link.
        /// </summary>
        public Dictionary<string, string> AspRouteData { get; set; }

    }
}
