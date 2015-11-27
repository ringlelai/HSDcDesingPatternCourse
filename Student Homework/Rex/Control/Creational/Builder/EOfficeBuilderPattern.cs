using hsdc.dpt.Control.DTO.Creational.Builder;

namespace hsdc.dpt.Control.Creational.Builder
{
    public class EOfficeDirector<T>
    {
        public T Construct(IOfficeFormBuilder<T> builder)
        {
            builder.BuildMaster();
            builder.BuildDetails();
            return builder.GetResult();
        }
    }
}