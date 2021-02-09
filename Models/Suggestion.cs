using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TopRestaurants.Models
{
    public class Suggestion
    {
        public string Name { get; set; }

        [Required]
        public string RestaurantName { get; set; }

        public string FavoriteDish { get; set; }

        //Verify that phone number is in a valid format
        [Phone]
        public string PhoneNumber { get; set; }

        //return a list of suggestions when the method is called
        public static Suggestion[] GetSuggestions()
        {
            return new Suggestion[] { null };
        }
    }
}
