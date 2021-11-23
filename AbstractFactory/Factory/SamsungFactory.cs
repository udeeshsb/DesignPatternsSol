using AbstractFactory.Mobile;
using AbstractFactory.Signal;

namespace AbstractFactory
{
    public class SamsungFactory : IMobileFactory
    {
        public IMobile GetMobile(ModelType modelType)
        {
            switch(modelType)
            {
                case ModelType.J7Prime:
                    return new SamsungJ7Prime();
                case ModelType.A9:
                    return new SamsungA9();
                default:
                    throw new System.Exception("Invalid model type");
            } 
        }

        public ISignal GetSignalStrenght(ModelType modelType)
        {
            switch (modelType)
            {
                case ModelType.J7Prime:
                    return new SamsungJ7PrimeSignal();
                case ModelType.A9:
                    return new SamsungA9Signal();
                default:
                    throw new System.Exception("Invalid model type");
            } 
        }
    }
}
