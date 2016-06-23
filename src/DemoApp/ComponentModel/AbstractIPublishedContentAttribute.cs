using DemoApp.Services;
using Our.Umbraco.Ditto;
using Umbraco.Core.Models;

namespace DemoApp.ComponentModel
{
    [DittoProcessorMetaData(ValueType = typeof(IPublishedContent))]
    public class AbstractIPublishedContentAttribute : DittoProcessorAttribute
    {
        public override object ProcessValue()
        {
            var model = Value as IPublishedContent;

            if (model == null)
            {
                return null;
            }

            var service = new AbstractTypeFinderService();
            var propertyType = Context.PropertyDescriptor.PropertyType;

            var matchingType = service.FindMatchingType(propertyType, model.DocumentTypeAlias);

            if (matchingType == null)
            {
                return null;
            }

            return model.As(matchingType);
        }
    }
}