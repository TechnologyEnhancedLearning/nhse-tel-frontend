namespace DotnetViewComponents.ViewModels
{
    /// <summary>
    /// Represents the view model for a character count component.
    /// </summary>
    public class CharacterCountViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterCountViewModel"/> class.
        /// </summary>
        /// <param name="id">The unique identifier for the character count component.</param>
        /// <param name="maxLength">The maximum number of characters allowed.</param>
        /// <param name="maxWords">The optional maximum number of words allowed. Defaults to <c>null</c>.</param>
        /// <param name="threshold">The optional threshold for character count warnings. Defaults to <c>null</c>.</param>
        /// <param name="label">The label for the character count component. Defaults to <c>null</c>.</param>
        /// <param name="hint">A hint or instruction for the user. Defaults to a predefined message.</param>
        /// <param name="errorMessage">An optional error message to display when validation fails. Defaults to <c>null</c>.</param>
        /// <param name="hasError">Indicates whether there is a validation error. Defaults to <c>false</c>.</param>
        public CharacterCountViewModel(
            string id,
            int maxLength,
            int? maxWords,
            int? threshold,
            string? label,
            string hint,
            string? errorMessage,
            bool hasError)
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

        /// <summary>
        /// Gets or sets the unique identifier for the character count component.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of characters allowed.
        /// </summary>
        public int MaxLength { get; set; }

        /// <summary>
        /// Gets or sets the optional maximum number of words allowed.
        /// </summary>
        public int? MaxWords { get; set; }

        /// <summary>
        /// Gets or sets the optional threshold for character count warnings.
        /// </summary>
        public int? Threshold { get; set; }

        /// <summary>
        /// Gets or sets the label for the character count component.
        /// </summary>
        public string? Label { get; set; }

        /// <summary>
        /// Gets or sets a hint for the user.
        /// </summary>
        public string Hint { get; set; }

        /// <summary>
        /// Gets or sets an optional error message to display when validation fails.
        /// </summary>
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether there is a validation error.
        /// </summary>
        public bool HasError { get; set; }
    }
}
