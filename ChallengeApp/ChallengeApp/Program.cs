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

int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;

foreach (char d in digits)
{
    if (d == '0')
    {
        counter0++;
    }
    else if (d == '1')
    {
        counter1++;
    }
    else if (d == '2')
    {
        counter2++;
    }
    else if (d == '3')
    {
        counter3++;
    }
    else if (d == '4')
    {
        counter4++;
    }
    else if (d == '5')
    {
        counter5++;
    }
    else if (d == '6')
    {
        counter6++;
    }
    else if (d == '7')
    {
        counter7++;
    }
    else if (d == '8')
    {
        counter8++;
    }
    else if (d == '9')
    {
        counter9++;
    }
   
    {
        Console.WriteLine(digits);
        Console.WriteLine($"0 pojawia się {counter0} raz/y");
        Console.WriteLine($"1 pojawia się {counter1} raz/y");
        Console.WriteLine($"2 pojawia się {counter2} raz/y");
        Console.WriteLine($"3 pojawia się {counter3} raz/y");
        Console.WriteLine($"4 pojawia się {counter4} raz/y");
        Console.WriteLine($"5 pojawia się {counter5} raz/y");
        Console.WriteLine($"6 pojawia się {counter6} raz/y");
        Console.WriteLine($"7 pojawia się {counter7} raz/y");
        Console.WriteLine($"8 pojawia się {counter8} raz/y");
        Console.WriteLine($"9 pojawia się {counter9} raz/y");
    }
}

/*
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
*/

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