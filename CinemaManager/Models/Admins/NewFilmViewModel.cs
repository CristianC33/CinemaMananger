using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static CinemaManager.ApplicationLogic.DataModel.Film;

namespace CinemaManager.Models.Admins
{
    public class NewFilmViewModel
    {
        [Required]
        [Display(Name ="ReleaseDate")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Director")]
        public string Director { get; set; }

        [Required(ErrorMessage = "You must use numbers")]
        [Display(Name = "Duration")]
        public int Duration { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 20)]
        [Display(Name = "Description")]
        public string Description { get; set; }
        
        [Required]
        [Display(Name = "Image")]
        public IFormFile Image { get; set; } 

        [Required]
        [Display(Name = "Genre")]
        public GenreCategory Genre { get; set; }

        [Required]
        [Display(Name = "Language")]
        public LanguageCategory Language { get; set; }
    }
}