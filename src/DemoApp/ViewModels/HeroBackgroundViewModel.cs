using DemoApp.ComponentModel;

namespace DemoApp.ViewModels
{
    public interface IHero
    {
        string Url { get; set; }
    }

    public abstract class HeroBackgroundViewModel : IHero
    {
        public string Url { get; set; }
    }

    [AbstractIPublishedContentMetaData("Image")]
    public class ImageHeroBackgroundViewModel : HeroBackgroundViewModel
    {
    }

    [AbstractIPublishedContentMetaData("Video")]
    public class VideoHeroBackgroundViewModel : HeroBackgroundViewModel
    {

    }
}