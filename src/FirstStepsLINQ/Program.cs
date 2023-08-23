using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;

TaskFive();

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

void TaskFive()
{
    var pathFirst = @"C:\Users\d1810\Рабочий стол\текста\file1.txt";
    var pathSecond = @"C:\Users\d1810\Рабочий стол\текста\file2.txt";
    var textFirst = File.ReadAllLines(pathFirst);
    var textSecond = File.ReadAllLines(pathSecond);
    List<string> text = textFirst.Union(textSecond).ToList();
    var textFinishd = GetSortList(text);
    var splitedText = GetSplitedList(text);
    List<List<string>> textFinish = null;

    
    foreach (var line in splitedText)
        {

            textFinish = splitedText.OrderBy(line => Convert.ToInt32(line[0])).ToList();

        }
    

    var textFinishf = GetConcatenatedText(textFinish);
    foreach (var line in textFinishf)
    {
        Console.WriteLine(line);
    }
    

    List<List <string>> GetSplitedList(IEnumerable<string> text)
    {
        List<List<string>> list = new List<List<string>>();
        foreach (var line in text)
        { 
            var splitedLine = line.Split("|");
            list.Add(splitedLine.ToList());
        }

        return list;
    }

    List<string> GetConcatenatedText(List<List<string>> text)
    {
        List<string> list = new List<string>();
        foreach (var line in text)
        {
            var firstElement = line[0];
            var secondElement = line[1];
            var concatenatedLine = firstElement + "|" + secondElement;
            list.Add(concatenatedLine);
        }

        return list;
    }

    List<string> GetSortList(List<string> text)
    {
        text = text.Distinct().ToList();

        return text;
    }





}