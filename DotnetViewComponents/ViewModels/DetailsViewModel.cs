namespace DotnetViewComponents.ViewModels
{
    public class DetailsViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailsViewModel"/> class.
        /// </summary>
        /// <param name="summary">The summary of the details.</param>
        /// <param name="content">The content of the details.</param>
        public DetailsViewModel(
            string summary,
            string content
        )
        {
            Summary = summary;
            Content = content;
        }

        /// <summary>
        /// Gets or sets the summary of the details.
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// Gets or sets the content of the details.
        /// </summary>
        public string Content { get; set; }
    }
}
