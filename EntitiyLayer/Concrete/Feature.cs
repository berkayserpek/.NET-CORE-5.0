﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Feature // => access modifere public yapıldı.
    {
        [Key]
        public int FeatureID { get; set; }
        public string FeatureHeader { get; set; }
        public string FullName { get; set; }
        public string FeatureTitle { get; set; }
    }
}
