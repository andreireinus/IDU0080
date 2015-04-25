namespace Jlob.OpenErpNet
{
    public class OpenErpServiceContext
    {
        public IOpenErp OpenErpClient { get; set; }
        public IOpenErpLogin OpenErpLogin { get; set; }
        public string DbName { get; set; }
        public string User { get; set; }
        public string Pwd { get; set; }
        public int UserId { get; set; }
    }
}
