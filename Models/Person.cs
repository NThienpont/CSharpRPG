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
        public int Live {get; private set;}
        public string View { get; private set; }
    
        public void ViewLives (){
            string viewlives = string.Concat(Enumerable.Repeat("♥ ",Live));
            Console.WriteLine(viewlives);
        }
        public void AddLives (int addlive){
            if (Live+addlive > 10){
                Live = 10; 
            }
            Live= Live+addlive;
        }
        public void WithdrawLives (int withdrawlive){
            if (Live-withdrawlive <0){
                Live = 0; 
            }
            Live= Live-withdrawlive;
        }

    }
}
