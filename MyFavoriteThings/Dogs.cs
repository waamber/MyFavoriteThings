using System;

namespace MyFavoriteThings
{
    class Dogs
    {   
        protected string _breed;
        protected string _name;
        protected bool _goodDoge;

        public string Breed
        {
            get
            {
                return _breed;
            }
            set
            {
                _breed = value;
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
        
        public bool GoodDoge
        {
            get
            {
                return _goodDoge;
            }
            set
            {
                _goodDoge = value;
            }
        }

        public string HiDoggie(string breed, string name, bool goodDoge)
        {
            if(goodDoge == true)
            {
                return $"{name} is a {breed} and he is the very best boy.";
            }
            return $"{name} is a {breed} and he is such a naughty boy.";
        }
    }     
}

