using System.ComponentModel;

namespace Override
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Parent to parent error case
            Func1 f1 = new Func1();
            f1.sum(10, 20);
            f1.sub(10, 20);
            #endregion

            #region Parent to child error case
            Func1 f2 = new Func2();
            f2.sum(40, 30);
            f2.sub(40, 30);
            #endregion

            #region child to parent error case
            Func2 f3 = new Func2();
            f3.sum(100, 200);
            f3.sub(100, 200);
            #endregion

            #region child to parent error case
            //Func2 f4 = new Func1();
            //f4.sum(10, 20);
            //f4.sub(10, 20);
            #endregion
        }


    }
    public  class Func1
    {
        public virtual void sum(int x, int y )
        {
            Console.WriteLine("Sum is{0}",x+y);
        }
        public virtual void sub(int x, int y)
        {
            Console.WriteLine("Sun is {0}",y-x);
        }
    }
    public class Func2:Func1
    {
        public override void sum(int x, int y)
        {
            Console.WriteLine("Sum is{0}", x + y );
        }
        public override void sub(int x, int y)
        {
            Console.WriteLine("Sun is {0}", y - x);
        }
    }
}
