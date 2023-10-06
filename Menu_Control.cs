using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calorie_counter
{
    class Menu_Control
    {
        public static void Main_Menu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Press 1 to access calorie count");
            Console.WriteLine("Press 2 to access protien intake calculator");
            int User_intput = Convert.ToInt32(Console.ReadLine());

            switch(User_intput)
            {
                case 1:
                    // call the calorie count method
                    Console.WriteLine("calore count method!");
                    Calorie_Functions.Calorie_input();
                    break;

                case 2:
                    //call the protien intake calculaor method
                    Console.WriteLine("protien intake calculator");
                    Protien_Functions.Protien_Cal();
                    break;
                case 3:
                    //figue out what your calorie weight should be
                    Console.WriteLine("calorie amount function");
                    break;
                default:
                    Main_Menu();
                    break;
            }
            
            
        }

       
                
        
    }
}
