string[] array = ["B123","C234","A345","C15","B177","G3003","C235","B179"];

foreach (string line in array)
{
    if (line.StartsWith("B")) {
        Console.WriteLine(line);
    }
}