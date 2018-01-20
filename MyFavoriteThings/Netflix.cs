using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteThings
{
    class Netflix
    {
        protected string _title;
        protected string _genre;

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }

        public string Genre
        {
            get
            {
                return _genre;
            }
            set
            {
                _genre = value;
            }
        }

        public string Watch(string genre, string title)
        {
            return $"When I'm Netfilx and chillin with my doge, I usually watch {genre}, mostly likely {title}.";
        }
    }
}
