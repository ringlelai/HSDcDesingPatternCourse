using hsdc.dpt.Control.DTO.Creational.Builder;
using hsdc.dpt.Control.DTO.Creational.Builder.Intf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Creational.Builder
{
    public class EOfficeDirector<T>
    {
        public T Construct(OfficeFormBuilder<T> builder)
        {
            builder.BuildMaster();
            builder.BuildDetails();
            return builder.GetResult();
        }
    }

    public class LeaveBuilder : OfficeFormBuilder<Leave>
    {
        private Leave dto = null;
        public void BuildMaster()
        {
            dto = new Leave();
        }

        public void BuildDetails()
        {
        }

        public Leave GetResult()
        {
            return dto;
        }
    }

    public class ApplyExpenseBuilder : OfficeFormBuilder<ApplyExpense>
    {
        private ApplyExpense dto;
        public void BuildMaster()
        {
            dto = new ApplyExpense();
        }

        public void BuildDetails()
        {
            dto.LineItems = new List<ApplyExpenseDetail>()
            {
                new ApplyExpenseDetail {Expense=0,OccureDate=DateTime.Now,ReferenceNumber="" },
                new ApplyExpenseDetail {Expense=0,OccureDate=DateTime.Now,ReferenceNumber="" },
                new ApplyExpenseDetail {Expense=0,OccureDate=DateTime.Now,ReferenceNumber="" }
            };
        }

        public ApplyExpense GetResult()
        {
            return dto;
        }
    }

    public class WeekOvertimeBuilder : OfficeFormBuilder<WeekOvertime>
    {
        private WeekOvertime dto;
        public void BuildMaster()
        {
            dto = new WeekOvertime();
        }

        public void BuildDetails()
        {
            dto.LineItems = new List<WeekOvertimeDetail>()
            {
                new WeekOvertimeDetail {Day="Mon",from=new TimeSpan(18,0,0),to=new TimeSpan(18,0,0) },
                new WeekOvertimeDetail {Day="Tue",from=new TimeSpan(18,0,0),to=new TimeSpan(18,0,0) },
                new WeekOvertimeDetail {Day="Wed",from=new TimeSpan(18,0,0),to=new TimeSpan(18,0,0) },
                new WeekOvertimeDetail {Day="Thu",from=new TimeSpan(18,0,0),to=new TimeSpan(18,0,0) },
                new WeekOvertimeDetail {Day="Fri",from=new TimeSpan(18,0,0),to=new TimeSpan(18,0,0) },
            };
        }

        public WeekOvertime GetResult()
        {
            return dto;
        }
    }
}
