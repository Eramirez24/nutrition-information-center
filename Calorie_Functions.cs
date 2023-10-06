using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calorie_counter
{
    public class Calorie_Functions
    {
        public static int Calorie_input()
        {
            Console.WriteLine("What is your calorie limit for the day?");
            int Cal_Limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your calorie limit is {Cal_Limit} calories. Is this correct?(Y/N)");
            string User_Input = Console.ReadLine();

            switch (User_Input)
            {
                case "Y":
                    Console.WriteLine($"You have confirmed the your calorie limit of {Cal_Limit} Calories");
                    Calorie_count(Cal_Limit);
                    break;
                default:
                    Calorie_input();
                    break;
            }

            return Cal_Limit;
        }

        public static int Calorie_count(int Cal_Limit)
        {
            Console.WriteLine("How many calories have you had today?");
            int Cal_Count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your calorie intake is {Cal_Count} calories is this correct?(Y/N)");
            string User_Input = Console.ReadLine();

            switch(User_Input)
            {
                case "Y":
                    Console.WriteLine($"You have confirmed the calore intake of {Cal_Count} calories");
                    Calorie_def(Cal_Count, Cal_Limit);
                    break;
                default:
                    Calorie_count(Cal_Limit);
                    break;
            }
            return Cal_Count;
        }

        

        public static void Calorie_def(int Cal_Count, int Cal_Limit)
        {
            Console.WriteLine($"Your calorie intake is {Cal_Count} and your cal limit for the day is {Cal_Limit}");
            int Cal_Def = Cal_Limit - Cal_Count;
            Console.WriteLine($"Your remainder of calories for the day is {Cal_Def} calories!");
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
                Calorie_input();
            }
            else { Function_option(); }
        }
    } 
}
