using NullObjectPattern.Model.Interface;
using System.Collections.Generic;

namespace NullObjectPattern.Model
{
    public class VehichleStore
    {
        public static List<IVehichle> Vehichles = new List<IVehichle>()
        {
            new Bmw(),
            new Ferrari(),
            new Tata(),
        };
    }
}
