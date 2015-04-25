using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jlob.OpenErpNet.Entities
{
    [OpenErpMap("hr.employee")]
    public class Employee
    {
        [OpenErpMap("birthday", OpenErpType.Date)]
        public Nullable<DateTime> Birthday { get; set; }

        [OpenErpMap("id")]
        public int id
        {
            get;
            set;
        }

        [OpenErpMap("identification_id")]
        public string IdentificationNumber
        {
            get;
            set;
        }

        [OpenErpMap("name")]
        public string Name
        {
            get;
            set;
        }

        public string SocialSecutiryNumber
        {
            get;
            set;
        }

        [OpenErpMap("user_id")]
        public Nullable<int> UserId{get;set;}

        [OpenErpForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
