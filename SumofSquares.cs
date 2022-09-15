//Implement a method SquaresSum(double num1, double num2, double num3), in a class SumOfSquares, which takes three numbers, squares them and returns their sum. 
class SumOfSquares

{

    
    // Method to square the sum of three numbers
    public double SquaresSum(double num1, double num2, double num3)
    {
        

         num1 = num1 * num1;
       num2= num2 * num2;
       num3 = num3 * num3;

        
        double sum = num1 +num2+num3;

        // Write your code here

      return sum;
    }
}
    class mainClass
{
    public static void Main(string[] args)
    {
        
        SumOfSquares test = new SumOfSquares();
       Console.WriteLine( test.SquaresSum(2, 3, 4));

        Console.WriteLine(test.SquaresSum(2, 5, 7));
    }
}