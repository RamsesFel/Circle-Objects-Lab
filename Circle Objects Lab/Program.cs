using Circle_Objects_Lab;

bool runProgram = true;
double input = 0;
while (true)
{
    Console.WriteLine("Enter a radius");
    try
    {
        input = double.Parse(Console.ReadLine());
        if (input <= 0)
        {
            Console.WriteLine("Number can't be negative or 0.");
            continue;
        }
        break;
    }
    catch
    {
        Console.WriteLine("Invalid input, try again");
        continue;
    }
}

Circle circleresult = new Circle(input);
while (runProgram)
{

    Console.WriteLine(circleresult.CalculateDiameter(circleresult.GetRadius()));
    Console.WriteLine(circleresult.CalculateCircumference(circleresult.GetRadius()));
    Console.WriteLine(circleresult.CalculateArea(circleresult.GetRadius()));
    while (true)
    {
        Console.WriteLine("Do you want the circle to grow? y/n");
        string answer = Console.ReadLine();
        if (answer == "y")
        {
            circleresult.Grow();
            break;
        }
        else if (answer == "n")
        {
            runProgram = false;
            Console.WriteLine($"Radius is {circleresult.GetRadius()}");
            Console.WriteLine("Goodbye");
            break;
        }
        else
        {
            Console.WriteLine("Invalid answer, try again.");
            continue;
        }
    }

}