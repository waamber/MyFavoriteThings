using System;

namespace MyFavoriteThings
{
    class Dogs
    {
        static void Main(string[] args)
        {
            var dog = new Dogs();
        }

        protected string _puggys;
        protected string _terriers;

        public string Puggys
        {
            get
            {
                return _puggys;
            }
            set
            {
                _puggys = value;
            }
        }

        public string Terriers
        {
            get
            {
                return _terriers;
            }
            set
            {
                _terriers = value;
            }
        }

        public bool Type(string goodBoy)
        {
            return true;
        }

        public bool Name(string name)
        {
            _puggys = name;
            return false;
        }
    } 
}

