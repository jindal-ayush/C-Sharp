class Program
{
    int i;
    bool b;

    static void Main(string[] args)
    {
        Program p = new Program();
        Console.WriteLine("Object created successfully");
        Console.WriteLine(p.i);
        Console.WriteLine(p.b);
        Console.ReadLine();
    }
}
