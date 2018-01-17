using System;

namespace MyFavoriteThings
{
    class Dogs
    {   
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
    }
     public class Doggie
     {
        public string Name { get; set; }
        public string Breed {get; set;}

     }
        
}

