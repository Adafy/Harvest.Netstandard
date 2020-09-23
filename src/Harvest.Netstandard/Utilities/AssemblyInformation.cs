using System;
using System.Reflection;

namespace Adafy.Harvest.Netstandard.Utilities
{
    public class AssemblyInformation : IAssemblyInformation
    {
        public Version Version
        {
            get
            {
                var assembly = Assembly.GetExecutingAssembly();
                var assemblyName = new AssemblyName(assembly.FullName);

                return assemblyName.Version;
            }
        }
    }
}
