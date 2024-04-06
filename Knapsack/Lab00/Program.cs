namespace Lab00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a max number: ");
            var input = Console.ReadLine();
            var anInstanceofMyClass = new FizzBuzz(Int32.Parse(input));

            anInstanceofMyClass.Display();
        }
    }
}
