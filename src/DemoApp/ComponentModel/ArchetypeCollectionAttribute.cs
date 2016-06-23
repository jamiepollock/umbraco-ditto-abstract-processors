using System;
using System.Linq;
using Archetype.Extensions;
using Archetype.Models;
using Our.Umbraco.Ditto;
using Umbraco.Core;

namespace DemoApp.ComponentModel
{
    [DittoProcessorMetaData(ValueType = typeof(ArchetypeModel))]
    public class ArchetypeCollectionAttribute : DittoProcessorAttribute
    {
        private Type CollectionType { get; set; }

        public ArchetypeCollectionAttribute(Type collectionType) : this()
        {
            CollectionType = collectionType;
        }

        public ArchetypeCollectionAttribute()
        {
        }

        public override object ProcessValue()
        {
            if (CollectionType == null)
            {
                var propertyType = Context.PropertyDescriptor.PropertyType;

                if (propertyType.IsEnumerable() && propertyType.IsGenericType)
                {
                    CollectionType = propertyType.GenericTypeArguments.FirstOrDefault();
                }
            }

            if (CollectionType == null) return null;

            var model = Value as ArchetypeModel;

            return model?.ToPublishedContentSet().As(CollectionType);
        }
    }
}