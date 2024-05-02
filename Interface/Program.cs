namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            first F1= new first();
            Console.WriteLine(F1.Getchild());

            second F2= new second();
            Console.WriteLine(F2.Getchild());
        }
    }
    public interface IMahii
    {
        string Getchild(); 
    }
    public class first : IMahii
    {
        public string Getchild() 
        {
            return "Mahira";
        }
    }
    public class second : IMahii
    {
        public string Getchild() 
        {
            return "Asha";
        }
    }
}
