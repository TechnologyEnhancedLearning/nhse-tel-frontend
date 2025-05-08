namespace DotnetViewComponents.ViewModels
{
    public class ImageViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageViewModel"/> class.
        /// </summary>
        /// <param name="src">The source URL of the image.</param>
        /// <param name="alt">The alternative text for the image, used for accessibility.</param>
        /// <param name="caption">The caption to be displayed with the image.</param>
        /// <param name="additionalAttributes">Optional additional attributes for the image element.</param>
        public ImageViewModel(
            string src,
            string alt,
            string caption,
            string? additionalAttributes)
        {
            Src = src;
            Alt = alt;
            Caption = caption;
            AdditionalAttributes = additionalAttributes;
        }

        /// <summary>
        /// Gets or sets the source URL of the image.
        /// </summary>
        public string Src { get; set; }

        /// <summary>
        /// Gets or sets the alternative text for the image, used for accessibility.
        /// </summary>
        public string Alt { get; set; }

        /// <summary>
        /// Gets or sets the caption to be displayed with the image.
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// Gets or sets optional additional attributes for the image element.
        /// </summary>
        public string? AdditionalAttributes { get; set; }
    }


}
