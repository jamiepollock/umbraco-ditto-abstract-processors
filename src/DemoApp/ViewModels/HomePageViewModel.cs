using System.Collections.Generic;
using DemoApp.ComponentModel;
using Our.Umbraco.Ditto;

namespace DemoApp.ViewModels
{
    public class HomePageViewModel : MasterViewModel
    {
        [UmbracoProperty("hero_slides")]
        [ArchetypeCollection]
        public IEnumerable<HeroSlideViewModel> Heroes { get; set; }
    }
}