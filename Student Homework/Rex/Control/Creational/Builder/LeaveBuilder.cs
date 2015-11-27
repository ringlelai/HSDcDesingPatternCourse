using hsdc.dpt.Control.DTO.Creational.Builder;

namespace hsdc.dpt.Control.Creational.Builder
{
    public class LeaveBuilder : IOfficeFormBuilder<Leave>
    {
        private Leave _dto = null;

        public void BuildMaster()
        {
            _dto = new Leave();
        }

        public void BuildDetails()
        {
        }

        public Leave GetResult()
        {
            return _dto;
        }
    }
}