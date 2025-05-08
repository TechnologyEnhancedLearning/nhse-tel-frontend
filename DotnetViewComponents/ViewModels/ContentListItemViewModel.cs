namespace DotnetViewComponents.ViewModels
{
    public class ContentsListItemViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsListItemViewModel"/> class.
        /// </summary>
        /// <param name="title">The title of the contents-list item.</param>
        /// <param name="aspController">The asp-controller to dynamically set the controller path of the link.</param>
        /// <param name="aspAction">The asp-action to dynamically set the action path of the link..</param>
        /// <param name="aspRouteData">The asp-all-route-data to dynamically set the extra parameters to the path of the link.</param>
        /// <param name="isActive">Indicates whether the item is currently active. Defaults to <c>false</c>.</param>
        public ContentsListItemViewModel(
            string title,
            string aspController,
            string aspAction,
            Dictionary<string, string> aspRouteData,
            bool isActive = false)
        {
            Title = title;
            AspController = aspController;
            AspAction = aspAction;
            AspRouteData = aspRouteData;
            IsActive = isActive;
        }

        /// <summary>
        /// Gets or sets the title of the contents-list item.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the asp-controller of the link.
        /// </summary>
        public string AspController { get; set; }

        /// <summary>
        /// Gets or sets the as-action of the link.
        /// </summary>
        public string AspAction { get; set; }

        /// <summary>
        /// Gets or sets the asp-all-route-data of the link.
        /// </summary>
        public Dictionary<string, string> AspRouteData { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the item is currently active.
        /// </summary>
        public bool IsActive { get; set; }
    }

}
