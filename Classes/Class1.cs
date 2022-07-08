using Reflection2.Attr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    [Check(MaxLength = 10)]
    public class Class1
    {
        public string Name { get; set; }
        public string Family { get; set; }
    }
}
