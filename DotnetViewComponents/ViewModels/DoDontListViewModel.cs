namespace DotnetViewComponents.ViewModels
{
    public class DoDontListViewModel
    {
        public DoDontListViewModel(
            bool isDo,
            string[] ruleSet)
        {
            IsDo = isDo;
            RuleSet = ruleSet;
        }

        public bool IsDo { get; set; }

        public string[] RuleSet { get; set; }
    }
}
