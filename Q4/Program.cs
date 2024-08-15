namespace Q4
{
    class Question4
    {
        public int area_of_rectangle(int length,int width=10)
        {
            int area=length*width;
            return area;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Question4 obj = new Question4();
            int x = obj.area_of_rectangle(20);
            Console.WriteLine("Area of Rectangle "+x);
        }
    }
}
