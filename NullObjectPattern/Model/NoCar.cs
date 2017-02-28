using NullObjectPattern.Model.Interface;

namespace NullObjectPattern.Model
{
    public class NoCar : IVehichle
    {
        public string Name { get; set; }
        public void Start(){}
        public void Stop() {}
    }
}
