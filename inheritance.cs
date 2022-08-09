using System;
class MainClass
{
    public static void Main(string[] args)
    {
        test2 Test = new test2();

        Test.name = "ford";
        Test.year = 1115;
        Test.number = "5646";
        Test.model();
        //Console.WriteLine(Test.model);
       
        Console.WriteLine(Test.name + " " + Test.year + " " + Test.number);
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
class test2 : test
{
    public string number;
}
