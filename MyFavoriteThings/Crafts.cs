using System;

namespace MyFavoriteThings
{
    class Crafts
    {
        static void Main(string[] args)
        {
            var crafts = new Crafts();
        }

        protected string _knitting;
        protected string _crossStitching;

        public string Knitting
        {
            get
            {
                return _knitting;
            }
            set
            {
                _knitting = value;
            }
        }

        public string CrossStitching
        {
            get
            {
                return _crossStitching;
            }
            set
            {
                _crossStitching = value;
            }
        }

        public bool Thread(string thread)
        {
            thread = _crossStitching;
            return true;
        }

        public string Patience()
        {
            return ("This takes time.");
        }
        
    }
}
