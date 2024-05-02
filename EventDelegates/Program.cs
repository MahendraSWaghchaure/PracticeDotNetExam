using EventDelegates;

namespace EventDelegates
{
    public delegate void MyDelgate(int mark);
    internal class Program
    {
        static void Main(string[] args)
        {
            student std = new student();
            Console.WriteLine("Enter your marks");
            int mark= Convert.ToInt32(Console.ReadLine());
            MyDelgate del1 = new MyDelgate(std.onSuccess);
            MyDelgate del2 = new MyDelgate(std.onFailure);
            std.onPass += del1;
            std.onFail += del2;
            std.mark = mark;
        }
    }
    }
    public class student
    {
        public event MyDelgate onPass;
        public event MyDelgate onFail;
        private int _Marks;
        public int mark
        {
            get { return _Marks; }
            set
            {
                _Marks = value;
                if (_Marks >= 35)
                    onPass(_Marks);
                else
                    onFail(_Marks);
            }
        }
        public void onSuccess(int mk) 
        {
            Console.WriteLine(" Your child is pass with marks {0}", mk);
        }
        public void onFailure(int mk)
        {
            Console.WriteLine("Your child is failed with marks {0}", mk);
        }

    }

