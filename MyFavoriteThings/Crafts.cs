using System;

namespace MyFavoriteThings
{
    class Crafts
    {
        static void Main(string[] args)
        {
            var crafts = new Crafts();
            Crafts.crafts("Amber");
            Console.ReadKey();
        }

        protected string _knitting;
        protected string _crossStitching;

        public string Knitting
        {
            get
            {
       
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

       public Crafts(string name)
        {
            Name = name;
        } 

        public Crafts(string name)
            {
              Console.WriteLine(name);
            }

      
        
    }
}
