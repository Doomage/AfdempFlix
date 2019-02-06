using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AfdempFlix.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Title Required !!")]
        public string Title{ get;set;}
        
        public string Description { get; set; }
        public Genre Genre { get; set; }
        [Required(ErrorMessage = "Duration Required !!")]
        public int Duration { get; set; }
        [Display(Name = "Trailer Url")]
        [Required(ErrorMessage = "Trailer Required !!")]
        public string TrailerUrl { get; set; }
        [Display(Name = "ThumbNail Url")]
        [Required(ErrorMessage = "ThumbNail Required !!")]
        public string ThumbnailUrl { get; set; }

    }

    public enum Genre
    {
        Action,
        Horror,
        [Display(Name = "Science Fiction")]
        ScienceFiction,
        Comedy,
        Drama
    }
}