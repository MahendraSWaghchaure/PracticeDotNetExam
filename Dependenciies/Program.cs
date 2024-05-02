namespace Dependenciies
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //NotePad NP= new NotePad("Eng");
           

            SpellFactory spellCheckerFactory = new SpellFactory();
            ISpeellChecker checker = spellCheckerFactory.SpellingChecking("Ger");
            NotePad notepad1 = new NotePad(checker);
            notepad1.checking();
            HindiChecker Hindi = new HindiChecker();
            NotePad NP = new NotePad(Hindi);
            NP.checking();
        }
    }
    public class NotePad
    {
        private ISpeellChecker Checker = null;
        SpellFactory factory= new SpellFactory();
        public NotePad(ISpeellChecker checker)
        {
            if (checker == null)
            {
                Checker = factory.SpellingChecking("Eng");
            }
            else
            {
                Checker = checker;
            }
        }
        public void checking()
        {
            Checker.DoCheck();
        }
    }
    public interface  ISpeellChecker
    {
        void DoCheck();
    }
    public class SpellFactory
    {
        public ISpeellChecker SpellingChecking(string lang)
        {
            ISpeellChecker spellingChecker = null;
            switch(lang) 
            {
                case "Eng": spellingChecker = new EnglishCheck(); break;
                case "Ger": spellingChecker = new GermanCheck(); break;
                case "Fre": spellingChecker = new FrenchCheck(); break;

                default:
                    Console.WriteLine("Selected language is not avialable for spelling check"); break;
            }
            return spellingChecker;
        }
    }
    public class EnglishCheck:ISpeellChecker
    {
        public void DoCheck() { Console.WriteLine("English spell checking complete"); }
    }
    public class GermanCheck:ISpeellChecker
    {
        public void DoCheck() { Console.WriteLine("German Spell checking Complete"); }
    }
    public class FrenchCheck : ISpeellChecker
    {
        public void DoCheck() { Console.WriteLine("French Spell checking Complete"); }
    }
    public class HindiChecker: ISpeellChecker
    {
        public void DoCheck() { Console.WriteLine("Additional Hindi Spell checking Dependency added to check Hindi Spellings"); }
    }

}
