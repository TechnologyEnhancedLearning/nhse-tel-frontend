namespace DotnetViewComponents.ViewModels
{
    public class SkipLinkViewModel
    {
        public SkipLinkViewModel(
            string maincContentID,
            string text)
        {
            MaincContentID = maincContentID;
            Text = text;
        }

        public string MaincContentID { get; set; }

        public string Text { get; set; }

    }
}
