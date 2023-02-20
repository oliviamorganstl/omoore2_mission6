using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Threading.Tasks;

namespace omoore2_mission6.Models
{
    public class AddResponse
    { //Connects the form to the actual database specifics
        [Key]
        [Required]
        public int MovieID { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        [Range(1900, 2500)]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string Lent { get; set; }
        [MaxLength(25)]
        public string Notes { get; set; }        
        [Required]
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }

}
