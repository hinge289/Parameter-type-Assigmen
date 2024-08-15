namespace Q5
{
    class Question
    {
        public void named(string str,int no,float f)
        {
            Console.WriteLine(str);
            Console.WriteLine(no);
            Console.WriteLine(f);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Question obj = new Question();
            obj.named(no: 19, str: "tejas", f:0.8f);
        }
    }
}
