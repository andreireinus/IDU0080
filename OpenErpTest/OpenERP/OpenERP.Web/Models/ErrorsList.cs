namespace OpenERP.Web.Models
{
    using System.Collections.Generic;
    using System.Linq;

    public class ErrorsList
    {
        public List<string> Messages { get; set; }

        public bool IsError
        {
            get
            {
                return this.Messages.Any();
            }
        }

        public ErrorsList()
        {
            this.Messages = new List<string>();
        }

        public void AddMessage(string message)
        {
            this.Messages.Add(message);
        }
    }
}