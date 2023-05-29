using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10103125_Memela_S__2_
{
    class Recipe
    {
        //Declaring variables 
        private string ingrName, unit, recipeName, foodGroup;
        private double originalQuantity;
        private double quantity;
        private int done = 0;
        private int calorieCount;
        List<string> ingredient = new List<string>();
        List<string> step = new List<string>();
        List<string> recipe = new List<string>();
        

        public Recipe()
        {
            
        }

        //Defining a delegate type
        public delegate void CalorieAlert(string msg);

        //Defining a member variable of the delegate
        private CalorieAlert calorieMsg;

        
        public void UserInput()
        {
            //Accepting ingredients and steps of the recipe from user
            Console.WriteLine("Please enter the required ingredients: ");
            do
            {
                int v = 0;
                 
                Console.Write($"Ingredient {v + 1}: ");
                Console.WriteLine("Name of ingredient: ");
                ingrName = Console.ReadLine();

                Console.WriteLine("Unit of measurement (just press enter for things such as eggs): ");
                unit = Console.ReadLine();

                Console.WriteLine("Quantity: ");
                quantity = int.Parse(Console.ReadLine());

                Console.WriteLine("Calories in {0}: ", ingrName);
                calorieCount = int.Parse(Console.ReadLine());
                calorieCount += calorieCount;

                Console.WriteLine("In which food group does {0} belong to?", ingrName);
                foodGroup = Console.ReadLine();

                ingredient.Add($"{quantity} {unit} of {ingrName}\n" + $"Calories: {calorieCount}\n" + $"Food Group: {foodGroup}");
                v++;

                Console.WriteLine("Please enter the name of your recipe");
                recipeName = Console.ReadLine();
                Console.WriteLine("Please enter the steps of the recipe: ");
                foreach (string i in step)
                {
                    
                    step.Add(Console.ReadLine());
                    
                }

                recipe[v] = $"{recipeName}\n" + $"{ingredient[v]}\n" + $"{step[v]}";


                //Unit test of the calories of the recipe and notification via delegate
                TestCalories(calorieCount);

                Console.WriteLine("Enter 999 to finish entering recipes or 1 to continue");
                done = int.Parse(Console.ReadLine());

            } while (done != 999);
            

            
        }

        //Unit test of the calories of the recipe
        public void TestCalories(int calories)
        {
            //Invoking the delegate to display a message.
            if(calories > 300)
            {
                calorieMsg?.Invoke("Calories exceed recommended limit of 300 calories.");
                Console.ReadKey();
            }
            else
            {
                calorieMsg?.Invoke("Calories are within the recommended limit"); 
                Console.ReadKey();
            }
        }

        //Displaying the recipe in a neat format
        public void displayRecipe()
        {
            recipe.Sort();
            foreach(string i in recipe)
            {
                Console.WriteLine(i);
                Console.ReadKey();
            }
            Console.ReadKey();
          
        }

        //User gets to enter which recipe they want to be displayed
        public void alphaOrder()
        {
            Console.WriteLine("Please enter which recipe you would like to view: ");
            string recipeView = Console.ReadLine();
            int index = recipe.FindIndex(recName => recName == recipeView);
            Console.WriteLine(recipe[index]);
            Console.ReadKey();
        }
            

        //Allowing user to scale the quantity in the recipe
        public void Factor(double factor)
        {
            originalQuantity = quantity;
            quantity *= factor;
            
            foreach(string i in ingredient)
            {
                
                ingredient.Add($"{quantity} {unit} of {ingrName}");
                
            }

        }

        //Resetting the quantity values to the initially assigned values
        public void BackToOrigin()
        {
            quantity = originalQuantity;

            foreach(string i in ingredient)
            {
                
                ingredient.Add($"{quantity} {unit} of {ingrName}");
                
            }

        }

        //Clearing all values in the both arrays
        public void ClearDetails()
        {
            
            foreach (string i in ingredient)
            {
                
                i = null;
                
            }

            foreach (string i in step)
            {
                
                i = null;
                
            }



            Console.WriteLine("Do you want to enter a new recipe?");
            Console.WriteLine("Enter: (1) for Yes or (2) for No");
            int choice = int.Parse(Console.ReadLine());
           

            switch (choice)
            {
                case 1:
                    UserInput();
                    displayRecipe();
                    break;

                case 2:
                    Console.WriteLine("Thank you for using the Personal Recipe App!");
                    break;

                default:
                    break;
            }
            
        }
    }
}

