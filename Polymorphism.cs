using System;
class MainClass
{
    public static void Main(string[] args)
    {
        Animal pig = new Pig();
        pig.animalsound();

        Animal cow = new Cow(); 
        cow.animalsound();
    }
}
class  Animal
{
     public virtual void animalsound()
    {
        Console.WriteLine("The animal makes a sound");
    }
   
}

class Pig : Animal
{
    public override void animalsound()
    {
        Console.WriteLine("weee weee");
    }


}
class Cow : Animal
{
    public override void animalsound()
    {
        Console.WriteLine("bow bow");
    }



}
