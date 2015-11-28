namespace hsdc.dpt.Control.Creational.Builder
{
    public interface IOfficeFormBuilder<T>
    {
        void BuildMaster();

        void BuildDetails();

        T GetResult();
    }
}