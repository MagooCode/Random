using ConsoleApp5;

MyList<int> myIntList = new MyList<int>();
myIntList.Add(1);
myIntList.Add(2);
myIntList.Add(3);
myIntList.Add(4);
myIntList.Add(5);

foreach (int i in myIntList)
{ 
    Console.WriteLine(i);
}

Console.WriteLine(myIntList.Contains(1));
Console.WriteLine(myIntList.Exsists(value => value > 0));
Console.WriteLine(myIntList.Find(value => value < 5 && value > 2));

foreach (var element in myIntList.FindAll(value => value > 3))
{
    Console.WriteLine(element);
}

Console.WriteLine();