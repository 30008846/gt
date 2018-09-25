using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3
{
    class Program
    {
        static void Main(string[] args)
        {
            car car1 = new car();
            car1.Make = "Toyota";
            car1.Model = "mark x";
            car1.Colour = "Black";
            car1.Rego = "GSD123";

            int[] nums = new int[15];
            car[] carCollection = new car[15];

            Console.WriteLine(car1.Make + car1.Model + car1.Colour + car1.Rego);
            Console.ReadLine();


        }
    }
    class car
    {
        private string make;
        private string model;
        private string colour;
        private string rego;

        public string Make { get { return make; } set { make = value; } }
        public string Model { get { return model; } set { model = value; } }
        public string Colour { get { return colour; } set { colour = value; } }
        public string Rego { get { return rego; } set { rego = value; } }

    }
}
}
