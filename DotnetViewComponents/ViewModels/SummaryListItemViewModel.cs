namespace DotnetViewComponents.ViewModels
{
    public class SummaryListItemViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryListItemViewModel"/> class.
        /// </summary>
        /// <param name="title">The title of the summary item.</param>
        /// <param name="description">The description of the summary item.</param>
        /// <param name="actionName">Optional name of the action associated with the summary item.</param>
        /// <param name="aspController">The asp-controller to dynamically set the controller path of the link.</param>
        /// <param name="aspAction">The asp-action to dynamically set the action path of the link..</param>
        /// <param name="aspRouteData">The asp-all-route-data to dynamically set the extra parameters to the path of the link.</param>
        public SummaryListItemViewModel(
            string title,
            string description,
            string? actionName = null,
            string? aspController = null,
            string? aspAction = null,
            Dictionary<string, string>? aspRouteData = null)
        {
            Title = title;
            Description = description;
            ActionName = actionName;
            AspController = aspController;
            AspAction = aspAction;
            AspRouteData = aspRouteData;
        }

        /// <summary>
        /// Gets or sets the title of the summary item.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description of the summary item.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the optional name of the action associated with the summary item.
        /// </summary>
        public string? ActionName { get; set; }

        /// <summary>
        /// Gets or sets the asp-controller of the link.
        /// </summary>
        public string? AspController { get; set; }

        /// <summary>
        /// Gets or sets the as-action of the link.
        /// </summary>
        public string? AspAction { get; set; }

        /// <summary>
        /// Gets or sets the asp-all-route-data of the link.
        /// </summary>
        public Dictionary<string, string>? AspRouteData { get; set; }
    }
}
