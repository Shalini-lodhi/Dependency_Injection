using DI_Library;

internal class Program
{
    private static void Main(string[] args)
    {
        //intantiate Business Logic
        BusinessLogic businessLogic = new BusinessLogic();
        businessLogic.ProcessData();
        Console.ReadLine();
    }
}