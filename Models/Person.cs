using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpRPG.Models
{
    public class Person
    {
        public Person(string pseudo)
        {
            Pseudo = pseudo;
            Live = 10; 
            View = "☺";
        }

        public string Pseudo { get; set; }
        public double Live {get; private set;}
        public string View { get; private set; }
    
    public void ViewLives (int live){
        string viewlives = new string('♥', live);
            Console.WriteLine(viewlives);
    }

    }
}
