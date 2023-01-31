// 1.Stwórz klase Employee (imie, nazwisko, wiek, pkty (int) )
// 2.Stwórz 3 pracownikow i każdemu przydziel po 5 ocen (1-10)
// 3. Napisz program, który wyszuka pracownika z max liczba ocen i wyswietli go z jego wynikiem

using ChallengeApp;
using System.Diagnostics.CodeAnalysis;

User user1 = new User("Chris", "Walken", 79);
User user2 = new User("Michael", "Duncan", 54);
User user3 = new User("Monica", "Cassel", 58);


user1.AddScore(4);
user1.AddScore(2);
user1.AddScore(3);
user1.AddScore(4);
user1.AddScore(8);
// sum:21

user2.AddScore(7);
user2.AddScore(3);
user2.AddScore(6);
user2.AddScore(2);
user2.AddScore(4);
//sum:22

user3.AddScore(2);
user3.AddScore(5);
user3.AddScore(6);
user3.AddScore(9);
user3.AddScore(1);
//sum:23

var result1 = user1.Result;
var result2 = user2.Result;
var result3 = user3.Result;

if (result1 >= result2 && result1 >= result3)
{
    if (result1 == result2)
    {
        Console.WriteLine($" The employee {user1.Name} {user1.Surname}, {user1.Age} years old, get the same score as {user2.Name} {user2.Surname} {user2.Age} years old, and it's: {result1}");
    }
    else if (result1 == result3) 
    {
        Console.WriteLine($" The employee {user1.Name}, {user1.Surname} {user1.Age} years old, get the same score as {user3.Name} {user3.Surname} {user3.Age} years old, and it's: {result1}");
    }
    else
    {
        Console.WriteLine($" The employee with max score is {user1.Name} {user1.Surname} {user1.Age} years old, with MAX {user1.Result} score!");
    }
}
else if (result2 >= result1 && result2 >= result3)
    if (result2 == result1)
    {
        Console.WriteLine($" The employee {user2.Name} {user2.Surname} {user2.Age} years old, get the same score as {user1.Name} {user1.Surname} {user1.Age} years old, and it's: {result2}");
    }
    else if (result2 == result3)
    {
        Console.WriteLine($" The employee {user2.Name} {user2.Surname} {user2.Age} years old, get the same score as {user3.Name} {user3.Surname} {user3.Age} years old, and it's: {result2}");
    }
    else
    {
        Console.WriteLine($" The employee with max score is {user2.Name} {user2.Surname}, {user2.Age} years old, with MAX {user2.Result} score!");
    }

else if (result3 >= result1 && result3 >= result2)
    if (result3 == result1)
    {
        Console.WriteLine($" The employee {user2.Name}   {user2.Surname} {user3.Age} years old, get the same score as {user1.Name} {user1.Surname} {user1.Age} years old, and it's: {result3}");
    }
    else if (result3 == result2)
    {
        Console.WriteLine($" The employee {user3.Name} {user3.Surname} {user3.Age} years old, get the same score as  {user2.Name}   {user2.Surname}   {user2.Age}  years old, and it's: {result3}");
    }
    else
    {
        Console.WriteLine($" The employee with max score is {user3.Name} {user3.Surname}, {user3.Age} years old, with MAX {user3.Result} score!");
    }