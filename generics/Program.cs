// See https://aka.ms/new-console-template for more information

static Type Max<Type>(Type a, Type b)
  where Type : IComparable
{
  return a.CompareTo(b) > 0 ? a : b;
}

Console.WriteLine(Max(5, 10));
Console.WriteLine(Max(10.2, 3.1));
