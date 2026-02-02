using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiNews.MobileApp.ViewModels
{
    public class FilterPageViewModel
    {
        public string SearchTermA { get { return GetRandomSearchTerm(); } }
        public string SearchTermB { get { return GetRandomSearchTerm(); } }
        public string SearchTermC { get { return GetRandomSearchTerm(); } }

        private List<string> SearchTerms = new() { "Health", "Sports", "NYC", "Stockholm", "Trump", "Mamdani", "Apple",
        "Google", "ChatGPT", "AI", "Basketball", "Tech", "Literature", "Programming", "Music", "Piano", "Kristersson",
        "Water", "Epidemics", "Influensa", "Covid", "Bicycles", "Cars", "Cooking", "Food", "Games", "Coffee",
        "Pasta", "China", "Australia", "India", "Sweden", "France", "Stoicism", "Snow", "Handwriting", "Art" };

        private string GetRandomSearchTerm()
        {
            int min = 0;
            int max = SearchTerms.Count;
            Random rand = new();
            int index = rand.Next(min, max);
            return SearchTerms.ElementAt(index);
        }
    }
}
