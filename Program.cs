using System;

namespace Exercise75
{
    class Program
    {
        static void Main(string[] args)
        {
           

           
            float n;
            float perfectSquare = 0;
            string response;

            Console.WriteLine("Let's calculate the square root of a perfect square!");
            do
            {
                do
                {
                    Console.WriteLine("Please enter a perfect square: ");

                    n = float.Parse(Console.ReadLine());


                    for (float i = 1; (i * i) <= n; i++)
                    {
                        if ((i * i) == n)
                            if ((n % i == 0) && (n / i == i))
                            {
                                perfectSquare = n;
                            }
                            else
                            {

                                Console.WriteLine($"Sorry, {n} is not a perfect square. \n Please try again.");
                            }
                    }
                } while (perfectSquare != n);


                float x = n;
                float y = 1;
                while (x > y)
                {
                    x = (x + y) / 2;
                    y = n / x;
                }
                Console.WriteLine($"The square root of {n} is {x}." +
                            "\nWould you like to try another number?");
                response = Console.ReadLine().ToLower();

            } while (response == "y");
        }
    }
            
    }


//Babylonian Method For Square Root
// 1- Start with an arbitrary positive start value x (rough guess on square).
// 2- Initialize y = 1.
// 3- Do following until desired approximation is achieved.
//    a) Get the next approximation for root using average of x and y
//    b) Set y = n / x


//The Babylonian square-root algorithm
//The iterative method is called the Babylonian method for finding square roots, or sometimes Hero's method. 

//Suppose you are given any positive number S. To find the square root of S, do the following:

//Make an initial guess.Guess any positive number x0.
//Improve the guess.Apply the formula x1 = (x0 + S / x0) / 2.The number x1 is a better approximation to sqrt(S).
//Iterate until convergence.Apply the formula xn+1 = (xn + S / xn) / 2 until the process converges.
//Convergence is achieved when the digits of xn+1 and xn agree to as many decimal places as you desire.


//Let's use this algorithm to compute the square root of S = 20 to at least two decimal places.
//An initial guess is x0 = 10.
//Apply the formula: x1 = (10 + 20 / 10) / 2 = 6.The number 6 is a better approximation to sqrt(20).
//Apply the formula again to obtain x2 = (6 + 20/6)/2 = 4.66667. The next iterations are x3 = 4.47619 and x4 = 4.47214.
//Because x3 and x4 agree to two decimal places, the algorithm ends after four iterations.An estimate for sqrt(20) is 4.47214.

//float n = number to find square root of, n = 20
//float x = random number to help find square root, x = 10 (n/2 for efficinency)
//Break equation ((x + (n/x))/2) into 2 separate pieces x & y (can pull out n/x)
// x = (x + (y)) / 2
// y = (n/x)
//re-run equation until within (2 or 3) decimal places.

