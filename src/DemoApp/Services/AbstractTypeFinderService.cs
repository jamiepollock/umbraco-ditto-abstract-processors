using System;
using System.Linq;
using System.Reflection;
using DemoApp.ComponentModel;
using Umbraco.Core;

namespace DemoApp.Services
{
    public class AbstractTypeFinderService : IAbstractTypeFinderService
    {
        public Type FindMatchingType(Type propertyType, string documentTypeAlias)
        {
            var types =
                Assembly.GetExecutingAssembly()
                    .GetTypes()
                    .Where(t => t.GetCustomAttribute<AbstractIPublishedContentMetaDataAttribute>() != null);

            if (types.Any())
            {
                foreach (var type in types)
                {
                    var attribute = type.GetCustomAttribute<AbstractIPublishedContentMetaDataAttribute>();

                    var isContentTypeAliasAMatch = string.Equals(documentTypeAlias, attribute.ContentTypeAlias,
                        StringComparison.OrdinalIgnoreCase);


                    if (isContentTypeAliasAMatch)
                    {
                        var isMatchingInterface = propertyType.IsInterface && type.Inherits(propertyType);
                        var isMatchingAssignableClass = propertyType.IsClass && type.IsAssignableFrom(propertyType);

                        if (isMatchingInterface || isMatchingAssignableClass)
                        {
                            return type;
                        }
                    }
                }
            }

            return default(Type);
        }
    }

    public interface IAbstractTypeFinderService
    {
        Type FindMatchingType(Type propertyType, string documentTypeAlias);
    }
}