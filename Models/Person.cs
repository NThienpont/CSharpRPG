using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpRPG.Models;

public class Person
{
    public int Life { get; private set; }
    public string View { get; private set; }
    public Weapon Weapon { get; private set; }

    public Person(int life, string view, Weapon weapon)
    {
        Life = life;
        View = view;
        Weapon = weapon;
    }


    public void ViewLifes()
    {
        if (Life == 0)
        {
            Console.WriteLine("You are dead!");
        }
        else
        {
            string viewlifes = string.Concat(Enumerable.Repeat("♥ ", Life));
            Console.WriteLine(viewlifes);
        }
    }
    public void AddLifes(int addlife)
    {
        if (Life + addlife >= 10)
        {
            Life = 10;
        }
        else
        {
            Life = Life + addlife;
        }
    }
    public void WithdrawLifes(int withdrawlife)
    {
        if (Life - withdrawlife <= 0)
        {
            Life = 0;
        }
        else
        {
            Life = Life - withdrawlife;
        }
    }

    public override string ToString()
    {
        return View;
    }

}
