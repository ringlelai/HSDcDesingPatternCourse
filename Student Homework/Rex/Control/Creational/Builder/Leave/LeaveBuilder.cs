namespace hsdc.dpt.Control.Creational.Builder.Leave
{
    public class LeaveBuilder : IOfficeFormBuilder<DTO.Creational.Builder.Leave>
    {
        private DTO.Creational.Builder.Leave _dto = null;

        public void BuildMaster()
        {
            _dto = new DTO.Creational.Builder.Leave();
        }

        public void BuildDetails()
        {
        }

        public DTO.Creational.Builder.Leave GetResult()
        {
            return _dto;
        }
    }
}