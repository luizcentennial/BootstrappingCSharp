﻿using System;

namespace CSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
            EXPLORATION EXERCISES - Solutions:

            1) Write a program that prompts the user for the current ambient temperature. If the temperature is lower than 20 degrees,
            display the message "Too cold!". If the temperature is equal to 20, display the message "Good temperature.". If the
            temperature is higher than 20 degrees, display the message "Too warm!".
            */

            Console.WriteLine("What is the current temperature? ");
            double temperature = Convert.ToDouble(Console.ReadLine());

            if (temperature < 20)
            {
                Console.WriteLine("Too cold!");
            }

            if (temperature == 20)
            {
                Console.WriteLine("Good temperature.");
            }

            if (temperature > 20)
            {
                Console.WriteLine("Too warm!");
            }

            /*
            2) Write a program that prompts the user for how many liters of water they drink per day. If the answer is lower than 2 liters,
            display the message "You should drink more water!". If the answer is greater than or equal to 2 liters, display the message "Good!".
            */

            Console.WriteLine("How many liters of water do you drink per day? ");
            double water = Convert.ToDouble(Console.ReadLine());

            if (water >= 2)
            {
                Console.WriteLine("Good!");
            }

            if (water < 2)
            {
                Console.WriteLine("You should drink more water!");
            }

            /*
            3) Write a console application that prompts the user for their gender. If the answer is "male", display the 
            message "Hello, sir.". If the answer is "female", display the message "Hello, madam.".
            */

            Console.WriteLine("What is your gender? ");
            string gender = Console.ReadLine();

            // As we are comparing strings, we must use double quotes "" to specify to the computer that we are talking about 
            // the string "make" or "female". If we don't use double quotes "", the computer will look for a variable 
            // called male and female, and as they do not exist, it will return an error.

            if (gender == "male")
            {
                Console.WriteLine("Hello, sir.");
            }

            if (gender == "female")
            {
                Console.WriteLine("Hello, madam.");
            }
        }
    }
}
