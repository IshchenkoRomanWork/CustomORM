using System;
using System.Collections.Generic;
using System.Text;

namespace CustomORM.Interfaces
{
    interface IRepository
    {
        public void Create(object item);
        public void Find(object item, Predicate<object> predicate);
        public void Update(object item);
        public void Delete(object item);
        
    }
}
