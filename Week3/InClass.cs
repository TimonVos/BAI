using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    internal static class InClass
    {

        public static void Oefening1()
        {
            Stack<char>[] Input = new Stack<char>[6];
            for (int i = 0; i < Input.Length; i++)
            {
                Input[i] = new Stack<char>();
            }


            #region FillingInput
            Input[0].Push('(');
            Input[0].Push(')');

            Input[1].Push('(');
            Input[1].Push('(');
            Input[1].Push('(');
            Input[1].Push('(');
            Input[1].Push('(');
            Input[1].Push(')');
            Input[1].Push(')');
            Input[1].Push(')');
            Input[1].Push(')');
            Input[1].Push('(');
            Input[1].Push(')');
            Input[1].Push(')');

            Input[2].Push(')');
            Input[2].Push('(');
            Input[2].Push(')');

            Input[3].Push('(');
            Input[3].Push('(');
            Input[3].Push(')');
            Input[3].Push('(');
            Input[3].Push(')');
            Input[3].Push('(');
            Input[3].Push(')');
            Input[3].Push('(');
            Input[3].Push(')');
            Input[3].Push(')');

            Input[4].Push('(');
            Input[4].Push('(');
            Input[4].Push('(');
            Input[4].Push('(');
            Input[4].Push('(');

            Input[4].Push(')');
            Input[4].Push(')');
            Input[4].Push(')');
            Input[4].Push(')');
            #endregion

            int AmountOfClosingBrackets = 0;
            int AmountOfOpeningBrackets = 0;

            for (int i = 0; i < Input.Length; i++)
            {
                while (Input[i].Count != 0)
                {
                    char c = Input[i].Pop();
                    if (c == ')')
                    {
                        AmountOfClosingBrackets++;
                    } else if (c == '(')
                    {
                        AmountOfOpeningBrackets++;
                    }
                    
                }
                if (AmountOfClosingBrackets == AmountOfOpeningBrackets)
                {
                    Console.WriteLine("input was valid");
                } else
                {
                    Console.WriteLine("input wasn't valid");
                }
            }
        }

        public static void Oefening2()
        {
            Queue<char> inputQueue = new Queue<char>();
            Queue<char> secondQueue = new Queue<char>();

            Console.Write("input a string: ");
            string inputString = Console.ReadLine();


            for (int i = 0; i < inputString.Length; i++)
            {
                Console.WriteLine(inputQueue.Peek());
            }

            for (int i = 0; i < inputQueue.Count; i++)
            { 
                secondQueue.Enqueue(inputQueue.Dequeue());
            }



            for (int i = 0; i < secondQueue.Count; i++)
            {
                Console.Write(secondQueue.Dequeue());
            }
        }
    }
}
