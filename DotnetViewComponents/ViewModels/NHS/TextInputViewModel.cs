namespace DotnetViewComponents.ViewModels.NHS
{
    using System.Collections.Generic;
    using System.Linq;

    public class TextInputViewModel
    {
        public TextInputViewModel(
            string id,
            string name,
            string label,
            string? value,
            string type,
            bool spellCheck,
            string? autocomplete,
            IEnumerable<string> errorMessages,
            string? cssClass = null,
            string? hintText = null,
            bool required = false,
            string? placeholder = null,
            string? requiredSideClientErrorMessage = default,
            string? prefix = null,
            string? suffix = null
        )
        {
            var errorMessageList = errorMessages.ToList();

            Id = id;
            Class = cssClass;
            Name = name;
            Label = (!required && !label.EndsWith("(optional)") ? label + " (optional)" : label);
            Value = value;
            Type = type;
            SpellCheck = spellCheck;
            Autocomplete = autocomplete;
            HintText = hintText;
            Required = required;
            ErrorMessages = errorMessageList;
            HasError = errorMessageList.Any();
            PlaceHolder = placeholder;
            RequiredClientSideErrorMessage = requiredSideClientErrorMessage;
            Prefix = prefix;
            Suffix = suffix;
        }

        public string Id { get; set; }
        public string? Class { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        public string? Value { get; set; }
        public string Type { get; set; }
        public bool SpellCheck { get; set; }
        public string? Autocomplete { get; set; }
        public string? HintText { get; set; }
        public bool Required { get; set; }
        public IEnumerable<string> ErrorMessages { get; set; }
        public readonly bool HasError;
        public string? PlaceHolder { get; set; }
        public string? RequiredClientSideErrorMessage { get; set; }
        public string? Prefix { get; set; }
        public string? Suffix { get; set; }
    }

}
