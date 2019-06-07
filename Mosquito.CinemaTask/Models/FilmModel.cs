using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mosquito.CinemaTask.Models
{
    public class FilmModel
    {

        [Required]
        [StringLength(40)]
        public string Name { get; set; }

        [Required]
        [Range(0, 10)]
        public int Rating { get; set; }

        [Required]
        [Range(0.1, 6)]
        public float Duration { get; set; }
    }
}