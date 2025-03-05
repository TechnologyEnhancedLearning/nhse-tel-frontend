namespace DotnetViewComponents.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels;

    public class ButtonViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            string text,
            string styling = ButtonStyle.PRIMARY,
            bool preventDoubleClick = false)
        {
            var model = new ButtonViewModel(text, styling, preventDoubleClick);

            return View(model);
        }
    }
}
