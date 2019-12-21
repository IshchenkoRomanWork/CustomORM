using System;
using System.Collections.Generic;
using System.Text;

namespace CustomORM.Interfaces
{
    interface IMapper
    {
        internal object GetDboFrom(object item);
        internal object GetDtoFrom(object item);

    }
}
