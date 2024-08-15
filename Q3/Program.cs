using System.Diagnostics.CodeAnalysis;

namespace Q3
{
    class Question
    {
        public int  paramsdemo(params int[]arr)
        {
            
          
            int sum = 0;
            for (int i = 0;i < arr.Length;i++)
            {
              
                sum=sum+arr[i];
            }
            int no= arr.Length;
            int avg = sum / no;
            return avg;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Question obj = new Question();
            int x=obj.paramsdemo(1,4,5,67,8,4,3,2,45,6,35,36355);

            Console.WriteLine("Average is = " +x );
        }
    }
}
