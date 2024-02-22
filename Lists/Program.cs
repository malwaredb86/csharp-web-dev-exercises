//Exercises: Control Flow & Collections

//TODO: Write your code for List Practice below:

static int sumEven(List<int> numbers)
{
    int sum = 0;
    foreach (int number in numbers)
    {
        if (number % 2 == 0)
        {
            sum += number;
        }
    }
    return sum;
}

List<int> someNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Console.WriteLine(sumEven(someNumbers));

string seuss = "I would not, could not, in a box. I would not, could not with a fox.\nI will not eat them in a house. I will not eat them with a mouse.";
List<string> seussList = seuss.Split(" ").ToList();

static void printWords(List<string> words)
{
    Console.WriteLine("What word length are you looking for?");
    string input = Console.ReadLine();
    int searchLength = int.Parse(input);
    foreach (string word in words)
    {
        if (word.Length == searchLength)
        {
            Console.WriteLine(word);
        }
    }
}

string sentence = "There are instances where you may want to terminate a loop if a given condition is met. In these instances, the break statement comes in handy. For example, say you want to loop through an array of integers to search for a given value. Once that number is found, you want to quit the loop. You can do the following";
List<string> sentenceWords = sentence.Split(" ").ToList();

printWords(seussList);


Console.WriteLine("Hello, Lists!");
