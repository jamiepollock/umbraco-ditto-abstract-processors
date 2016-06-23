using System;

namespace DemoApp.ComponentModel
{
    public class AbstractIPublishedContentMetaDataAttribute : Attribute
    {
        public string ContentTypeAlias { get; private set; }

        public AbstractIPublishedContentMetaDataAttribute(string contentTypeAlias)
        {
            ContentTypeAlias = contentTypeAlias;
        }
    }
}