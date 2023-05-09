
Console.WriteLine("Enter a word");
string userImput = Console.ReadLine();

PrintAnyWord(userImput); //userImput - argument

static void PrintAnyWord(string anyString) //anyString - parameter
{
    anyString = anyString.ToUpper();
    for(int i = 0; i < 5; i++)
    {
        Console.WriteLine(anyString);
    }
}