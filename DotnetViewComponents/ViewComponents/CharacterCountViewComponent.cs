namespace DotnetViewComponents.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    /// <summary>
    /// A ViewComponent that renders a character-count input.
    /// </summary>
    public class CharacterCountViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            string id,
            int maxLength,
            int? maxWords = null,
            int? threshold = null,
            string? label = null,
            string hint = "Do not include personal information like your name, date of birth or NHS number.",
            string? errorMessage = null,
            bool hasError = false)
        {
            var model = new CharacterCountViewModel
            (
                id,
                maxLength,
                maxWords,
                threshold,
                label,
                hint,
                errorMessage,
                hasError
            );
            return View(model);
        }
    }
}
