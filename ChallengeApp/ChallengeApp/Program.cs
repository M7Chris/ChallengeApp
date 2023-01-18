//day 4 homework

var name = "Eve";
var sex = "Female";
var age = 33;

if (sex == "Female" && age == 33)
{
    if (name == "Eve")
    {
        Console.WriteLine("Ewa, lat 33");
    }
    else
    {
        Console.WriteLine("ma 33, lata, ale to nie Ewa");
    }
}
else if (sex == "Female" && age != 33)
{
    Console.WriteLine("To kobieta i jest w inym wieku niz 33");
}
else if (sex == "Male" && age < 18)
{
    Console.WriteLine("UWAGA: niepelnoletni");
}
else
    Console.WriteLine("to mezczyzna");
