using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileIO_Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\.net\PracticeDotNet\FileIO_Serialization\streamwriter.txt";
            FileStream fs = new FileStream(path,FileMode.Append, FileAccess.Write             );
            StreamWriter sw= new StreamWriter( fs );
            /* Console.WriteLine(" Enter your text");
             string txt= Console.ReadLine();
             sw.WriteLine(txt);
             sw.AutoFlush = true;
             sw.Close();
             fs.Close();
             Console.WriteLine("Done");*/


            /* FileStream fs1 = new FileStream(path, FileMode.Open, FileAccess.Read );
             StreamReader SR= new StreamReader( fs1 );
             Console.WriteLine("Your enter text read in console is :");
             string reads= SR.ReadToEnd();
             Console.WriteLine(reads);*/
            #region nonserialize
            /*Student student = new Student();
            student.ID = 1;
            student.Name = "Mahii";
            student.Address = "Nashik";
            sw.WriteLine( student );
            sw.AutoFlush = false;
            sw.Close();
            fs.Close();
            Console.WriteLine("Done");*/
            #endregion

            #region binary formatter
            Student student = new Student();
            ArrayList arrayList = new ArrayList();
            {
                new Student() { ID = 01, Name = "Mahii", Address = "Nashik" };
            }
            BinaryFormatter BF = new BinaryFormatter();
            BF.Serialize(fs, arrayList);

            ArrayList arr= BF.Deserialize(fs) as ArrayList;
            foreach(var i in arr) { }
            fs.Close();

            #endregion

        }
    }
    
    public class Student
    {
        private int id;
        private string name;
        private string address;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
    }
}
