using hsdc.dpt.Control.DTO.Creational.FactoryMethod;

namespace hsdc.dpt.Control.Creational.FactoryMethod
{
    public class GoogleMapUco : IMapUcoCreator<GoogleMapDto>
    {
        public GoogleMapDto GetViewModel(Position center)
        {
            throw new System.NotImplementedException();
        }
    }
}