

namespace Modules
{
    public abstract class GetterModule
    {
        protected DataCapsule.DataCapsule.DataCapsule _data;

        public abstract void Execute();

        public DataCapsule.DataCapsule.DataCapsule GetData()
        {
            return _data;
        }
    }
}
