using Our.Umbraco.Ditto;
using Umbraco.Core.Models;

namespace DemoApp.ComponentModel
{
    [DittoProcessorMetaData(ValueType = typeof(IPublishedContent))]
    public class UmbracoUrlAttribute : DittoProcessorAttribute
    {
        public override object ProcessValue()
        {
            var model = Value as IPublishedContent;

            return model?.Url;
        }
    }
}