using System;

namespace MyFavoriteThings
{
    class Food
    {
        protected string _type;
        protected string _name;
        protected string _price;

        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public string IEat(string name, string type, string price)
        {
            return $"I like to eat {name} because I'm a fan of {type}. It's also {price}.";
        }
    }
}
