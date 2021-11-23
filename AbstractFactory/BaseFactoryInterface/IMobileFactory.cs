
namespace AbstractFactory
{
    public interface IMobileFactory
    {
        IMobile GetMobile(ModelType modelType);
        ISignal GetSignalStrenght(ModelType modelType);
    }
}
