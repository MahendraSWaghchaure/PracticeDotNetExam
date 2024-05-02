namespace SealedClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SealedClass Sclass = new SealedClass("Mahii wants jobs");
            Sclass.display();
        }
    }
    public sealed class SealedClass
    {
        private string _messege;
        public SealedClass(string messege) 
        {
            _messege = messege;
        }
        public void display() 
        {
            Console.WriteLine(_messege);
        }
    }
}
