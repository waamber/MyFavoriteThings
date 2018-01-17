using System;

namespace MyFavoriteThings
{
    class Food
    {
        protected string _tacos;
        protected string _burgers;

        public string Burgers
        {
            get
            {
                return _burgers;
            }
            set
            {
                _burgers = value;
            }
        }


        public string Tacos
        {
            get
            {
                return _tacos;
            }
            set
            {
                _tacos = value;
            }
        }
    }
}
