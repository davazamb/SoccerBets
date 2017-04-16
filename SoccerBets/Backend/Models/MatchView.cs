using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    [NotMapped]
    public class MatchView  : Match
    {
        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        public string DateString { get; set; }
        [DataType(DataType.Time)]
        [Display(Name = "Time")]
        public string TimeString { get; set; }
        [Display(Name = "Local Team")]  
        public int LocalLeagueId { get; set; }
        [Display(Name = "Visitor Team")]
        public int VisitorLeagueId { get; set; }


    }
}