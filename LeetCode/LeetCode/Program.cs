using System;
using System.Collections;
using System.Collections.Generic;

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
            //if (number > int.MaxValue || number < int.MinValue)
            //{
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

        public static bool isValid(string s)
        {
            if (s.Length % 2 != 0)
            {
                return false;
            }

            Hashtable ht = new Hashtable();
            ht.Add('(', ')');
            ht.Add('[', ']');
            ht.Add('{', '}');


            Stack<char> stack = new Stack<char>();
            foreach (var i in s)
            {
                if (i == '(' || i == '[' || i == '{')
                {
                    stack.Push(i);
                }
                else
                {
                    if (stack.Count > 0)
                    {
                        //peek the stack
                        var topChar = stack.Peek();
                        //check value against i
                        //if matches then pop off the stack
                        if ((char)ht[topChar] == i)
                        {
                            stack.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }

                    //else return false
                    else
                    {
                        return false;
                    }
                }
            }
            if (stack.Count > 0)
            {
                return false;
            }
            return true;
        }

        //Given an array of integers nums and an integer target,
        //return indices of the two numbers such that they add up to target.

        //
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

            for(int i = 0; i < nums.Length; i++)
            {
                //var answer = new int[2];
                //check to see if within the dictionary
                //(target - the current num) is there
                if(keyValuePairs.TryGetValue(target - nums[i], out int index))
                {
                    //if it is there then we return the value in the dictionary
                    //and the current i 
                    return new int[] { index, i };
                }
                else if(!keyValuePairs.ContainsKey(nums[i]))
                {
                    //else we add the num value, i to the dictionary
                    keyValuePairs.Add(nums[i], i);
                }
                
                
            }
            return null;


        }

    }

    
}
