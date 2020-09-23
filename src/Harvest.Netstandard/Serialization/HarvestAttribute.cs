using System;

namespace Adafy.Harvest.Netstandard.Serialization
{
    public class HarvestSerializeAttribute : Attribute
    {
        public bool DateOnly { get; set; }
    }
}
