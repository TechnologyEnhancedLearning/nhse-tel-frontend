namespace DotnetViewComponents.ViewModels
{
    public class CharacterCountViewModel
    {
        public CharacterCountViewModel(
            string id,
            int maxLength,
            int? maxWords = null,
            int? threshold = null,
            string label = null,
            string hint = "Do not include personal information like your name, date of birth or NHS number.",
            string? errorMessage = null,
            bool hasError = false)
        {
            Id = id;
            MaxLength = maxLength;
            MaxWords = maxWords;
            Threshold = threshold;
            Label = label;
            Hint = hint;
            ErrorMessage = errorMessage;
            HasError = hasError;
        }

        public string Id { get; set; }

        public int MaxLength { get; set; }

        public int? MaxWords { get; set; }

        public int? Threshold { get; set; }

        public string Label { get; set; }

        public string Hint { get; set; }

        public string? ErrorMessage { get; set; }
        
        public bool HasError { get; set; }
    }
}
