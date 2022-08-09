using System;
class MainClass
{
    public static void Main(string[] args)
    {
        test Test = new test();

        Test.name = "ford";
        Test.year = 1115;
        Test.model();
        //Console.WriteLine(Test.model);
       
        Console.WriteLine(Test.name + " " + Test.year);
    }
}
class car//parent class
{
    public string name;
    public void model()//method
     {
        Console.WriteLine("toyota");
    }
   
}
class test : car //dervied class
{
    public string color;
    public int year;
}