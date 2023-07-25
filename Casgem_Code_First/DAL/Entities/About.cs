using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Casgem_Code_First.DAL.Entities
{
    public class About
    {
        public int AboutID { get; set; }
        public string AboutDes { get; set; }
        public string AboutTitle { get; set; }
        public string AboutResim { get; set; }
    }
}