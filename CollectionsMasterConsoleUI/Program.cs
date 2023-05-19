using System;
using System.Collections.Generic;
using System.Globalization;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] numberArray = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50

            Populater(numberArray);

            //TODO: Print the first number of the array
            Console.WriteLine("First Number: " + numberArray[0]);

            //TODO: Print the last number of the array
            Console.WriteLine("Last Number: " + numberArray[numberArray.Length - 1]);

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            
            Console.WriteLine("-------------------");
            NumberPrinter(numberArray);

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */


            ReverseArray(numberArray);

            Console.WriteLine("All Numbers Reversed: ");

            foreach (int num in numberArray)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("---------REVERSE CUSTOM------------");

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            
             

            Console.WriteLine("Multiple of three = 0: ");
            

            Console.WriteLine("-------------------");
            ThreeKiller(numberArray);

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            
            Console.WriteLine("Sorted numbers:");
            

            Array.Sort(numberArray);
            NumberPrinter(numberArray);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion
            

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List

            List<int> theList = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine($"Capacity: {theList.Capacity}");

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            

            Populater(theList);

            //TODO: Print the new capacity
            Console.WriteLine($"Capacity: {theList.Capacity}");

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!

            int userNumber;
            bool isANumber;

            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                isANumber = int.TryParse(Console.ReadLine(), out userNumber);
            } while (isANumber == false);

            NumberChecker(theList, userNumber);
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(theList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(theList);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");

            theList.Sort();
            NumberPrinter(theList);
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var newArray = theList.ToArray();

            //TODO: Clear the list
            theList.Clear();

            
            

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
          for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                    
                }       
            }
            NumberPrinter(numbers);
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count - 1; i>= 0; i--)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.Remove(numberList[i]);
                }  
            }
            NumberPrinter(numberList);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine("Yes, we have the number you are looking for");
            }
            else
            {
                Console.WriteLine("That number is not available");
            }
            
        }

        private static void Populater(List<int> numberList)
        {
            

            while (numberList.Count < 50)
            {
                Random rng = new Random();
                var numbner = rng.Next(0, 50);

                numberList.Add(numbner);
            }
            NumberPrinter(numberList);

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                numbers[i] = rng.Next(0,50);
            }

        }        

        private static void ReverseArray(int[] array)
        {
         Array.Reverse(array);
            NumberPrinter(array);
            
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
