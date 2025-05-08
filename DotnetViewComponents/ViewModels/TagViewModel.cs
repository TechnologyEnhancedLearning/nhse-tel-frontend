namespace DotnetViewComponents.ViewModels
{
    public class TagViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagViewModel"/> class.
        /// </summary>
        /// <param name="name">The name of the tag.</param>
        /// <param name="styling">The styling class for the tag. Defaults to <see cref="TagStyle.INPROGRESS"/>.</param>
        public TagViewModel(
            string name,
            string styling)
        {
            Name = name;
            Styling = styling;
        }

        /// <summary>
        /// Gets or sets the name of the tag.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the styling class for the tag.
        /// </summary>
        public string? Styling { get; set;}
    }

    public static class TagStyle
    {
        public const string INPROGRESS = "nhsuk-tag--white";
        public const string INACTIVE = "nhsuk-tag--grey";
        public const string NEW = "nhsuk-tag--green";
        public const string ACTIVE = "nhsuk-tag--aqua-green";
        public const string PENDING = "nhsuk-tag--blue";
        public const string RECEIVED = "nhsuk-tag--purple";
        public const string SENT = "nhsuk-tag--pink";
        public const string REJECTED = "nhsuk-tag--red";
        public const string DECLINED = "nhsuk-tag--orange";
        public const string DELAYED = "nhsuk-tag--yellow";
    }
}
