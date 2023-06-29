RandomString Strandom=new RandomString();
Sorting Tom=new Sorting();  // Tom is a sorter))

string str=Convert.ToChar(new Random().Next(10,101))+"";
string [] stringArray=Strandom.GetRandomStringArray();
Console.Clear();
Console.WriteLine($"this array length is {stringArray.Length}");
Console.WriteLine(string.Join("    ",stringArray));
string [] sorted=Tom.sort(stringArray);
Console.WriteLine($"now this sorted array length is {sorted.Length}");
Console.WriteLine(string.Join("    ",sorted));