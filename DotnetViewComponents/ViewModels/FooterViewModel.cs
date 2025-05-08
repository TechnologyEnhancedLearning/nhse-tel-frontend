namespace DotnetViewComponents.ViewModels
{
    public class FooterViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FooterViewModel"/> class.
        /// </summary>
        /// <param name="copyright">The copyright information to display in the footer.</param>
        /// <param name="footerGroupList">A collection of footer item groups.</param>
        /// <param name="isVerticallyAligned">Indicates whether the footer items should be vertically aligned. Default is true.</param>
        public FooterViewModel(
            string copyright,
            IEnumerable<FooterItemGroupModel> footerGroupList,
            bool isVerticallyAligned = true)
        {
            Copyright = copyright;
            FooterGroupList = footerGroupList;
            IsVerticallyAligned = isVerticallyAligned;
        }

        /// <summary>
        /// Gets or sets the copyright information displayed in the footer.
        /// </summary>
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or sets the list of footer item groups.
        /// </summary>
        public IEnumerable<FooterItemGroupModel> FooterGroupList { get; set;}

        /// <summary>
        /// Gets or sets a value indicating whether the footer items are vertically aligned.
        /// </summary>
        public bool IsVerticallyAligned { get; set; }

    }


    public class FooterItemGroupModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FooterItemGroupModel"/> class.
        /// </summary>
        /// <param name="footerItemList">A collection of footer items in this group.</param>
        /// <param name="isMeta">Indicates whether this group contains meta items. Default is false.</param>
        public FooterItemGroupModel(
            IEnumerable<FooterItemViewModel> footerItemList,
            bool isMeta = false)
        {
            FooterItemList = footerItemList;
            IsMeta = isMeta;
        }

        /// <summary>
        /// Gets or sets the list of footer items in this group.
        /// </summary>
        public IEnumerable<FooterItemViewModel> FooterItemList { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this group contains meta items.
        /// </summary>
        public bool IsMeta { get; set; }

    }
}
