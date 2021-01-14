using System;
using Calculator.Services.Interfaces;

namespace Calculator.Services
{
    public class InputService : IInput
    {
        /// <summary>
        /// Used to get integer input from user
        /// </summary>
        /// <param name="prompt">An instruction for the user on what to input</param>
        /// <returns>An integer</returns>
        public virtual int PromptForInteger(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out var result))
                {
                    return result;
                }
                Console.WriteLine("Sorry, invalid number entered. Try again.");
            }
        }
        /// <summary>
        /// Used to get a char input from user
        /// </summary>
        /// <param name="prompt">An instruction for the user on what to input</param>
        /// <returns>A character</returns>
        public virtual char PromptForOperator(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);

                var key = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if ("-+/*".Contains(key))
                {
                    return key;
                }
                Console.WriteLine("Sorry, invalid number entered. Try again.");
            }
        }
    }
}
