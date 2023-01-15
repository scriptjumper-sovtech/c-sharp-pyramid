Console.Write("Enter total number of layers for pyramid: ");
string layers = Console.ReadLine();

if (layers != "")
{
    int numberOfLayers = Int32.Parse(layers);
    int space = 0;
    int number = 0;

    Console.WriteLine("Printing pyramid");
    for (int i = 1; i <= numberOfLayers; i++) // Total number of layer for pyramid  
    {
        for (space = 1; space <= (numberOfLayers - i); space++) // Loop For Space  
            Console.Write(" ");  
        for (number = 1; number <= i; number++) //increase the value  
            Console.Write('*');  
        for (number = (i - 1); number >= 1; number--) //decrease the value  
            Console.Write('*');
        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("Can not display pyramid!");
}
