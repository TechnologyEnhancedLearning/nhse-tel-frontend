namespace DotnetViewComponents.ViewModels
{
    public class DoDontListViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DoDontListViewModel"/> class.
        /// </summary>
        /// <param name="isDo">Indicates whether the list represents "Do" rules (true) or "Don't" rules (false).</param>
        /// <param name="ruleSet">A list of rules associated with the "Do" or "Don't" category.</param>
        public DoDontListViewModel(
            bool isDo,
            List<string> ruleSet)
        {
            IsDo = isDo;
            RuleSet = ruleSet;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the list represents "Do" rules.
        /// </summary>
        public bool IsDo { get; set; }

        /// <summary>
        /// Gets or sets the list of rules associated with the "Do" or "Don't" category.
        /// </summary>
        public List<string> RuleSet { get; set; }
    }
}
