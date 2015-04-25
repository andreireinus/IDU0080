using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jlob.OpenErpNet.Entities
{
    [OpenErpMap("hr_timesheet_sheet.sheet")]
    public class Sheet
    {
        [OpenErpMap("date_from", OpenErpType.Date)]
        public DateTime DateFrom
        {
            get;
            set;
        }

        [OpenErpMap("date_to", OpenErpType.Date)]
        public DateTime DateTo
        {
            get;
            set;
        }

        [OpenErpMap("employee_id")]
        public int EmployeeId
        {
            get;
            set;
        }

        [OpenErpMap("id")]
        public int Id
        {
            get;
            set;
        }

        [OpenErpMap("user_id")]
        public int UserId
        {
            get;
            set;
        }

        public Sheet()
        {
        }
    }
}
