namespace hsdc.dpt.Control.Creational.Builder
{
    public interface IOfficeFormBuilder<out T>
    {
        void BuildMaster();

        void BuildDetails();

        T GetResult();
    }
}