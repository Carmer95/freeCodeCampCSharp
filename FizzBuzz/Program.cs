string fizzBuzz;
for (int i = 1; i < 101; i++)
{

    if (i % 5 == 0 && i % 3 == 0 && i > 0){
    fizzBuzz = i.ToString();
        fizzBuzz += " - FizzBuzz";
    }
    else if (i % 5 == 0 && i > 0){
    fizzBuzz = i.ToString();
        fizzBuzz += " - Buzz";
    }
    else if (i % 3 == 0 && i > 0){
    fizzBuzz = i.ToString();
        fizzBuzz += " - Fizz";
    }
    else fizzBuzz = i.ToString();

    Console.WriteLine($"{fizzBuzz}");
}