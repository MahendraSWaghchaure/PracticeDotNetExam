namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter which family you want");
            Console.WriteLine("1.Bhosale\n2.Sindhia\n3.Rao");
            int DBChoice= Convert.ToInt32(Console.ReadLine());
            Selector select = new Selector();
            IFamily family= select.GetChoice(DBChoice);

            family.marriage(); 

        }
    }
    public abstract class  IFamily
    {
        protected abstract void Father();
        protected abstract void Mother();
        protected abstract void Son();

        public virtual void marriage()
        {
            Father();
            Mother();
            Son();
        }
    }

    public abstract class IEvent:IFamily
    {
        protected abstract void DaughterInLaw();
        public override void marriage()
        {
            Father();
            Mother();
            Son();
            DaughterInLaw();
        }
    }
    public class Selector
    {
        public IFamily GetChoice(int DBChoice)
        {
            if (DBChoice == 1) return new Bhosale();
            else if (DBChoice == 2) return new Sindhia();
            else if (DBChoice==3) return new Rao();

            else return null;
        }
    }
    public class Bhosale: IFamily
    {
        protected override void Father()
        {
            Console.WriteLine("Iam the King of Family");
        }
        protected override void Mother()
        {
            Console.WriteLine("Iam the Queen of Family");
        }
        protected override void Son()
        {
            Console.WriteLine("Iam the Prince of Family");
        }
    }
    public class Sindhia : IFamily
    {
        protected override void Father()
        {
            Console.WriteLine("Iam the King of Family");
        }
        protected override void Mother()
        {
            Console.WriteLine("Iam the Queen of Family");
        }
        protected override void Son()
        {
            Console.WriteLine("Iam the Prince of Family");
        }
    }
    public class Rao : IEvent
    {
        protected override void Father()
        {
            Console.WriteLine("Iam the King of Family");
        }
        protected override void Mother()
        {
            Console.WriteLine("Iam the Queen of Family");
        }
        protected override void Son()
        {
            Console.WriteLine("Iam the Duke of Family");
        }
        protected override void DaughterInLaw()
        {
            Console.WriteLine("Iam the Duchess of Family");
        }
    }
}
