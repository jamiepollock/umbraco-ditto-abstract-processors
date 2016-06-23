using System.Collections.Generic;
using System.Linq;
using Our.Umbraco.Ditto;

namespace DemoApp.ComponentModel
{
    [DittoProcessorMetaData(ValueType = typeof(IEnumerable<object>))]
    public class FirstValueAttribute : DittoProcessorAttribute
    {
        public override object ProcessValue()
        {
            return ((IEnumerable<object>) Value).FirstOrDefault();
        }
    }
}