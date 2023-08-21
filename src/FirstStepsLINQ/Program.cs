TaskThreeFour();

void TaskOneTwo()
{
    List<int> list = new List<int>(){2,3,5,1,593,23,4,563,2,4,454,7,74,2,1,231,4,2,42,5,46,7};
    var numbers = list.Where(number => number > 5);
    foreach (var num in numbers)
    {
        Console.WriteLine(num + " ");
    }
    
    List<int> distinct = list.Distinct().ToList();
 
    Console.WriteLine(String.Join(",", distinct));
}

void TaskThreeFour()
{
    var path = @"C:\Users\d1810\Рабочий стол\линк\test.txt";
    var lines = File.ReadAllLines(path);
    var found = lines.Where(line => line.Contains("понимаешь", StringComparison.InvariantCultureIgnoreCase) );

    var foundd = lines.FirstOrDefault(line => line.Contains("мир", StringComparison.InvariantCultureIgnoreCase));
}