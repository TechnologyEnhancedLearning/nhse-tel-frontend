namespace DotnetViewComponents.ViewModels
{
    public class TagViewModel
    {
        public TagViewModel(
            string name,
            string style = TagStyle.INPROGRESS)
        {
            Name = name;
            Style = style;
        }

        public string Name { get; set; }

        public string? Style { get; set;}
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
