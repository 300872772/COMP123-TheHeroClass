using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *Author: Md Mamunur Rahman
 * Student ID: 300872772 
 *
 * Date: June 01, 2016
 * Description: This program demonstrates a game charachtar named 'Hero', which has Name, Strength, Speed 
 * and Health properties to be shown to Console. 
 * 
 * 
 * Version: 0.0.4 - created abilityGUI method to displayed abilities to the console graphically
 */

namespace COMP123_TheHeroClass
{
    /**
     * This is the driver class for The Hero Class program that calls Hero class
     * 
     * @class Program
     */ 
    class Program
    {

        static void Main(string[] args)
        {

            //creating new Hero Object and show abilities

            Hero hero = new Hero("Mamun");
            hero.Show();

            Console.WriteLine();

            //show fight and damage status

            hero.Fight();
            Console.WriteLine();

        }
    }
}
