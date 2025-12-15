// See https://aka.ms/new-console-template for more information

Console.WriteLine(5/10);
if(args.Length>0)
{
    string message = string.Join(" ", args);
    Console.WriteLine("You passed the following arguments: " + message);
}else
{
    while(Console.ReadLine() is string line && line.Length>0)
    {
        Console.WriteLine("Please enter some text (or press Enter to exit): ");
        Console.WriteLine("You entered: " + line);
    }
}