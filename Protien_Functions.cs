using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calorie_counter
{
    internal class Protien_Functions
    {
        public static void Protien_Cal()
        {
            Console.WriteLine("You are now in the Protien calculator");
            Console.WriteLine("Insert How many grams of protien your food has?");
            int Protien_Intake = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You have inserted {Protien_Intake}g. Is this the correct intake?");
            string User_Input = Console.ReadLine();

            switch (User_Input)
            {
                case "Y":
                    Console.WriteLine($"You have confirmed Your protien intake of {Protien_Intake}g");
                    Protien_Add(Protien_Intake);
                    break;
                default:
                    Protien_Cal();
                    break;
            }
        }


        public static void Protien_Add(int Protien_Intake)
        {
            int num_Protien = Protien_Intake;
            int Daily_Intake = num_Protien + Protien_Intake;
            Console.WriteLine($"Your daily protien intake so far the day is{Daily_Intake}g");
            Function_option();
        }


        public static void Function_option()
        {
            Console.WriteLine("What Would You Like to do now?");
            Console.WriteLine("Press 1 to go back to main menu");
            Console.WriteLine("press 2 to go back to Protien counter function");
            int User_Input = Convert.ToInt32(Console.ReadLine());

            if (User_Input == 1)
            {
                Menu_Control.Main_Menu();
            }
            else if (User_Input == 2)
            {
                Protien_Cal();
            }
            else { Function_option(); }
        }
    }
}