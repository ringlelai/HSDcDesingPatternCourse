using hsdc.dpt.Control.DTO.Creational.FactoryMethod;

namespace hsdc.dpt.Control.Creational.FactoryMethod
{
    public interface IMapUcoCreator<out T>
    {
        T GetViewModel(Position center);

        // TODO Create Map Instance

        // TODO Set Center

        // TODO Add othet Position
    }
}