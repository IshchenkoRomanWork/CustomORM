using System;
using System.Collections.Generic;
using System.Text;

namespace CustomORM.Models.Attributes
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class IsForeignKey : Attribute
    {
       internal string OriginalTable { get; set; }
       public IsForeignKey(string originalTable)
        {
            OriginalTable = originalTable;
        }
    }
}
