using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        #region [CONSTRUCTORS]

        public MovieFormViewModel()
        {
            this.Id = 0;
        }

        public MovieFormViewModel(IEnumerable<Genre> genres)
        {
            this.Genres = genres;
        }

        #endregion

        public MovieFormViewModel(Movie movie, IEnumerable<Genre> genres)
        {

            this.Id = movie.Id;
            this.Name = movie.Name;
            this.GenreId = movie.GenreId;
            this.ReleaseDate = movie.ReleaseDate;
            this.NumberInStock = movie.NumberInStock;

            this.Genres = genres;
        }


        #region [PROPERTIES]

        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        [Display(Name = "Genre")]
        [Required]
        public byte? GenreId { get; set; }

        [Display(Name = "Release Date")]
        [Required]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Number In Stock")]
        [Required]
        [NumberInStockRange]
        public byte? NumberInStock { get; set; }

        public IEnumerable<Genre> Genres { get; set; }

        #endregion

        public string Title => Id != 0 ? "Edit Movie" : "New Movie";
    }
}