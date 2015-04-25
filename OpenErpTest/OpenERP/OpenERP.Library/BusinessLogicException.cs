namespace OpenERP.Library
{
    using System;

    public class BusinessLogicException : Exception
    {
        public BusinessLogicException(int code, string message)
            : base(message)
        {
            this.Code = code;
        }
        public int Code { get; set; }
    }
}