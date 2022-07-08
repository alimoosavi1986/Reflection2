using Reflection2.Attr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    [Check(MaxLength = 10)]
    public class Class5<T>
    {
        public int MyProperty { get; set; }
        public string MyProperty1 { get; set; }
    }
}
