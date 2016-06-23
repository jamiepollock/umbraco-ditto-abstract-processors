using DemoApp.ComponentModel;

namespace DemoApp.ViewModels
{
    public interface IHero
    {
        string Url { get; set; }
    }

    public abstract class HeroBackgroundViewModel
    {
        public string Url { get; set; }
    }

    [AbstractIPublishedContentMetaData(typeof(HeroBackgroundViewModel), "Image")]
    public class ImageHeroBackgroundViewModel : HeroBackgroundViewModel, IHero
    {
    }

    [AbstractIPublishedContentMetaData(typeof(HeroBackgroundViewModel), "Video")]
    public class VideoHeroBackgroundViewModel : HeroBackgroundViewModel
    {

    }
}