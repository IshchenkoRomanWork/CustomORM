using System;
using System.Collections.Generic;
using System.Text;

namespace CustomORM.Interfaces
{
    interface IORM
    {
        public void InsertToDatabase(object item);
        public void GetFromDatabase(out object item, Predicate<object> predicateToMatch);
        public void UpdateInDatabase(object item);
        public void DeleteFromDatabase(object item);
        public void Save();
    }
}
