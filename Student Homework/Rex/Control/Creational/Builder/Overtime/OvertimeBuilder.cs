using hsdc.dpt.Control.DTO.Creational.Builder;

namespace hsdc.dpt.Control.Creational.Builder.Overtime
{
    public class OvertimeBuilder : IOfficeFormBuilder<OverTime>
    {
        private OverTime _dto;

        public void BuildMaster()
        {
            _dto = new OverTime();
        }

        public void BuildDetails()
        {
        }

        public OverTime GetResult()
        {
            return _dto;
        }
    }
}