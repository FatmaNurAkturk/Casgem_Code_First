using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Casgem_Code_First.DAL.Entities
{
    public class SocialMedia
    {
        public int SocialMediaID { get; set; }
        public string SocialMediaName { get; set; }
        public string SocialMediaUrl { get; set; }
        public int GuideID { get; set; }
        public Guide Guide { get; set; }
    }
}