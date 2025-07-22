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
            
            Console.WriteLine("The sum of the numbers is: " + Sum(nums));
            Console.WriteLine("The average of the numbers is: " + Average(nums));
        }
        static double Sum(double[] nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            return sum;
        }
        static double Average(double[] nums)
        {
            return (double)Sum(nums) / nums.Length;
        }
    }
}
