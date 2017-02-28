using System;
using NullObjectPattern.Model.Interface;
using System.Linq;

namespace NullObjectPattern.Model
{
    public class VehichleHelper : VehichleStore
    {
        public static IVehichle Find(string name) => Vehichles
                                                 .FirstOrDefault(x => string.Equals(x.Name, name, StringComparison.CurrentCultureIgnoreCase)) 
                                                 ?? new NoCar(); 
    }
}
