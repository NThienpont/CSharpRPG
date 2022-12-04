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
                if (Live ==0){
                    Console.WriteLine("You are dead!");
                }
                else {
                    string viewlives = string.Concat(Enumerable.Repeat("♥ ",Live));
                    Console.WriteLine(viewlives);
                }
            }
        public void AddLives (int addlive){
            if (Live+addlive >= 10){
                Live = 10; 
            }
            else {
                Live= Live+addlive;
            }
        }
        public void WithdrawLives (int withdrawlive){
            if (Live-withdrawlive <=0){
                Live = 0; 
            }
            else {
                Live= Live-withdrawlive;
            }
        }

    }
}
