TaskOneTwo();

void TaskOneTwo()
{
    List<int> list = new List<int>(){2,3,5,1,593,23,4,563,2,4,454,7,74,2,1,231,4,2,42,5,46,7};
    var numbers = list.Where(number => number > 5);
    foreach (var num in numbers)
    {
        Console.WriteLine(num + " ");
    }
}