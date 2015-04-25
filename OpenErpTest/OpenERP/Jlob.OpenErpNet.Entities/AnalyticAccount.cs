namespace Jlob.OpenErpNet.Entities
{
    [OpenErpMap("account.analytic.account")]
    public class AnalyticAccount
    {
        [OpenErpMap("code")]
        public string Code
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

        [OpenErpMap("complete_name")]
        public string Name
        {
            get;
            set;
        }

        [OpenErpMap("description")]
        public string TermsAndConditions
        {
            get;
            set;
        }
    }
}
