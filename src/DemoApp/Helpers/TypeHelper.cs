using System;
using System.Linq;
using Umbraco.Core;

namespace DemoApp.Helpers
{
    public static class TypeHelper
    {
        public static Type GetTypeFromIEnumerable(Type type)
        {
            if (type.IsEnumerable() && type.IsGenericType)
            {
                return type.GenericTypeArguments.FirstOrDefault();
            }

            throw new ArgumentException("Provided Type is not an IEnumerable<T>.", nameof(type));
        }
    }
}