using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooUni.Data
{
    public class ViewsConstants
    {
        public class Animal
        {
            public const int TypeMinLength = 2;
            public const int TypeMaxLength = 20;
            public const int NameMinLength = 2;
            public const int NameMaxLength = 20;
        }

        public class Owner
        {
            public const int NameMaxLength = 20;
            public const int NameMinLength = 2;
            public const int InformationMinLength = 10;
        }
    }
}
