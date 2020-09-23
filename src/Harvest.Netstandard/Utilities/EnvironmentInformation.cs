using System;

namespace Adafy.Harvest.Netstandard.Utilities
{
    public class EnvironmentInformation : IEnvironmentInformation
    {
        public Version Version => Environment.Version;
    }
}
