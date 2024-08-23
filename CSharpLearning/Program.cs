Console.WriteLine("--Hello! This is a Grade Score allocator--");
Console.Write("Please enter your score : ");
bool result = int.TryParse(Console.ReadLine(), out int score);


if (result == false || score > 100 || score < 0)
{
    Console.WriteLine("You didn't enter a valid score, try again!");
}
else
{
    char grade;
    if (score >= 70)
    {
        grade = 'A';
    }
    else if (score >= 60)
    {
        grade = 'B';
    }

    else if (score >= 50)
    {
        grade = 'C';
    }

    else if (score >= 40)
    {
        grade = 'D';
    }
    else
    {
        grade = 'F';
    }
    
    Console.WriteLine($"Your Grade is {grade}");
}

