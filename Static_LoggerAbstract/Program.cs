using System.Security.Cryptography.X509Certificates;

namespace Static_LoggerAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the choice of Hostel.\n1.Marigold\n2.Jasmine\n3.Rose\n4.Lotus ");
            int DBChoice= Convert.ToInt32(Console.ReadLine());
            Datafactory datafactory= new Datafactory();
            Hostel hostel = datafactory.GetDatafactory(DBChoice);

            Console.WriteLine("Enter which room you want to enter.\n1Room1\n2.Room2\n3.Room3\n4.Room4.");
            int choice= Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {

                case 1:
                    hostel.Room1();
                    break;
                case 2: hostel.Room2();
                    break;
                case 3: hostel.Room3();
                    break;
                case 4: hostel.Room4();
                    break;
                default:
                    Console.WriteLine("Room is unavailabe");
                    break;
            }
        }
    }
    public abstract class Hostel
    {
        protected Logger logger = null;
        public Hostel()
            {
            logger = Logger.GetLogger();
            }

        public abstract void OfRoom1();
        public abstract void OfRoom2();
        public abstract void OfRoom3();
        public abstract void OfRoom4();
        public abstract string GetHostelDetails();
        public void Room1()
        {
            OfRoom1();
            logger.Log("Insert in " + GetHostelDetails + " Done");
        }
        public void Room2()
        {
            OfRoom2();
            logger.Log("Insert in " + GetHostelDetails + " Done");
        }
        public void Room3()
        {
            OfRoom3();
            logger.Log("Insert in " + GetHostelDetails + " Done");
        }
        public void Room4()
        {
            OfRoom4();
            logger.Log("Insert in " + GetHostelDetails + " Done");
        }


    }
    public class Datafactory
    {
        public Hostel GetDatafactory(int DBChoice)
        {
            if (DBChoice == 1) return new Marigold();
            else if (DBChoice == 2) return new Jasmine();
            else if (DBChoice == 3) return new Rose();
            else if (DBChoice == 4) return new Lotus();
            else return null;
        }
    }
    public class Marigold: Hostel
    {
        public override void OfRoom1()
        {
            Console.WriteLine("Mahii enter into Marigold Room 1");

        }
        public override void OfRoom2()
        {
            Console.WriteLine("Pratik enter into Marigold Room 2");

        }
        public override void OfRoom3()
        {
            Console.WriteLine("Himu enter into Marigold Room 3");

        }
        public override void OfRoom4()
        {
            Console.WriteLine("Kanak enter into Marigold Room 4");

        }
        public override string GetHostelDetails()
        {
            return "Marigold";
        }
    }
    public class Jasmine : Hostel
    {
        public override void OfRoom1()
        {
            Console.WriteLine("Mahii enter into Jasmine Room 1");

        }
        public override void OfRoom2()
        {
            Console.WriteLine("Pratik enter into Jasmine Room 2");

        }
        public override void OfRoom3()
        {
            Console.WriteLine("Himu enter into Jasmine Room 3");

        }
        public override void OfRoom4()
        {
            Console.WriteLine("Kanak enter into Jasmine Room 4");

        }
        public override string GetHostelDetails()
        {
            return "Jasmine";
        }
    }
    public class Rose : Hostel
    {
        public override void OfRoom1()
        {
            Console.WriteLine("Mahii enter into Rose Room 1");

        }
        public override void OfRoom2()
        {
            Console.WriteLine("Pratik enter into Rose Room 2");

        }
        public override void OfRoom3()
        {
            Console.WriteLine("Himu enter into Rose Room 3");

        }
        public override void OfRoom4()
        {
            Console.WriteLine("Kanak enter into Marigold Room 4");

        }
        public override string GetHostelDetails()
        {
            return "Rose";
        }
    }
    public class Lotus : Hostel
    {
        public override void OfRoom1()
        {
            Console.WriteLine("Mahii enter into Lotus Room 1");

        }
        public override void OfRoom2()
        {
            Console.WriteLine("Pratik enter into Lotus Room 1");

        }
        public override void OfRoom3()
        {
            Console.WriteLine("Himu enter into Lotus Room 1");

        }
        public override void OfRoom4()
        {
            Console.WriteLine("Kanak enter into Lotus Room 1");

        }
        public override string GetHostelDetails()
        {
            return "Lotus";
        }
    }
    public class Logger
    {
        private static Logger logger=new Logger();

        private Logger() 
        {
            Console.WriteLine("Logger object is created for first time");
        }
        public static Logger GetLogger() 
        {
            return logger;
        }
        public void Log(string msg)
        {
            Console.WriteLine("Looger msg is {0} at the time of {1}", msg, DateTime.Now.ToString());
        }
    }
}
