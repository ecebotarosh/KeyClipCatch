

namespace Modules
{
    public abstract class GetterModule : IModule
    {
        public object _data;

        public abstract void Execute();

        public abstract object GetData();
    }
}
