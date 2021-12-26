using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dział2_3
{
    public class CSVUtil
    {
        public static int findMax(string array)
        {
            string[] numStr = array.Split(',');
            List<int> nums = new List<int>();
            foreach(string num in numStr)
            {
                try
                {
                    nums.Add(Int32.Parse(num));
                }catch
                {
                    throw new FormatException();
                }
            }
            int max = nums[0];
            foreach(int num in nums)
            {
                if (max < num)
                    max = num;
            }
            return max;
        }
        public static int findMin(string array)
        {
            string[] numStr = array.Split(',');
            List<int> nums = new List<int>();
            foreach (string num in numStr)
            {
                try
                {
                    nums.Add(Int32.Parse(num));

                }
                catch
                {
                    throw new FormatException();
                }

            }
            int min = nums[0];
            foreach (int num in nums)
            {
                if (num < min)
                    min = num;
            }
            return min;
        }
        public static string sortString(string array)
        {

            string[] numStr = array.Split(',');
            List<int> nums = new List<int>();
            foreach (string num in numStr)
            {
                try
                {
                    nums.Add(Int32.Parse(num));
                }
                catch
                {
                    throw new FormatException();
                }
            }
            string sorted = "";
            int i;
            for (i = 0; i < nums.Count - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < nums.Count; j++)
                {
                    if (nums[j] < nums[minIndex])
                    {
                        minIndex = j;
                    }
                }
                sorted += nums[minIndex].ToString() + ",";
                nums[minIndex] = nums[i];
            }
            sorted += nums[i].ToString();
            return sorted;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz ciag licz odzielonych od siebie przecinkiem");
            string numbers = Console.ReadLine();
            Console.WriteLine("Max="+CSVUtil.findMax(numbers));
            Console.WriteLine("Min="+CSVUtil.findMin(numbers));
            Console.WriteLine("Posortowana: "+CSVUtil.sortString(numbers));
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
