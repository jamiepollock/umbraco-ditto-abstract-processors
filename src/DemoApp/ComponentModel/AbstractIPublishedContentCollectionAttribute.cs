using System.Collections.Generic;
using DemoApp.Helpers;
using DemoApp.Services;
using Our.Umbraco.Ditto;
using Umbraco.Core.Models;

namespace DemoApp.ComponentModel
{
    [DittoProcessorMetaData(ValueType = typeof(IEnumerable<IPublishedContent>))]
    public class AbstractIPublishedContentCollectionAttribute : DittoProcessorAttribute
    {
        public override object ProcessValue()
        {
            var models = Value as IEnumerable<IPublishedContent>;

            if (models == null)
            {
                return null;
            }

            var service = new AbstractTypeFinderService();
            var propertyType = TypeHelper.GetTypeFromIEnumerable(Context.PropertyDescriptor.PropertyType);
            
            if (propertyType != null)
            {
                var convertedModels = new List<object>();

                foreach (var model in models)
                {
                    var matchingType = service.FindMatchingType(propertyType, model.DocumentTypeAlias);

                    if (matchingType != null)
                    {
                        convertedModels.Add(model.As(matchingType));
                    }
                }

                return convertedModels;
            }

            return null;
        }
    }
}