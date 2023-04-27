using System.Formats.Asn1;

namespace Quiz_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint result = LeastCommonMultiple(13, 6);
            Console.WriteLine("Result = " + result);
        }

        static uint LeastCommonMultiple(uint value1, uint value2)
        {
            uint temp1 = value1;
            uint temp2 = value2;

            while (value1 != value2)
            {
                if (value1 > value2)
                {
                    value1 -= value2;
                }
                else
                    value2 -= value1;
            }
            return (temp1 * temp2) / value1;
        }

        public static int SumOfTwoMaxElements(int[] array)
        {
            int firstMax = 0;
            int secondMax = 0;

            foreach (int i in array)
            {
                if (i > firstMax)
                {
                    secondMax = firstMax;
                    firstMax = i;
                }
                else if (i > secondMax)
                    secondMax = i;
            }

            return firstMax + secondMax;
        }
    }
}