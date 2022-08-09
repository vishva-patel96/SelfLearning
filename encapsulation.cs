using System;
class MainClass
{
    public static void Main(string[] args)
    {
        //called object
        Test test= new Test();
        test.Name = "ford";
        Console.WriteLine(test.Name);
    }
}
class Test
{
    
    private string name;// access modifiers
    
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
   
}