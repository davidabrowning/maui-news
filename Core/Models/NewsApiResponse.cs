using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class NewsApiResponse
    {
        public string Status { get; set; }
        public int TotalResults { get; set; }
        public List<Article> Articles { get; set; } = new();
    }
}
