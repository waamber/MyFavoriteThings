using System;

namespace MyFavoriteThings
{
    class Food
    {

        static void Main(string[] args)
        {
            var food = new Food();
            food.Dinner("burritos");
            food.Place("Does McDonald's have both?");  
        }

        protected string _tacos;
        protected string _burgers;
        public string cookOut;


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

        public string Place(string place)
        {
           return place = cookOut;  
        }

        public bool Dinner(string tacos)
        {
            _tacos = tacos;
            return true;
        }

    }
}
