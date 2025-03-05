namespace DotnetViewComponents.ViewModels
{
    public class ImageViewModel
    {
        public ImageViewModel(
            string src,
            string alt,
            string caption,
            string? sizes = null,
            string? srcSet = null,
            string? additionalAttributes = null)
        {
            Src = src;
            Alt = alt;
            Caption = caption;
            Sizes = sizes;
            SrcSet = srcSet;
            AdditionalAttributes = additionalAttributes;
        }

        public string Src { get; set; }

        public string Alt { get; set; }

        public string Caption { get; set; }

        public string? Sizes { get; set; }

        public string? SrcSet { get; set; }

        public string? AdditionalAttributes { get; set; }
    }


}
