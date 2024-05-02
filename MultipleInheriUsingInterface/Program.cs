namespace MultipleInheriUsingInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMahii IM= new childs();
            IM.add(50, 5);
            IM.male();


            IMayuri im = new childs();
            im.add(70, 80);
            im.female();
        }
    }
    public interface IMahii
    {
        void add(int x, int y);
        void male();
    }
    public interface IMayuri
    {
        void add(int x, int y);
        void female();
    }

    public class childs: IMahii, IMayuri
    {
        void IMayuri.add(int x, int y)
        {
            Console.WriteLine("addition of {0} + {1} = {2}", x,y,x+y);
        }
        void IMayuri.female()
        {
            Console.WriteLine(" Iam a daughter of Mahii and Mayuri");
        }
        void IMahii.add(int x, int y) 
        {
            Console.WriteLine("addition of {0} + {1} = {2}", x, y, x + y);
        }
        void IMahii.male()
        {
            Console.WriteLine(" Iam a Son of Mahii and Mayuri");
        }

    }
}
