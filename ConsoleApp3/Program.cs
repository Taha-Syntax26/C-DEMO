// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");

string fName = "Owais";
string lName = " Ahmed Khan";

Console.WriteLine("Hello, Welcome to our company Mr." + fName + lName);*/

// Datatypes
/*byte age = 23;
short salary = 27000;
int number = 15;
long lNum = 1233211233213312321L;

float fNum = 2.567F; // 7 digits
double dNum = 1.23986592365623596239; // 15 digits
decimal deciNum = 2.913695613916541949146912346124612M; // 28 digits

char myGrade = 'A';
bool isValid = false;
string address = "North Nazimabad Block A";*/
// Console.WriteLine(age +  "age" + "lNum" + salary + "sal" + number + "Numb");

// Arithematic Operators

/*Console.WriteLine(55 + 45);
Console.WriteLine(55 - 45);
Console.WriteLine(55 * 45);
Console.WriteLine(55 / 45);
Console.WriteLine(55 % 45);
*/
// Assignment Operator

/*int number = 5;

Console.WriteLine(number += 2); // number = number + 2 == 7
Console.WriteLine(number -= 2); // number = number - 2 == 5
Console.WriteLine(number *= 2); // number = number * 2 == 10
Console.WriteLine(number /= 2); // number = number / 2 == 5
*/
// Comparision Operators (True, False)

/*int a = 50, b = 120;

Console.WriteLine(a == b); //False
Console.WriteLine(a != b); //True
Console.WriteLine(a < b); //True
Console.WriteLine(a > b); //False
Console.WriteLine(a <= b); //True
Console.WriteLine(a >= b); //False*/

//Logical Operator (AND &&, OR ||, NOT !)
/*int a = 34, b = 45;

// AND OPERATOR
// T / T == TRUE
Console.WriteLine(a >= b && a == b); //False
Console.WriteLine(a <= b && a >= b); //False

// OR OPERATOR
Console.WriteLine(a <= b || a == b); //
                                     //  T     F     == TRUE 

// NOT OPERATOR
Console.WriteLine(!(a == b)); // TRUE
*/

// Conditional Statements
//IF Else
/*using System;

Console.WriteLine("Enter Salary... ");

int salary = Int32.Parse(Console.ReadLine());

if (salary >= 50000 && !(salary >= 80000))
{
    Console.WriteLine("Good Salary Package");
}
else if (salary < 50000)
{
    Console.WriteLine("Do you get fuel Allowance??");
    string answer = Console.ReadLine();

    answer = answer.ToLower(); //yes or y
    if (answer == "yes" || answer == "y")
    {
        Console.WriteLine("Sounds Good!!");
    }
    else if (answer == "no" || answer == "n")
    {
        Console.WriteLine("Try to switch your Job");
    }
    else
    {
        Console.WriteLine("Please answer yes or no");
    }
}
else
{
    Console.WriteLine("MASHALLAH!");
}*/

//SWITCH CASE
/*Console.WriteLine("Enter number for days from 1 to 7:");
int number = Convert.ToInt32(Console.ReadLine());

switch(number)
{
    case 0:
        Console.WriteLine("Monday");
        break;
    case 1:
        Console.WriteLine("Tuesday");
        break;
    case 2:
        Console.WriteLine("Wednesday");
        break;
    case 3:
        Console.WriteLine("Thusrday");
        break;
    case 4:
        Console.WriteLine("Friday");
        break;
    case 5:
        Console.WriteLine("Saturday");
        break;
    case 6:
        Console.WriteLine("Sunday");
        break;
}*/







/*int a = 10;
Console.WriteLine($"this is string interpolation {a * 2}");


for (int i = 0; i < a; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("Even numbers up to 100:");
for (int i = 0; i <= 100; i += 2)
{
    Console.WriteLine(i);
}

Console.WriteLine("Odd numbers up to 100:");
for (int i = 1; i < 100; i += 2)
{
    Console.WriteLine(i);
}

Console.Write("Enter a number to print its multiplication table: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nMultiplication Table for {number}:");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{number} x {i} = {number * i}");
}*/



//WHILE LOOP

/*int j = 13;

while(j < 13)
{
    Console.WriteLine("j");
}*/

//DO WHILE LOOP

/*int j = 13;
do
{
    Console.WriteLine("j");
    j++;
} while (j < 13);
*/



//ARRAYs WITH FIXED SIZE

/*int[] numbers = new  int[4]; // only 4 elements will come in this array


numbers[0] = 2;
numbers[1] = 16;
numbers[2] = 42;
numbers[3] = 52;

Console.WriteLine(numbers[3]);

int[] stdMarks = { 67, 88, 99, 79 };

//foreach
foreach (int i in stdMarks)
{
    Console.WriteLine(i);
}*/


/*Console.WriteLine(Math.Pow(2, 2));

int[] numbers = new int[2]; //C# give default value to uninitialized variables int=0, string = null, bool=true

Console.WriteLine(numbers);*/

/*string[] cities = { "Karachi", "Lahore", "Islamabad", "Karachi", "Swat", "Quetta", "Pindi", "Multan" };

*//*Array.Sort(cities);
*//*Array.Reverse(cities);

foreach (string c in cities)
{
    Console.WriteLine(c);   
}*/

string[] cities = { "Karachi", "Lahore", "Islamabad", "Karachi", "Swat", "Quetta", "Pindi", "Multan" };

// Sort the array
/*Array.Sort(cities);
*/
// Reverse the sorted array
/*Array.Reverse(cities);
*/

/*for (int c = 0; c < cities.Length; c++)
{
    Console.WriteLine(cities[c]);
}*/

/*Console.WriteLine(Array.IndexOf(cities, "Swat"));
Console.WriteLine(Array.LastIndexOf(cities, "Karachi"));*/

/*for(int i = 0; i < cities.Length; i++)
{
    Console.WriteLine(cities[i]);
}*/


//MULTIDIMENTIONAL ARRAY(Array inside array) 20 , 40 etc

/*int[,] TopMarks =
{
    {97, 99},
    {87, 83},
    {77, 79},
    {65, 68}
};
Console.WriteLine(TopMarks[3, 1]);

for (int i = 0; i < TopMarks.GetLength(0); i++)
{
    Console.WriteLine($"Printing {i + 1} array");
    {
        for (int j = 0; j < TopMarks.GetLength(1); j++)
}
    Console.WriteLine();
}*/


//JAGGED ARRAY (size of sub-array is not fixed)

/*string[][] skillset =
{
    new string[4] {"C#", "SQL", "CSS", "HTML"},
    new string[1] {"PHP"},
    new string[2] {"JAVA", "Python"},
    new string[3] {"C", "JavaScript", "TypeScript"}
};

Console.WriteLine(skillset[3][2]);*/

// Using the above method by foreach nested loop

/*string[][] skillset =
{
    new string[4] {"C#", "SQL", "CSS", "HTML"},
    new string[1] {"PHP"},
    new string[2] {"JAVA", "Python"},
    new string[3] {"C", "JavaScript", "TypeScript"}
};

foreach (var skills in skillset)
{
    foreach (var skill in skills)
    {
        Console.WriteLine(skill);
    }
}*/
string[][] hoBBies =
{
    new string[4] {"Writing", "Singing", "Dancing", "Sleeping"},
    new string[1] {"Cricket"},
    new string[2] {"Vaping", "Eating"},
    new string[3] {"Traveling", "Cars", "Wrestling"}
};
foreach (var hobbys in hoBBies)
{
    foreach (var hobby in hobbys)
    {
        Console.WriteLine(hobby);
    }
}