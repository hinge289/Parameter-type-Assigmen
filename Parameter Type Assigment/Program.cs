namespace Parameter_Type_Assigment
{
    class Question1
    {
        public void accpectinterger_with_(int n)
        {
            Console.WriteLine("Befour changing "+n);
            n = 0;
        }


        public void accpectinterger_with_ref(ref int num)
        {
            Console.WriteLine("Befour changing variable"+num);
            num = 10;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Question1 obj =new Question1();
            int n = 1000;
            obj.accpectinterger_with_ref(ref n);
            Console.WriteLine("After Changing " + n);

            // pass with call by value 
            int n1 = 100;
            obj.accpectinterger_with_(n1);

        }
    }
}
