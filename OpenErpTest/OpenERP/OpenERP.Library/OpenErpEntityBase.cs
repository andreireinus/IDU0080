namespace OpenERP.Library
{
    using Jlob.OpenErpNet;

    public class OpenErpEntityBase
    {
        [OpenErpMap("id", OpenErpType.Integer)]
        public int Id { get; set; }
    }
}