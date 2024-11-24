using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WON.Models {
    public class ParticipantModel {
        public Guid Id { get; set; }
        public string? Firstname { get; set; }
        public string? Middlename { get; set; }
        public string? Lastname { get; set; }
        public DateTime? DateLastWon { get; set; }
        public string? PrizeLastWon { get; set; }
        public string? Status { get; set; }
    }
}
