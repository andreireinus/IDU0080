using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jlob.OpenErpNet.Entities
{
    [OpenErpMap("hr.analytic.timesheet")]
    public class Timesheet
    {
        [OpenErpMap("account_id")]
        public int Contract
        {
            get;
            set;
        }

        [OpenErpMap("date", OpenErpType.Date)]
        public DateTime Date
        {
            get;
            set;
        }

        [OpenErpMap("name")]
        public string Description
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

        [OpenErpMap("journal_id")]
        public Nullable<int> JournalId
        {
            get;
            set;
        }

        [OpenErpMap("sheet_id")]
        public int SheetId
        {
            get;
            set;
        }

        [OpenErpMap("unit_amount")]
        public double TotalTime
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

        public Timesheet()
        {
        }
    }
}
