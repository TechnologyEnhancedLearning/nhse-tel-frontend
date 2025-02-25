namespace DotnetViewComponents.ViewModels
{
    public class CardViewModel
    {
        public CardViewModel(
            string title,
            string? description = null,
            string? imageSrc = null,
            int headingLevel = 2,
            bool hasArrow = false,
            bool isSecondary = false,
            bool isClickable = true)
        {
            Title = title;
            Description = description;
            ImageSrc = imageSrc;
            HeadingLevel = headingLevel;
            HasArrow = hasArrow;
            IsSecondary = isSecondary;
            IsClickable = isClickable;
        }

        public string Title { get; set; }

        public string? Description { get; set; }

        public string? ImageSrc { get; set; }

        public int HeadingLevel { get; set; }

        public bool HasArrow { get; set; }

        public bool IsSecondary { get; set; }

        public bool IsClickable { get; set; }
    }
}
