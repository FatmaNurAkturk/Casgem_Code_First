using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Casgem_Code_First.DAL.Entities
{
    public class Iletisim
    {
        public int IletisimID { get; set; }
        public string Address { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string FaceURL { get; set; }
        public string TwitterURL { get; set; }
        public string InsagramURL { get; set; }
        public string MailURL { get; set; }
        public string LinkedinURL { get; set; }
    }
}