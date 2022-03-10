using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(RevNumber(123));
            
            // Console.WriteLine(System.Int32.MaxValue);
            Console.ReadKey();

        }

        public static int RevNumber(int number)
        {
            //if (number > int.MaxValue || number < int.MinValue)            //{
            //    return 0;
            //}

            //if (Int32.TryParse(x, out int number))
            //{
            //    return 0;
            //}

            var isNegative = false;

            if(number < 0)
            {
                isNegative = true; 
            }

            string numString = Convert.ToString(Math.Abs(number));

            Stack<char> ourStack = new Stack<char>();

            foreach (var x in numString)
            {
                ourStack.Push(x);
            }

            string numStringReverse = "";

            while (ourStack.Count > 0)
            {
                numStringReverse += ourStack.Pop();
            }

            if (Int32.TryParse(numStringReverse, out int reverseInt))
            {
                if (isNegative)
                {
                    reverseInt = reverseInt * -1;
                }

                //Console.WriteLine(reverseInt.GetType());

                return reverseInt;
            }
            else
            {
                return 0;
            }





            // Console.WriteLine(numStringReverse);


        }
    }

    
}
