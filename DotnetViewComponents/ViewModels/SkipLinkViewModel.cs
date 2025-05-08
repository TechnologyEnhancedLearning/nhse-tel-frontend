namespace DotnetViewComponents.ViewModels
{
    public class SkipLinkViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SkipLinkViewModel"/> class.
        /// </summary>
        /// <param name="maincContentID">The ID of the main content element to which the skip link will navigate.</param>
        /// <param name="text">The text to be displayed for the skip link.</param>
        public SkipLinkViewModel(
            string maincContentID,
            string text)
        {
            MaincContentID = maincContentID;
            Text = text;
        }

        /// <summary>
        /// Gets or sets the ID of the main content element to which the skip link will navigate.
        /// </summary>
        public string MaincContentID { get; set; }

        /// <summary>
        /// Gets or sets the text to be displayed for the skip link.
        /// </summary>
        public string Text { get; set; }

    }
}
