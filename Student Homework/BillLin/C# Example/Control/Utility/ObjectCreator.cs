using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Utility
{
    internal class ObjectCreator<T>
    {
        internal static T CreateObject(string className)
        {
            string assemblyName = Assembly.GetAssembly(typeof(ObjectCreator<object>)).GetName().Name;
            return (T)Activator.CreateInstance(assemblyName, className).Unwrap();
        }
    }
}
