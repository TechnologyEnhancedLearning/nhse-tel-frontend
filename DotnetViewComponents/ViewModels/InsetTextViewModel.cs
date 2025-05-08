namespace DotnetViewComponents.ViewModels
{
    public class InsetTextViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsetTextViewModel"/> class.
        /// </summary>
        /// <param name="contentHtml">The HTML content to be displayed as inset text.</param>
        public InsetTextViewModel(string contentHtml)
        {
            ContentHtml = contentHtml;
        }

        /// <summary>
        /// Gets or sets the HTML content to be displayed as inset text.
        /// </summary>
        public string ContentHtml { get; set; }
    }
}
