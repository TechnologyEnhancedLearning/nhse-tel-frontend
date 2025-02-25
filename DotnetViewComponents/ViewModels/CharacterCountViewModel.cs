namespace DotnetViewComponents.ViewModels
{
    public class CharacterCountViewModel
    {
        public CharacterCountViewModel(
            string id,
            int maxLength,
            int? maxWords = null,
            int? threshold = null,
            string? errorMessage = null,
            bool hasError = false)
        {
            Id = id;
            MaxLength = maxLength;
            MaxWords = maxWords;
            Threshold = threshold;
            ErrorMessage = errorMessage;
            HasError = hasError;
        }

        public string Id { get; set; }

        public int MaxLength { get; set; }

        public int? MaxWords { get; set; }

        public int? Threshold { get; set; }

        public string? ErrorMessage { get; set; }
        
        public bool HasError { get; set; }
    }
}
