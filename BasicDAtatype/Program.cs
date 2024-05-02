namespace BasicDAtatype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number :");
            // ref to value type convertion - Unboxing
            int x = Convert.ToInt32(Console.ReadLine());
            int y = x;
            int j = 10;
            double d = 23.33;
            j = (int)d;
            Console.WriteLine(j);

            // value type to ref type convertion - Boxing
            string str = Convert.ToString(y);
            Console.WriteLine(str);
            string greet = "Hi";
            Object obj = greet; //Type-Casting
            string greetAgain = obj.ToString();//Type-Casting
            Console.WriteLine(greetAgain);                                  // String str1 = new String();        }
        }
    }
}
