using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dto
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public GenreDto Genre;

        [Display(Name = "Genre")]
        [Required]
        public byte GenreId { get; set; }
        
        [Display(Name = "Release Date")]
        [Required]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Number In Stock")]
        [Required]
        //[NumberInStocRange]
        public byte NumberInStock { get; set; }
    }
}