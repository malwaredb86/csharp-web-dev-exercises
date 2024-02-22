//Exercises: Control Flow & Collections

//TODO: Write your code for Array Practice below:

int[] numbers = { 1, 1, 2, 3, 5, 8};
foreach (int number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("Hello, Arrays!");

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i]%2 != 0)
    {
        Console.WriteLine(numbers[i]);
    }
}



