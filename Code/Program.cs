
string[] array = {"geek", "brains", "22", "hello", "c#", "World", ":)"};

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"\"{array[i]}\"");
    }
}


var result = new string[array.Length];  
var temp = 0; 

foreach (var value in array)  
{
    if (value.Length <= 3)   
    {
        result[temp] = value; 
        temp++; 
    }
}
PrintArray(array);
Console.WriteLine(" => ");
Console.Write(string.Join(Environment.NewLine, result, 0, temp));

