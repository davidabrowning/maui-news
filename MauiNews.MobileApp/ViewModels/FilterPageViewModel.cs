using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiNews.MobileApp.ViewModels
{
    public class FilterPageViewModel : INotifyPropertyChanged
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

        public void RandomizeSearchTerms()
        {
            OnPropertyChanged(nameof(SearchTermA));
            OnPropertyChanged(nameof(SearchTermB));
            OnPropertyChanged(nameof(SearchTermC));
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
