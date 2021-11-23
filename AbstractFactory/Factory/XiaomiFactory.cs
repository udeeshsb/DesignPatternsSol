using AbstractFactory.Mobile;
using AbstractFactory.Signal;

namespace AbstractFactory
{
    public class XiaomiFactory : IMobileFactory
    {
        public IMobile GetMobile(ModelType modelType)
        {
            switch (modelType)
            {
                case ModelType.Redmi6:
                    return new XiaomiRedmi6();
                case ModelType.RedmiPro:
                    return new XiaomiRedmiPro();
                default:
                    throw new System.Exception("Invalid model type");
            }
        }

        public ISignal GetSignalStrenght(ModelType modelType)
        {
            switch (modelType)
            {
                case ModelType.Redmi6:
                    return new XiaomiRedmi6Signal();
                case ModelType.RedmiPro:
                    return new XiaomiRedmiProSignal();
                default:
                    throw new System.Exception("Invalid model type");
            }
             
        }
    }
}
