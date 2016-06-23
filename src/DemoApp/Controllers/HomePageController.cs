using System.Web.Mvc;
using DemoApp.ViewModels;
using Our.Umbraco.Ditto;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace DemoApp.Controllers
{
    public class HomePageController : RenderMvcController
    {
        public override ActionResult Index(RenderModel model)
        {
            var viewModel = model.As<HomePageViewModel>();

            return View(viewModel);
        }
    }
}