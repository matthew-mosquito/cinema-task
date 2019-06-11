using System.ComponentModel.DataAnnotations;


namespace Mosquito.CinemaTask.Models
{
    public class FilmModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Name { get; set; }

        [Required]
        [Range(0, 10)]
        public double Rating { get; set; }

        [Required]
        [Range(0.1, 6)]
        [Display(Name="Duration (hours)")]
        public double Duration { get; set; }
    }
}