using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace TopRestaurants.Models
{
    public class Restaurant
    {
        //Make ranking read only
        public Restaurant(int rank)
        {
            Rank = rank;
        }
        [Required]
        public int Rank { get; }

        [Required]
        public string Name { get; set; }

        public string? FavoriteDish { get; set; }

        [Required]
        public string Address { get; set; }

        //Set default website to coming soon
        public string? Website { get; set; } = "Coming soon.";

        //Validate the phone number
        [Phone]
        public string? PhoneNumber { get; set; } = "##########";

        //Create the restaurants to add
        public static Restaurant[] GetRestaurants()
        {
            Restaurant restaurant1 = new Restaurant(1)
            {
                Name = "Chick-fil-a",
                FavoriteDish = "Chicken Nuggets Kids' Meal",
                Address = "100 N State St.",
                Website = "https://www.chick-fil-a.com",
                PhoneNumber = "5783928573"
            };

            Restaurant restaurant2 = new Restaurant(2)
            {
                Name = "JCW's",
                FavoriteDish = "Guacamole Burger",
                Address = "775 N. University Parkway",
                Website = "https://www.jcws.com/",
                PhoneNumber = "4738275837"
            };

            Restaurant restaurant3 = new Restaurant(3)
            {
                Name = "Sweeto Burrito",
                FavoriteDish = "The Sweeto Burrito",
                Address = "82 N. University Avenue",
                Website = "https://sweetoburrito.com/",
                PhoneNumber = "4738295738"
            };

            Restaurant restaurant4 = new Restaurant(4)
            {
                Name = "Aloha Plate",
                Address = "The Cougar Eat",
                PhoneNumber = "2758374837"
            };

            Restaurant restaurant5 = new Restaurant(5)
            {
                Name = "Bajio",
                Address = "1200 N. University Avenue",
                Website = "https://www.bajiogrillutah.com/",
                PhoneNumber = "2758372938"
            };

            //Return the array of restaurants
            return new Restaurant[] { restaurant1, restaurant2, restaurant3, restaurant4, restaurant5 };
        }
    }
}
