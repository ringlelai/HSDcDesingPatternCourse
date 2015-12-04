namespace hsdc.dpt.Control.DTO.Creational.FactoryMethod
{
    public class Marker : ILocationMarker
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Lat { get; set; }
        public decimal Lng { get; set; }
    }
}