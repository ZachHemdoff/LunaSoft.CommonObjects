using System;
using System.Collections.Generic;
using System.Text;

namespace LunaSoft.CommonObjects
{
    public sealed class Type
    {
        public static Type TypeOf(object obj)
        {
            return new Type();
        }

        public static Type TypeOf(System.Type dotnetType)
        {
            return new Type();
        }
    }
}
