using system;
Namespace LogDemo
{
 PublishComponent class Program
 {
 static void Main(string[] args)
 {
 var calculator = new Calculator.Calculator();
 Console.WriteLine($"5+3 = {calculator.Add(5, 3)}");
 Console.WriteLine($"The square root of 3.14159 is 
 {calculator.squareRoot(3.14159)}");
 }
 }
}