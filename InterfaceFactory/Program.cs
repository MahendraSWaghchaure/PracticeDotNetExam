namespace InterfaceFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the typr of file you want:");
            Console.WriteLine("1.PDF\n 2.TXT\n 3.XML");
            int DBChoice = int.Parse(Console.ReadLine());
            DataBaseFactory Datafactory = new DataBaseFactory();
            IDatabase IDB = Datafactory.GetDBChoice(DBChoice);
           // if (IDB != null)
                Console.WriteLine(" Enter the choice of operation");
            Console.WriteLine("1.Insert\n2.Update\n3.Delete");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1: IDB.Insert(); break;
                case 2: IDB.Update(); break;
                case 3: IDB.Delete(); break;

                default: Console.WriteLine("Invalid Entry"); break;
            }
        }
        //}
    }

    public interface IDatabase 
    {
        void Insert();
        void Update();
        void Delete();

    };
   

    public class DataBaseFactory
    {
        public IDatabase GetDBChoice( int DBChoice)
        {
            if (DBChoice == 1)
                return new PDF();
            else if (DBChoice == 2)
                return new TXT();
            else if (DBChoice == 3)
                return new XML();
            else
                return null;
        }
    }

    public class PDF: IDatabase
    {
        public void Insert()
        {
            Console.WriteLine("The text of PDF is Inserted");
        }
        public void Update()
        {
            Console.WriteLine("The text of PDF is Updated");
        }
        public void Delete()
        {
            Console.WriteLine("The text of PDF is Deleted");
        }

       
    }
    public class TXT : IDatabase
    {
        public void Insert()
        {
            Console.WriteLine("The text of TXT is Inserted");
        }
        public void Update()
        {
            Console.WriteLine("The text of TXT is Updated");
        }
        public void Delete()
        {
            Console.WriteLine("The text of TXT is Deleted");
        }
    }
    public class XML : IDatabase
    {
        public void Insert()
        {
            Console.WriteLine("The text of XML is Inserted");
        }
        public void Update()
        {
            Console.WriteLine("The text of XML is Updated");
        }
        public void Delete()
        {
            Console.WriteLine("The text of XML is Deleted");
        }

    }
    public class Extra : IDatabase
    {
        public void Insert()
        {
            Console.WriteLine("The text of Extra is Inserted");
        }
        public void Update()
        {
            Console.WriteLine("The text of Extra is Updated");
        }
        public void Delete()
        {
            Console.WriteLine("The text of Extra is Deleted");
        }
       
    }
}
