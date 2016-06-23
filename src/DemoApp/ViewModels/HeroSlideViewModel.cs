using System.Web;
using DemoApp.ComponentModel;
using Our.Umbraco.Ditto;

namespace DemoApp.ViewModels
{
    public class HeroSlideViewModel
    {
        public IHtmlString Text { get; set; }

        [UmbracoProperty]
        [UmbracoPicker]
        [FirstValue]
        [AbstractIPublishedContent]
        public IHero Background { get; set; }

        public string ContentPosition { get; set; }
    }
}