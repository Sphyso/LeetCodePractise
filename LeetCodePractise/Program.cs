using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodePractise
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();
            /**TwoSum
            int[] nums = { 3,3 };
            int target = 6;

            Console.WriteLine("[{0}]", string.Join(", ", prog.TwoSum(nums, target)));*/


            /**ReversePrefix
            string word = "abcd";
            char ch = 'z';

            Console.WriteLine(prog.ReversePrefix(word, ch));
            */

            /** FindMax
            int[] nums = new int[] { -10, 8, 6, 7, -2, -3 };
            Console.WriteLine(prog.FindMaxK(nums));*/

            /** CompareVersion
            string version1 = "1.01";
            string version2 = "1.001";

            version1 = version1.Replace(".", string.Empty);
            version1 = version1.Replace("0", string.Empty);
            version2 = version2.Replace(".", string.Empty);
            version2 = version2.Replace("0", string.Empty);

            //Console.WriteLine("Ver1: " + version1 + " Ver2: " + version2);
            Console.WriteLine(prog.CompareVersion(version1, version2));
            /*
             * Compare numbers indivdually
             * ver1 7.5.2.4 and ver2 7.5.3 (Version 2 is greater)*/

            /**cbFirst Factorial
            int num = 4;
            Console.WriteLine(FirstFactorial(num));**/

            /** First Reverse
            string str = "Cold Palmer";
            Console.WriteLine(FirstReverse(str));**/

            //13. Roman to Integer
            string s = "III";
            int value = 0;
            Dictionary<string, int> romanDict = new Dictionary<string, int>()
            { {"IV", 4},
              {"IX", 9},
              {"XL", 40},
              {"XC", 90},
              {"CD", 400},
              {"CM", 900},
              {"I", 1},
              {"V", 5},
              {"X", 5},
              {"L", 50},
              {"C", 100},
              {"D", 500},
              {"M", 1000}
            };

            while (s.Length != 0)
            {
                foreach (KeyValuePair<string, int> retrieve in romanDict)
                {
                    if (s.Contains(retrieve.Key))
                    {
                        value += retrieve.Value;
                        s = s.Replace(retrieve.Key, string.Empty);
                    }
                }
            }

            Console.WriteLine(value);

        }

        //

        //Coderbyte First Reverse
        public static string FirstReverse(string str)
        {

            // code goes here
            char[] charArray = str.ToCharArray();

            Array.Reverse(charArray);

            string reversedStr = new string(charArray);
            return reversedStr;

        }

        //Coderbyte First Factorial
        public static int FirstFactorial(int num)
        {
            int factorial = 1;
            while (num > 0)
            {
                factorial *= num;
                num--;
            }
            return factorial;
        }

        //Revisit
        public int NumRescueBoats(int[] people, int limit)
        {
           /** int[] people = { 3, 2, 2, 1 };
            int limit = 3;
            int boatCount = 0;

            for (int i = 0; i < people.Length; i++)
            {
                if (people[i] == limit)
                {
                    boatCount += 1;
                    people.RemoveAt(i);
                }
                else if ((people[i + 1] + people[i]) == limit)
                {
                    boatCount += 1;
                }

            }**/

            return 1;
        }

        public int CompareVersion(string version1, string version2)
        {

            version1 = version1.Replace(".", string.Empty);
            version1 = version1.Replace("0", string.Empty);
            version2 = version2.Replace(".", string.Empty);
            version2 = version2.Replace("0", string.Empty);

            int ver1 = int.Parse(version1);
            int ver2 = int.Parse(version2);

            if(ver1 < ver2)
            {
                return -1;
            }
            else if(ver1 > ver2)
            {
                return 1;
            }
            else
            {
                return 0;
            }
   
        }

        public int FindMaxK(int[] nums)
        {
            Array.Sort(nums);
            Array.Reverse(nums);
            int numsMax = nums.Max();
            int ans = -1;

            foreach (int item in nums)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    int compareValue = nums[i] * -1;
                    if (item == compareValue)
                    {
                        ans = item;
                        ans *= -1;
                        break;
                    }
                }
            }


           return ans;
        }

        public string ReversePrefix(string word, char ch)
        {
            int index = word.IndexOf(ch) + 1;

            string firstPart = word.Substring(0, index);
            string secondPart = word.Substring(index);

            char[] charArray = firstPart.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);

            string reversedPrefix = reversedString + secondPart;

            return reversedPrefix;
        }

        public int[] TwoSum(int[] nums, int target)
        {
            int elementOne;
            int elementTwo;

            int[] solution = new int[2];
            HashSet<int> solutionTest = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int s = 0; s < nums.Length; s++)
                {
                    int sum = nums[i] + nums[s];

                    if (nums[i] != nums[s] && sum == target)
                    {
                        elementOne = Array.IndexOf(nums, nums[i]);
                        elementTwo = Array.IndexOf(nums, nums[s]);

                        solutionTest = new HashSet<int> { elementOne, elementTwo };
                        solutionTest.CopyTo(solution);
                    }

                }
            }

            return solution;

        }
    }
}
