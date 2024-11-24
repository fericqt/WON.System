using FerPROJ.Base.ASP.Base.EntityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WON.Entities.Models {
    public class Participant : BaseEntityModel {
        public string? Firstname { get; set; }
        public string? Middlename { get; set; }
        public string? Lastname { get; set; }
        public DateTime? DateLastWon { get; set; }
        public string? PrizeLastWon { get; set; }
        public string? Status { get; set; }
    }
}
