namespace DotnetViewComponents.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    public class CharacterCountViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            string id,
            int maxLength,
            int? maxWords = null,
            int? threshold = null,
            string? errorMessage = null,
            bool hasError = false)
        {
            var model = new CharacterCountViewModel
            (
                id,
                maxLength,
                maxWords,
                threshold,
                errorMessage,
                hasError
            );
            return View(model);
        }
    }
}
