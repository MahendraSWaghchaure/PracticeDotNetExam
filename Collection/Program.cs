namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr= new int[] { 1, 2, 3, 4 };
            foreach (int i in arr) { Console.WriteLine(i); }

            int[] arr1 = new int[4];
            arr1[0] = 11;
            arr1[1] = 12;
            arr1[2] = 13;
            arr1[3] = 14;
            foreach (int j in arr1) { Console.WriteLine(j); }


# region array sorting
            /*int[] arr2= new int[5];
            for(int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine("enter value");
                int val = Convert.ToInt32(Console.ReadLine());
                arr2[i]= val;
            }
            Array.Sort(arr2);
            Console.WriteLine("Your enter value in array is sorted");
            foreach(int K in arr2) { Console.WriteLine(K); */}
        #endregion

        Emp[] emp = new Emp[3];
}
    }
public class Book
{
    private string _Auther;
    private string _BookName;

    public string BookName
    {
        get { return _BookName; }
        set { _BookName = value; }
    }


    public string Auther
    {
        get { return _Auther; }
        set { _Auther = value; }
    }

}
public class Emp
{
    private int _EId;
    private string _EName;
    private string _EAddress;

    public string Address
    {
        get { return _EAddress; }
        set { _EAddress = value; }
    }


    public string Name
    {
        get { return _EName; }
        set { _EName = value; }
    }


    public int Id
    {
        get { return _EId; }
        set { _EId = value; }
    }

    public string GetEmpDetails()
    {
        return string.Format("Id ={0}, Name ={1}, Address ={2}", _EId, _EName, _EAddress);
    }

}

