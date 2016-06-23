using System;

namespace DemoApp.ComponentModel
{
    public class AbstractIPublishedContentMetaDataAttribute : Attribute
    {
        public Type ModelType { get; private set; }
        public string ContentTypeAlias { get; private set; }

        public AbstractIPublishedContentMetaDataAttribute(Type modelType, string contentTypeAlias)
        {
            ModelType = modelType;
            ContentTypeAlias = contentTypeAlias;
        }
    }
}