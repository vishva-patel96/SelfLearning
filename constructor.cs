using System;
class MainClass
{
    public static void Main(string[] args)
    {
        //called object
        Test ford = new Test("toyato", "red", 1999);
        Console.WriteLine(ford.color + " "+ ford.model + " " + ford.year);
    }
}
class Test
{
    public string model;
    public string color;
    public int year;
    public Test(string modelName,string Color,int year)// create constructor 
    {
        model = modelName;
        color = Color;
        this.year = year;
    }
}