
Console.WriteLine("Are ou coming or leaving? (in/out)");
string userChoice = Console.ReadLine();

if(userChoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodbye();
}

static void PrintHello()
{
    Console.WriteLine("hello, world!");
}

static void PrintGoodbye()
{
    Console.WriteLine("see you later, aligator");
}