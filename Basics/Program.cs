namespace Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cmath obj = new Cmath();
            obj.sum(10, 20);
            obj.sub(100, 20);
            AdvanceMath advanceMath = new AdvanceMath();
            advanceMath.sum(100, 200);
            advanceMath.sub(180, 20);
            advanceMath.square(20);

            Math math = new Math();
            math.Sum(55, 22);
            math.Sub(24, 12);
            SupAdv SA= new SupAdv();
            SA.sum(565, 56);
            SA.sub(461, 132);
            SA.Square(120);
        }
        public class Cmath
        {
            public void sum(int x, int y)
            {
                Console.WriteLine("Sum of {0} - {1} ={2}", x, y, x + y);
            }
            public void sub(int x, int y)
            {
                Console.WriteLine("Sum of {0} - {1} ={2}", x, y, x - y);
            }
        }
        public class AdvanceMath : Cmath
        {
            public new void add( int x, int y)
            {
                Console.WriteLine("Sum of {0} - {1} ={2}", x, y, x + y);
            }
            public new void sub(int x, int y)
            {
                Console.WriteLine("Sum of {0} - {1} ={2}", x, y, x - y);
            }
            public void square(int x)
            {
                Console.WriteLine("Square of {0}", x*x);
            }
        }
        public class Math
        {
            private int a, b;
            public void Sum(int x, int y)
            {
                this.a = x;
                this.b = y;
                Console.WriteLine("Addition of two numbers{0}", x + y);
            }
            public void Sub(int x, int y)
            {
                this.a = x;
                this.b = y;
                Console.WriteLine("Subtraction of two numbers{0}", x - y);
            }
        }
        public class SupAdv:AdvanceMath
        {
            private int a,b;
            public void Sum(int x, int y)
            {
                this.a = x;
                this.b = y;
                Console.WriteLine("Addition of two numbers{0}", x + y);
            }
            public void Sub(int x, int y)
            {
                this.a = x;
                this.b = y;
                Console.WriteLine("Subtraction of two numbers{0}", x - y);
            }
            public void Square(int x)
            {
                this.a=x;
                Console.WriteLine("Square the number is{0}", x*x);
            }
        }
    }
}
