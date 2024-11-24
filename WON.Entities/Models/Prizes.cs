using FerPROJ.Base.ASP.Base.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WON.Entities.Models {
    public class Prizes : BaseEntityModel {
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreatedDate { get; set; }
        public string Status { get; set; }
        public decimal Amount { get; set; }

    }
}
