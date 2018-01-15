using System;

namespace MyFavoriteThings
{
    class Food
    {
    
        var salsa = new FoodType(hispanic);
      
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

       public FoodType(string foodType)
       {
           Type = foodType;     
       }
       
       public printFood(string food)
       {
           Console.WriteLine(food);
       }

   


    }
}
