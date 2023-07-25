using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Casgem_Code_First.DAL.Entities
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string NameSurname { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime MessageDate { get; set; }
    }
}