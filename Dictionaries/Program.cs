//Exercises: Control Flow & Collections

//TODO: Write your code for Dictionary Practice below:

Dictionary<int, string> students = new Dictionary<int, string>();
string newStudent;

do
{
    Console.WriteLine("Enter the student's name: ");
    string input = Console.ReadLine();
    newStudent = input;

    if (!Equals(newStudent, ""))
    {
        Console.WriteLine("What is the student's ID? ");
        string idInput = Console.ReadLine();
        int id = int.Parse(idInput);
        students.Add(id, newStudent);
    }

} while (newStudent != "");

foreach (KeyValuePair<int, string> student in students)
{
    Console.WriteLine(student.Key + " (" + student.Value + ")");
}

Console.WriteLine("Hello, Dictionary!");

