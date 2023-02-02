/*
 * Author: Jeremy Reyes
 * Course: COMP-003A
 * Purpose: Lecture Activity 3 Code
 */

namespace COMP003A._LectureActivity03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("Conditional (selection) statements");
            Console.WriteLine("****************************************");

            Console.WriteLine("1. single if statement)");
            Console.Write("\tEnter a whole positive number: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            // single if statement
            if (inputNumber % 2 ==0)
            {
                Console.WriteLine("\tinputNumber is even.");
            }

            Console.WriteLine("2. if-else statement");
            //if-else statement
            if  (inputNumber %2 == 0)
            {
                Console.WriteLine("\tinputNumber is even.");
            }
            else
            {
                Console.WriteLine("\tinputNumber is odd.");
            }

            Console.WriteLine("3. nested if statement");
            // nested if statements
            if (inputNumber % 2 == 0)
            {
                Console.WriteLine("\tinputNumber is even.");

                if (inputNumber % 5 == 0)
                {
                    Console.WriteLine("\t\tinputNumber is  also divisible by 5.");
                }
                else
                {
                    Console.WriteLine("\tinputNumber is NOt divisible by 5.");
                }
            }
            else
            {
                Console.WriteLine("\tinputNumber is odd.");
            }

            Console.WriteLine("4. multiple if-else statements");
            // multiple if-else statements
            if (inputNumber % 2 == 0)
            {
                Console.WriteLine("\tinputNumber is divisible by 2.");
            }
            else if (inputNumber % 3 == 0)
            {
                Console.WriteLine("\tinputNumber is dibisible by 3.");
            }
            else if (inputNumber % 5 == 0)
            {
                Console.WriteLine("\tinputNumber is divisible by 5.");
            }
            else if (inputNumber % 7 == 0)
            {
                Console.WriteLine("\tinputNumber is divisible by 7.");
            }
            else
            {
                Console.WriteLine("\tinputNumber is NOT divisible by 2/3/5/7.");
            }

            Console.WriteLine("5. ternary operator");
            string outputMessage = inputNumber % 2 == 0
                ? "\tinputNumber is even."
                : "\tinputNumber is odd.";
            Console.WriteLine(outputMessage);

            /***************************************/

            int randomNumber = new Random().Next(10);
            Console.WriteLine("6. comparison operators");
            Console.WriteLine($"\t{inputNumber} == {randomNumber}: {inputNumber == randomNumber}");
            Console.WriteLine($"\t{inputNumber} != {randomNumber}: {inputNumber != randomNumber}");
            Console.WriteLine($"\t{inputNumber} > {randomNumber}: {inputNumber > randomNumber}");
            Console.WriteLine($"\t{inputNumber} >= {randomNumber}: {inputNumber >= randomNumber}");
            Console.WriteLine($"\t{inputNumber} < {randomNumber}: {inputNumber < randomNumber}");
            Console.WriteLine($"\t{inputNumber} <= {randomNumber}: {inputNumber <= randomNumber}");

            /********************************************/

            Console.WriteLine("7. logical operators");
            Console.WriteLine($"\t{inputNumber} == {randomNumber} && {inputNumber} >= {randomNumber}: " +
                $"{inputNumber == randomNumber && inputNumber >= randomNumber}");
            Console.WriteLine($"\t{inputNumber} == {randomNumber} || {inputNumber} >= {randomNumber}: " +
                $"{inputNumber == randomNumber || inputNumber >= randomNumber}");
            Console.WriteLine($"\t!(true): {!(true)}");

            Console.WriteLine("8. switch statement");
            //switch statement
            switch (inputNumber)
            {
                case 2:
                    Console.WriteLine("\tinputNumber is divisible by 2.");
                    break;
                case 3:
                    Console.WriteLine("\tinputNumber is divisible by 3.");
                    break;
                case 5:
                    Console.WriteLine("\tinputNumber is divisible by 5.");
                    break;
                case 7:
                    Console.WriteLine("\tinputNumber is divisible by 7.");
                    break;
                default:
                    Console.WriteLine("\tinputNumber is NOT divisible by 2/3/5/7.");
                    break;
            }
        }
    }
}