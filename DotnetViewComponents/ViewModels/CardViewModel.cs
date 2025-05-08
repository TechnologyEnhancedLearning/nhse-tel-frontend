namespace DotnetViewComponents.ViewModels
{
    public class CardViewModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CardViewModel"/> class.
        /// </summary>
        /// <param name="title">The title of the card.</param>
        /// <param name="description">The content description of the card. Optional</param>
        /// <param name="imageSrc">The source URL of the image to be displayed on the card. Optional.</param>
        /// <param name="headingLevel">The HTML heading level for the title. Defaults to <c>2</c>, which results in h2.</param>
        /// <param name="hasArrow">Indicates whether the card should display an arrow. Defaults to <c>false</c>.</param>
        /// <param name="isSecondary">Indicates whether the card is styled as a secondary card. Defaults to <c>false</c>.</param>
        /// <param name="aspController">The asp-controller to dynamically set the controller path of the link.</param>
        /// <param name="aspAction">The asp-action to dynamically set the action path of the link..</param>
        /// <param name="aspRouteData">The asp-all-route-data to dynamically set the extra parameters to the path of the link.</param>
        public CardViewModel(
            string title,
            string? description,
            string? imageSrc,
            int headingLevel,
            bool hasArrow,
            bool isSecondary,
            string? aspController,
            string? aspAction,
            Dictionary<string, string>? aspRouteData)
        {
            Title = title;
            Description = description;
            ImageSrc = imageSrc;
            HeadingLevel = headingLevel;
            HasArrow = hasArrow;
            IsSecondary = isSecondary;
            AspController = aspController;
            AspAction = aspAction;
            AspRouteData = aspRouteData;
        }

        /// <summary>
        /// Gets or sets the title of the card.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description of the card.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the source URL of the image to be displayed on the card.
        /// </summary>
        public string? ImageSrc { get; set; }

        /// <summary>
        /// Gets or sets the HTML heading level for the title.
        /// </summary>
        public int HeadingLevel { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the card should display an arrow.
        /// </summary>
        public bool HasArrow { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the card is styled as a secondary card.
        /// </summary>
        public bool IsSecondary { get; set; }

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
    }
}
