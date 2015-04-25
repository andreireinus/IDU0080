using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jlob.OpenErpNet.Entities
{
    [OpenErpMap("hr.attendance")]
    public class Attendance
    {
        public const string Sign_in = "sign_in";

        public const string Sign_out = "sign_out";

        [OpenErpMap("action")]
        public string Action
        {
            get;
            set;
        }

        [OpenErpMap("name", OpenErpType.Char)]
        public DateTime Date
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

        public Attendance()
        {
        }
    }
}
