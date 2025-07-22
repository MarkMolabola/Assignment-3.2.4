namespace Assignment_3._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] nums = new double[4];
            Console.WriteLine("Enter the first number: ");
            nums[0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            nums[1] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            nums[2] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the fourth number: ");
            nums[3] = Convert.ToDouble(Console.ReadLine());
            double[] results = SumAndAverage(nums);
            Console.WriteLine("The sum of the numbers is: " + results[0]);
            Console.WriteLine("The average of the numbers is: " + results[1]);
        }
        static double[] SumAndAverage(double[] nums)
        {
            double[] ints = new double[2];
            double sum = 0;
            foreach (double num in nums)
            {
                sum += num;
            }
            double Average = sum / nums.Length;
            ints[0] = sum;
            ints[1] = Average;
            return ints;
        }
    }

}
