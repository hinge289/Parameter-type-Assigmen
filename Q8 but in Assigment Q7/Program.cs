namespace Q8_but_in_Assigment_Q7
{
    class Question7
    {
        public void dynamic(dynamic value,dynamic name)
        {
            value = "tejas";
            Console.WriteLine(value);
            name = 100;
            Console.WriteLine(name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Question7 obj = new Question7();
            dynamic no = 100099;
            dynamic name  = "kulamkhel";
            obj.dynamic(no,name);
        }
    }
}
