//day 5

//pierwszy sposob deklarowania tablic
/*
int[] grades = new int[5];
string[] dayOfWeeks = new string[7];
dayOfWeeks[0] = "monday";
dayOfWeeks[1] = "tuesday";
dayOfWeeks[2] = "wednesday";
dayOfWeeks[3] = "thursday";
dayOfWeeks[4] = "friday";
dayOfWeeks[5] = "saturday";
dayOfWeeks[6] = "sunday";
*/

//drugi sposob deklarowania tablic
//string[] dayOfWeeks2 = {"monday","tuesday","wednesday","thursday","friday","saturday","sunday"};
//Console.WriteLine(dayOfWeeks2[3]);

//petla for
/*
for(var i=0; i<dayOfWeeks.Length; i++)
{
    Console.WriteLine(dayOfWeeks[i]);
}
*/

//Listy
/*
List<string> dayOfWeeks = new List<string>();
dayOfWeeks.Add("monday");
dayOfWeeks.Add("tuesday");
dayOfWeeks.Add("wednesday");
dayOfWeeks.Add("thursday");
dayOfWeeks.Add("friday");
dayOfWeeks.Add("saturday");
dayOfWeeks.Add("sunday");
*/
/*
for (var i = 0; i < dayOfWeeks.Count; i++)
{
    Console.WriteLine(dayOfWeeks[i]);
}
*/

//petla foreach
/*
foreach(var day in dayOfWeeks)
{
    Console.WriteLine(day);
}
*/

//ile cyfr wystepuje w danej liczbie?

int number = 12797;
string numberAsString = number.ToString(); //zamiana liczby na string
char[] digits = numberAsString.ToCharArray(); //zamiana string na tablice char
List<char> numbers = new List<char>();

numbers.Add('0');
numbers.Add('1');
numbers.Add('2');
numbers.Add('3');
numbers.Add('4');
numbers.Add('5');
numbers.Add('6');
numbers.Add('7');
numbers.Add('8');
numbers.Add('9');


foreach (var digit in numbers)
{
    int count = 0;
    foreach (var d in digits)
    {
        if (digit == d) count++;
    }
    Console.WriteLine(digit + " ===> " + count);
}

/*
 //albo for zamiast foreach
for (int i = 0; i < numbers.Count; i++)
{
    var counter = 0;
    foreach (var d in digits)
    {
        if (numbers[i] == d)
        {
            counter++;
        }
    }
    Console.WriteLine(i + " ===> " + counter);
}
*/