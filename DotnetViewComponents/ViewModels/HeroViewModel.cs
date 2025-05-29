namespace DotnetViewComponents.ViewModels
{
    public class HeroViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HeroViewModel"/> class.
        /// </summary>
        /// <param name="imageSrc">The source URL of the hero image.</param>
        /// <param name="heading">The heading text for the hero section.</param>
        /// <param name="textContent">The main text content for the hero section.</param>
        public HeroViewModel(
            string? imageSrc,
            string? heading,
            string? textContent)
        {
            ImageSrc = imageSrc;
            Heading = heading;
            TextContent = textContent;
        }

        /// <summary>
        /// Gets or sets the source URL of the hero image.
        /// </summary>
        public string? ImageSrc { get; set; }

        /// <summary>
        /// Gets or sets the heading text for the hero section.
        /// </summary>
        public string? Heading { get; set;}

        /// <summary>
        /// Gets or sets the main text content for the hero section.
        /// </summary>
        public string? TextContent { get; set;}
    }
}
