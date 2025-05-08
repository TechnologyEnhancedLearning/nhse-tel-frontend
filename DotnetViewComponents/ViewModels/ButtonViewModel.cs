namespace DotnetViewComponents.ViewModels
{
    public class ButtonViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonViewModel"/> class.
        /// </summary>
        /// <param name="text">The text to be displayed on the button.</param>
        /// <param name="aspController">The asp-controller to dynamically set the controller path of the link.</param>
        /// <param name="aspAction">The asp-action to dynamically set the action path of the link..</param>
        /// <param name="aspRouteData">The asp-all-route-data to dynamically set the extra parameters to the path of the link.</param>
        /// <param name="url">The url for the link.</param>
        /// <param name="style">The style attributes for the button.</param>
        /// <param name="styling">The styling class for the button. Defaults to <see cref="ButtonStyle.PRIMARY"/>.</param>
        /// <param name="preventDoubleClick">Indicates whether to prevent double-clicking the button. Defaults to <c>false</c>.</param>
        public ButtonViewModel(
            string text,
            string? aspController,
            string? aspAction,
            Dictionary<string, string>? aspRouteData,
            string styling,
            string style,
            bool preventDoubleClick)
        {
            Text = text;
            AspController = aspController;
            AspAction = aspAction;
            AspRouteData = aspRouteData;
            Styling = styling;
            Style = style;
            PreventDoubleClick = preventDoubleClick;
        }

        /// <summary>
        /// Gets or sets the text displayed on the button.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the asp-controller of the link.
        /// </summary>
        public string? AspController { get; set; }

        /// <summary>
        /// Gets or sets the asp-action of the link.
        /// </summary>
        public string? AspAction { get; set; }

        /// <summary>
        /// Gets or sets the asp-all-route-data of the link.
        /// </summary>
        public Dictionary<string, string>? AspRouteData { get; set; }

        /// <summary>
        /// Gets or sets the styling for the button.
        /// </summary>
        public string Styling { get; set; }

        /// <summary>
        /// Gets or sets the style attributes on the button.
        /// </summary>
        public string Style { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to prevent double-clicking the button.
        /// </summary>
        public bool PreventDoubleClick { get; set; }

    }

    public static class ButtonStyle
    {
        public const string PRIMARY = "nhsuk-button";
        public const string SECONDARY = "nhsuk-button nhsuk-button--secondary";
        public const string REVERSE = "nhsuk-button nhsuk-button--reverse";
        public const string WARNING = "nhsuk-button nhsuk-button--warning";
    }
}
