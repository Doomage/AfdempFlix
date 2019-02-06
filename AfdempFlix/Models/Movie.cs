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
        public string Title{ get;set;}
        public string Description { get; set; }
        public Genre Genre { get; set; }
        public int Duration { get; set; }
        [Display(Name = "Trailer Url")]
        public string TrailerUrl { get; set; }
        [Display(Name = "ThumbNail Url")]
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