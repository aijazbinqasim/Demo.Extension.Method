using Demo.Extension.Method.ExtensionMethods;

namespace Demo.Extension.Method
{
    internal class Program
    {
        static void Main(string[] args)
        {




            //var val = 10;

            //var result = val.Sum(20);


            //Console.WriteLine(result);


            //var name = "Walidad";
            //Console.WriteLine(name.Concat("Brohi"));

            //Action<int> action = val => Console.WriteLine(val);
            //action.Print(100);



            // Define an Action<int>
            Action<int> print = x => Console.WriteLine($"Printing: {x}");

            // Call the extension method with validation
            print.ValidateAndExecute(10, x => x > 0); // Valid
            print.ValidateAndExecute(-5, x => x > 0); // Invalid
        }
    }
}
