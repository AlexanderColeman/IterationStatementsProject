using System;
using System.Collections.Generic;
using System.Text;

namespace IterationStatements
{
    public class MethodsWithLoopsAndConditionals
    {

        public void NegativeToPositive()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        public void By3()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        public void isEqual(int x, int y)
        {
            if (x == y)
            {
                Console.WriteLine($"{x} is equal to {y}");
            }
            else
            {
                Console.WriteLine($"{x} is not equal to {y}");
            }
        }

        public void IsEvenOrOdd()
        {
            Console.Write("Enter a number to see if it is even or odd ");
            var number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even");
            }
            else
            {
                Console.WriteLine($"{number} is odd");
            }
        }

        public void IsPostiveOrNegative()
        {
            Console.Write("Enter a number to see if it is postive or negative ");
            var number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine($"{number} is postive");

            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} is negative");
            }
            else
            {
                Console.WriteLine($"Your number is {number} neither postive or negative");
            }


        }

        public void VotingAgeCheck()
        {
            Console.Write("Enter your age and see if you can vote ");
            var userAge = int.Parse(Console.ReadLine());

            if(userAge >= 0 && userAge < 18)
            {
                Console.WriteLine("You are not old enough to vote");
            }
            else if (userAge >= 18 && userAge <= 125)
            {
                Console.WriteLine("You are old enough to vote");
            }
            else
            {
                Console.WriteLine("Not a valid age");
            }
        }

        public void IsInRange()
        {

            Console.Write("Enter a number to see if it is in range of -10 to 10 ");
            var userNumber = int.Parse(Console.ReadLine());

            if(userNumber >= -10 && userNumber <= 10)
            {
                Console.WriteLine($"{userNumber} is within range");
            }
            else
            {
                Console.WriteLine($"{userNumber} is not within range");
            }

        }

        public void MultiplicationTable()
        {
            Console.Write("Enter a number from 1 to 12 to see its multiplication table ");
            var userNumber = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= 12; i++)
            {
                sum = userNumber * i;
                Console.WriteLine($"{userNumber} * {i} is: {sum}");
            }
        }


    }
}
