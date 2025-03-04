namespace DotnetViewComponents.ViewModels
{
    public class FooterViewModel
    {
        public FooterViewModel(
            string copyright,
            IEnumerable<FooterItemGroupModel> footerGroupList,
            bool isVerticallyAligned = true)
        {
            Copyright = copyright;
            FooterGroupList = footerGroupList;
            IsVerticallyAligned = isVerticallyAligned;
        }

        public string Copyright { get; set; }

        public IEnumerable<FooterItemGroupModel> FooterGroupList { get; set;}

        public bool IsVerticallyAligned { get; set; }

    }


    public class FooterItemGroupModel
    {
        public FooterItemGroupModel(
            IEnumerable<FooterItemViewModel> footerItemList,
            bool isMeta = false)
        {
            FooterItemList = footerItemList;
            IsMeta = isMeta;
        }

        public IEnumerable<FooterItemViewModel> FooterItemList { get; set; }

        public bool IsMeta { get; set; }

    }
}
