namespace Question_2
{
    class Question2
    {
        public void accpect_value_Out(out int sum)
        {
            int a;
            int b;
            a=int.Parse(Console.ReadLine());
            b=int.Parse(Console.ReadLine());
            sum = a + b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Question2 obj = new Question2();
            int s;
            
            obj.accpect_value_Out(out s);
            Console.WriteLine("Sum ="+s);
        }
    }
}
