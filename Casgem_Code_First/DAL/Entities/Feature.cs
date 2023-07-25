using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Casgem_Code_First.DAL.Entities
{
    public class Feature
    {
        public int FeatureID { get; set; }
        public string FeatureDes { get; set; }
        public string FeatureTitle { get; set; }
        public string FeatureImage { get; set; }
        public string Status { get; set; }
    }
}