using System;
class MainClass
{
    public static void Main(string[] args)
    {
        Test test = new Test("cow", "black",55);

        test.wheel.printWheelBrand();
    }
}
class car
{
    public string model;
    public void test2()
    {
        Console.WriteLine("");
    }    
   
}

class Wheels
{
    public int numberOfWheels;
    public string brand;

    public Wheels(int numberOfWheels, string brand)
    {
        this.numberOfWheels = numberOfWheels;
        this.brand = brand;
    }

    public void printNumberofWheels()
    {
        Console.WriteLine("No of wheels:" + this.numberOfWheels);
    }

    public void printWheelBrand()
    {
        Console.WriteLine("wheels brand:" + this.brand);
    }

}
class Test:car//dervied class
{
    
    public string name;
    public string color;
    public int year;
    public Wheels wheel;
   
    public Test(string Name, string Color, int Year)//method
    {
        name = Name;
        color = Color;
        year = Year;
        wheel = new Wheels(4, "michelin");
        
     

    }



}
