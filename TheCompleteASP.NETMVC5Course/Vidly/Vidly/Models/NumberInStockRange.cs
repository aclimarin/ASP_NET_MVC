using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class NumberInStockRange: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;

            if (movie!= null && (movie.NumberInStock < 1 || movie.NumberInStock > 20))
                return new ValidationResult("The field Number In Stock must be between 1 and 20");
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}