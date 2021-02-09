using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopRestaurants.Models
{
    public static class TempStorage
    {
        //Create a list of suggestion
        private static List<Suggestion> suggestions = new List<Suggestion>();

        //Create the iEnumberable of suggestions
        public static IEnumerable<Suggestion> Suggestions => suggestions;

        //Add the new suggestion to the list
        public static void SuggestRestaurant(Suggestion suggestion)
        {
            suggestions.Add(suggestion);
        }
    }
}
