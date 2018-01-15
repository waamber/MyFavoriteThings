using System;

namespace MyFavoriteThings
{
    class Dogs
    {   
        var same = new Dogs("Sam", "Beagle");
        
       
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

        public Dogs(string dogName, string dogBreed)
        {
            Name = dogName;
            Breed = dogBreed;
        }

        public printDogs()
        {
            Console.Write(Dogs.Name);
        }
     }
        
}

