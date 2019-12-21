using CustomORM.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomORM.Models.Attributes
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class IsColumn : DataBaseAttribute
    {
        internal string DBDataType { get; set; }

        public IsColumn(string columnName, string dbDataType) : base(columnName)
        {
            DBDataType = dbDataType;
        }
    }
}
