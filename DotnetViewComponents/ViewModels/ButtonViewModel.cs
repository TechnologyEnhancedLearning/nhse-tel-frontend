namespace DotnetViewComponents.ViewModels
{
    public class ButtonViewModel
    {
        public ButtonViewModel(
            string text,
            string styling = ButtonStyle.PRIMARY,
            bool preventDoubleClick = false)
        {
            Text = text;
            Styling = styling;
            PreventDoubleClick = preventDoubleClick;
        }

        public string Text { get; set; }

        public string Styling { get; set; }

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
