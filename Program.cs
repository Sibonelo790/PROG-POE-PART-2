using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10103125_Memela_S__2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring variable and an object
            double factor;
            Recipe rec = new Recipe();
            int end = 1;
            

            Console.WriteLine("Welcome to the Personal Recipe App! :)");

            while(end != 999)
            {
              
                //Calling the user input method and display method 
                rec.UserInput();
                rec.displayRecipe();
                rec.recipeChoice();

                //Alowing the user to choose whether they want to scale the recipe
                Console.WriteLine("Do you wish to scale your recipe?");
                Console.WriteLine("Enter (1) for Yes or any other number to continue: ");
                int scaleChoice = int.Parse(Console.ReadLine());

                if (scaleChoice == 1)
                {
                    Console.WriteLine("By how much do you want to scale your recipe by?");
                    factor = double.Parse(Console.ReadLine());
                    rec.Factor(factor);
                    rec.displayRecipe();

                    //Allowing the user to choose whether to reset the values back to original
                    Console.WriteLine("Would you like to reset your ingredients quantity to the original values?");
                    Console.WriteLine("Enter (1) for Yes and any other number to continue: ");
                    int resetChoice = int.Parse(Console.ReadLine());
                    if (resetChoice == 1)
                    {
                        rec.BackToOrigin();
                        rec.displayRecipe();
                    }
                }

                //Allowing the user to clear all values of the recipe and enter a new one
                Console.WriteLine("Do you wish to clear all the values in the recipe?");
                Console.WriteLine("Enter (1) for Yes or any other number to continue");
                int clear = int.Parse(Console.ReadLine());
                if (clear == 1)
                {
                    rec.ClearDetails();

                }
                Console.WriteLine("Do you wish to end this program?");
                Console.WriteLine("Enter 1 to continue or 999 to end the program");
                end = int.Parse(Console.ReadLine());
            }
           

            Console.WriteLine("Thank You For Using The Personal Recipe App :)");
            Console.ReadKey();
            
        }
    }
}
