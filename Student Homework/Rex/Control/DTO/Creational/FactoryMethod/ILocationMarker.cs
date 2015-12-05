namespace hsdc.dpt.Control.DTO.Creational.FactoryMethod
{
    public interface ILocationMarker
    {
        int Id { get; set; }

        string Name { get; set; }

        decimal Lat { get; set; }

        decimal Lng { get; set; }
    }
}