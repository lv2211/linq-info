using static System.Net.WebRequestMethods;

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

IReadOnlyList<int> readOnlyList = numbers;
//readOnlyList[0] = 200;    COMPILE ERROR: Property or indexer 'IReadOnlyList<int>.this[int]' cannot be assigned to -- it is read only	Linq.IReadOnlyList

foreach (var number in readOnlyList)
{
    Console.WriteLine(number);
}
