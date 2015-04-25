namespace Jlob.OpenErpNet.Entities
{
    [OpenErpMap("res.users")]
    public class User
    {
        [OpenErpMap("id")]
        public int  Id { get; set; }

        [OpenErpMap("login")]
        public string Login { get; set; }
    }
}
