using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Interview
{
    public class Post
    {
        private Dictionary<string, Gamer> gamerList = new Dictionary<string, Gamer>();
        public string Title { get; set; }
        public string Description { get; set; }

        private int _rating;
        public int Rating
        {
            get => _rating;
            set
            {
                if (value > 5)
                    _rating = 5;
                else
                    _rating = value;
            }
        }

        public Gamer this[string key]
        {
            get
            {
                try
                { return gamerList[key]; }
                catch { return null; }
            }

            set
            {
                try { gamerList[key] = value; }
                catch { gamerList.Add(key, value); }                    
            }
        }
    }
}