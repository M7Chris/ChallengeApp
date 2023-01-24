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

List<char> digit = new List<char>();

digit.Add('0');
digit.Add('1');
digit.Add('2');
digit.Add('3');
digit.Add('4');
digit.Add('5');
digit.Add('6');
digit.Add('7');
digit.Add('8');
digit.Add('9');


foreach (var isDigit in digit)
{
    int count = 0;
    foreach (var i in digits)
    {
        if (isDigit == i) count++;
    }
    Console.WriteLine(isDigit + " ===> " + count);
}
