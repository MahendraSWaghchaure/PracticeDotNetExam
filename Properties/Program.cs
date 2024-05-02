namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.WriteLine("ID={0}", emp._id);
            emp.Name = "Roony Roy";
            emp.Address = "Nashik";
            Console.WriteLine("ID= {0}, Name={1}, Address={2}", emp._id, emp.Name, emp.Address);
        }
    }
    public class Employee
    {
        private int id=10;
        private string name;
        private string address;

        /*public int _id
        {
            get { return id; }
        }*/
        public int _id
        {
            get
            {
                if (id == 10)
                    id = 100;
                 return id;
            }
            
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                string str= "Mr./Ms."+value;
                name = str;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
    }
}
