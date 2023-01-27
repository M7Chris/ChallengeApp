// 1.Stwórz klase Employee (imie, nazwisko, wiek, pkty (int) )
// 2.Stwórz 3 pracownikow i każdemu przydziel po 5 ocen (1-10)
// 3. Napisz program, który wyszuka pracownika z max liczba ocen i wyswietli go z jego wynikiem

using ChallengeApp;
using System.Diagnostics.CodeAnalysis;

Employee employee1 = new Employee("Chris", "Walken", 79);
Employee employee2 = new Employee("Michael", "Duncan", 54);
Employee employee3 = new Employee("Monica", "Cassel", 58);


employee1.AddScore(4);
employee1.AddScore(2);
employee1.AddScore(3);
employee1.AddScore(4);
employee1.AddScore(8);
// sum:21

employee2.AddScore(7);
employee2.AddScore(3);
employee2.AddScore(6);
employee2.AddScore(2);
employee2.AddScore(4);
//sum:22

employee3.AddScore(2);
employee3.AddScore(5);
employee3.AddScore(6);
employee3.AddScore(9);
employee3.AddScore(1);
//sum:23

var result1 = employee1.Result;
var result2 = employee2.Result;
var result3 = employee3.Result;

if (result1 >= result2 && result1 >= result3)
{
    if (result1 == result2)
    {
        Console.WriteLine($" The employee {employee1.Name} {employee1.Surname}, {employee1.Age} years old, get the same score as {employee2.Name} {employee2.Surname} {employee2.Age} years old, and it's: {result1}");
    }
    else if (result1 == result3) 
    {
        Console.WriteLine($" The employee {employee1.Name}, {employee1.Surname} {employee1.Age} years old, get the same score as {employee3.Name} {employee3.Surname} {employee3.Age} years old, and it's: {result1}");
    }
    else
    {
        Console.WriteLine($" The employee with max score is {employee1.Name} {employee1.Surname} {employee1.Age} years old, with MAX {employee1.Result} score!");
    }
}
else if (result2 >= result1 && result2 >= result3)
    if (result2 == result1)
    {
        Console.WriteLine($" The employee {employee2.Name} {employee2.Surname} {employee2.Age} years old, get the same score as {employee1.Name} {employee1.Surname} {employee1.Age} years old, and it's: {result2}");
    }
    else if (result2 == result3)
    {
        Console.WriteLine($" The employee {employee2.Name} {employee2.Surname} {employee2.Age} years old, get the same score as {employee3.Name} {employee3.Surname} {employee3.Age} years old, and it's: {result2}");
    }
    else
    {
        Console.WriteLine($" The employee with max score is {employee2.Name} {employee2.Surname}, {employee2.Age} years old, with MAX {employee2.Result} score!");
    }

else if (result3 >= result1 && result3 >= result2)
    if (result3 == result1)
    {
        Console.WriteLine($" The employee {employee3.Name} {employee3.Surname} {employee3.Age} years old, get the same score as {employee1.Name} {employee1.Surname} {employee1.Age} years old, and it's: {result3}");
    }
    else if (result3 == result2)
    {
        Console.WriteLine($" The employee {employee3.Name} {employee3.Surname} {employee3.Age} years old, get the same score as  {employee2.Name}   {employee2.Surname}   {employee2.Age}  years old, and it's: {result3}");
    }
    else
    {
        Console.WriteLine($" The employee with max score is {employee3.Name} {employee3.Surname}, {employee3.Age} years old, with MAX {employee3.Result} score!");
    }