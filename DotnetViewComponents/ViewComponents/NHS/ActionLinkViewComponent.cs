namespace DotnetViewComponents.ViewComponents.NHS
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels.NHS;

    public class ActionLinkViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string aspController, string aspAction, Dictionary<string, string> aspAllRouteData, string linkText)
        {
            return View(new LinkViewModel(aspController, aspAction, linkText, aspAllRouteData));
        }
    }
}
