namespace DotnetViewComponents.ViewComponents.NHS
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using DotnetViewComponents.ViewModels.NHS;

    public class CancelLinkViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            string aspController,
            string aspAction,
            Dictionary<string, string> aspAllRouteData
        )
        {
            return View(new LinkViewModel(aspController, aspAction, "Cancel", aspAllRouteData));
        }
    }
}
