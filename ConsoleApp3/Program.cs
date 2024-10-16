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

/*using System.Globalization;

string[] cities = { "Karachi", "Lahore", "Islamabad", "Karachi", "Swat", "Quetta", "Pindi", "Multan" };
*/
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
/*string[][] hoBBies =
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
}*/



//DOT NET FUNCTIONS
/*void greet() // void is functions that returns nothing
{
    Console.WriteLine("Hi, Taha!! Welcome to our company..");
}

greet();*/ //function calling

// no return  with parameters
/*void greets(string name)
{
    Console.WriteLine($"Hi, {name}!! Welcome to our company.");
}


greets("Taha");*/
/*string Greet()
{
    return ("Hi, User!! Welcome to our company");
}*/


//Console.WriteLine(Greet());
//string messg = Greet();
//Console.WriteLine(messg.ToUpper());


/*float floatNumbers()
{
    return (0.7323f);
}

Console.WriteLine(floatNumbers());*/
//float fNum = floatNumber();
//Console.WriteLine(fNum);

//RETURN WITH PARAMETERS
//n ia used to take to the next line.


/*string Greet(string name, byte age)
{ 
    return ($"Hola, {name}, Gracias.\n {age}");
        
  }*/

//2nd method
/*string Greet(string name, byte age)
{ return name + " WELCOME to our company" + age; }*/

/*
string mssg = Greet("Jethalal", 45);
Console.WriteLine(mssg.ToUpper());
*/
//PRE Defined

//Math.Sqrt(49); Console.WriteLine("Skill");


//Exception HANDLING (TRY | CATCH)
/*try
{
    int number = Convert.ToInt32(Console.ReadLine());
    switch (number)
    {
        case 1:
            Console.WriteLine("Hi"); break;

        case 2:
            Console.WriteLine("HI, Hi");
            break;

        case 3:
            Console.WriteLine("hi, Hello, hi");
            break;

        case 4:
            Console.WriteLine("Hi, Hello , Hi , hello");
            break;

        default:
            Console.WriteLine("bye");
            break;
    }
}
catch (DivideByZeroException e)
{

    Console.WriteLine("Can't Divide by zero");
}
catch (FormatException e)
{
    Console.WriteLine("Invalid input we want an integar from you." + 0);
}
catch (Exception e)
{
    Console.WriteLine("Oops! Something went wrong.");
}
finally
{
    Console.WriteLine("Thanks for using our console application. Do recommend it to others :)");
}
*/


//COLLECTIONS

//  GENERICS COLLECTION
//FIXED DATATYPES 
//DYNAMIC SIZE 
//LIST, DICTIONARY, STACK, QUEUSES


//NON-GENERIC COLLECTION
//DATATYPES NOT FIXED
// DYNAMIC SIZE
//ARRAYLIST, HASHTABLE

//using System.Collections;
//using System.Linq
//LIST

/*List<String> SuperCars = new List<String>();
SuperCars.Add("LaFerrari");
SuperCars.Add("Buggati Chirpon");
SuperCars.Add("McLaren");

List<String> Cars= new List<String>();

Cars.Add("Honda Civic");
Cars.Add("Nissan GTR");
Cars.Add("Toyota Supra");
Cars.Add("Ford Gt");
Cars.Add("BMW");
Cars.Add("Audi");*/

////Cars.Remove("Honda Civic");
////Cars.RemoveAt(3

///Console.WriteLine(Cars.Contains("G Wagon"));

//SuperCars.Insert(1, "G wagon");
//Console.WriteLine(SuperCars.Contains("G Wagon"));

//Cars.RemoveRange(0, 2);
/*Cars.AddRange(SuperCars);
*///Cars.Clear();
  //Console.WriteLine(Cars.Contains("G Wagon"));

/*foreach (var car in Cars)
{

    Console.WriteLine(car);

}*/
/*foreach (var Car in SuperCars)
{
    
        Console.WriteLine(Car);
    }*/




//QUEUES (fifo: first in first out)
/*Queue<string> names = new Queue<string>();
names.Enqueue("Owais");
names.Enqueue("ahmed");
names.Enqueue("ashar");
names.Enqueue("rayan");
names.Enqueue("yaheya");
names.Enqueue("abdullah");
names.Enqueue("talha");
names.Enqueue("danish");
names.Enqueue("sohaib");
*/

/*names.Dequeue();
names.Dequeue();
names.Dequeue();
names.Dequeue();*/

//    names.Clear();

//foreach (string item in names)
//{
//    Console.WriteLine(item);
//}



//STACK (lifo: last in first out)

/*Stack<string> SecondRow = new Stack<string>();
SecondRow.Push("Taha");
SecondRow.Push("Sumair");
SecondRow.Push("mariam");
SecondRow.Push("danish");
SecondRow.Push("basit");




SecondRow.Pop();
SecondRow.Pop();
SecondRow.Pop();
SecondRow.Pop();

//SecondRow.Clear();

foreach (string item in SecondRow)
{
    Console.WriteLine(item);
}*/


//DICTIONARY (generics)

/*Dictionary<string, string> user = new Dictionary<string, string>();
user.Add("username", "Muhammad Taha");
user.Add("email", "mtaha080204@gmail.com");
user.Add("pass", "696969");
user.Add("role", "sabka pappa hu pappa");
user.Add("image", "dikahne laik nhi.png");

Console.WriteLine(user["role"]);
//user.Remove("image");
Console.WriteLine(user["image"]);

foreach (var item in user)
{
    string[] test = (item.ToString().Split(','));
    string key = test[0].Trim('[');
    string value = test[1].Trim('[');
    //Console.WriteLine(key, value);
    Console.WriteLine($"The Property is : {key} and the value is : {value}");
    //bConsole.WriteLine(test[1]);
}*/


//HASHTABlEs

using System;
/*using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;*/
///
/*Hashtable user = new Hashtable();
user.Add("username", "Muhammad Taha");
user.Add("email", "mtaha080204@gmail.com");
user.Add("pass", "696969");
user.Add("role", "sabka pappa hu pappa");
user.Add("image", "dikahne laik nhi.png");

Console.WriteLine(user["isadmin"]);
user.Remove("image");
user.Contains(2.45); // true

//Console.WriteLine(user["role"]);
foreach (DictionaryEntry item in user)
{
    Console.WriteLine(item.Key + " : " + item.Value);
}
Console.WriteLine(user.GetHashCode());*/

//using System.Collections;

//ArrayList (Non Generic) (no fixed datatype)
/*ArrayList Cars = new ArrayList();
Cars.Add("Honda civic");
Cars.Add("Honda Accord");
Cars.Add("Toyota Camry");
Cars.Add("toyota Fortuner");
Cars.Add(240900);
Cars.Add(.24f);

foreach (var car in Cars)
{
    Console.WriteLine(car);
}*/


//String Methods
//string test = """{"name": "John Doe"}""";


/*using System.Security.Cryptography;

string test = " we are learning \"C#\"";
Console.WriteLine(test);
Console.WriteLine(test.Replace("Learning", "Mastering"));
Console.WriteLine(test.Replace("C#", "JAVA"));
*/



//OOP
//Object and Class

/*Aeroplane Boeing707 = new Aeroplane(); //default constructor


Boeing707.Name = "Boeing 707";
Boeing707.takeOff();
Console.WriteLine(Boeing707.Airline);

Aeroplane f16 = new Aeroplane("PAF");

Aeroplane f17 = new Aeroplane("PAF", "F-17 Thunder", 2, 2, "85000hp");
f17.takeOff();
f17.land();


public class Aeroplane
{
    public string? Airline;
    public string? Name;
    public int Seats;
    public int Crew;
    public string? Power;

    //Constructor
    public Aeroplane()
    {
        this.Airline = "Not Specified";
        this.Name = "Unknown";
        this.Seats = 0;
        this.Crew = 0;
        this.Power = null;
    }

    public Aeroplane(string airline, string name, int seats, int crew, string power)
    {
        Airline = airline;
        Name = name;
        Seats = seats;
        Crew = crew;
        Power = power;
    }

    public Aeroplane(string v)
    {
    }

    public void takeOff()
    {
        Console.WriteLine($"{this.Name}is  taking off. Best Wishes!!");
    }

    public void land()
    {
        Console.WriteLine($"{this.Name} is landing at the 4th runway..!");
    }

}
*/
//OOP (Object oriented Programming)
//it is an approach to code cleaner and better.
//readable
//reusable
//optimize
//proper structure of the code is maintained.

// Main pillars of OOP

//1. Inheritance
// i. Single level inheritance Vehicle -> Car
// ii. Multi level inheritance Vehicle -> Car -> Ecar
// iii.Heirarchical inheritance Vehicle -> Car , Vehicle-> bike
// iv. Multiple inheritance 
// v. hybrid inheritance  Vehicle  -> Car , Vehcile -> car -> Ecar , Car -. Ecar

//2. Polymorphism
// Method Overloading 
//Method Overriding 

//3. Abstraction
//4. Encapsulation

/*class Vehicle  // base class (parent) 
{
    public string brand = "Ford";  // Vehicle field
    public void honk()             // Vehicle method 
    {
        Console.WriteLine("Tuut, tuut!");
    }
}

class Car : Vehicle  // derived class (child)
{
    public string modelName = "Mustang";  // Car field
}

class Programs
{
    static void Main(string[] args)
    {
        // Create a myCar object
        Car myCar = new Car();

        // Call the honk() method (From the Vehicle class) on the myCar object
        myCar.honk();

        // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
        Console.WriteLine(myCar.brand + " " + myCar.modelName);
    }
}*/



/*using System;
Math.Sqrt(49);
Console.WriteLine("dkf");

Console.WriteLine(Car.totalCars);
Car.PayTax();

public class Vehicle
{
    public string regNo;
    public string color;
    public static int totalCars = 0;

    public Vehicle(string regNo, string color)
    {
        this.regNo = regNo;
        this.color = color;
    }

    public virtual void Run()
    {
        Console.WriteLine($"{this.regNo} vehicle started running");
    }
}

public class Car : Vehicle
{
    public string brand;
    public string model;
    public int price;

    public Car(string regNo, string color, string brand, string model, int price)
        : base(regNo, color)
    {
        this.brand = brand;
        this.model = model;
        this.price = price;
        totalCars++;
    }

    public override void Run()
    {
        Console.WriteLine($"{this.brand} {this.model} {this.regNo} started running");
    }

    public void Run(int speed)
    {
        Console.WriteLine($"{this.brand} {this.model} {this.regNo} started running at {speed} MPH.");
    }

    public static void PayTax()
    {
        Console.WriteLine("Boom..! the race has begun. May the best be winner.");
        // Implement tax payment logic if needed
    }
}
  class program
{
    static void Main(string[] args)
    {
        // Creating a Vehicle instance
        Vehicle abc = new Vehicle("AAZ-789", "Metallic grey");
        abc.Run();

        // Creating a Car instance
        Car mercedes = new Car("TZ-8908", "Black", "Mercedes", "Benz C-Class", 20000000);
        mercedes.Run();  // Calls overridden Run method
        mercedes.Run(500);  // Calls overloaded Run method

        // Display total cars
        Console.WriteLine($"Total Cars: {Car.totalCars}");
        Car.PayTax();
    }
}
*/         ///THIS HAS ERROR TRY TO SOLVE  IT


//Vehicle abc = new Vehicle("AAZ-789", "Metallic grey");
//abc.Run();

//Car MarkX = new Car("2008", "Black", "Toyota", "Mark X", 3500000);
//Car a = new Car("2008", "Black", "Toyota", "Mark X", 3500000);
//Car b = new Car("2008", "Black", "Toyota", "Mark X", 3500000);
//Car bv = new Car("2008", "Black", "Toyota", "Mark X", 3500000);
//Car g = new Car("2008", "Black", "Toyota", "Mark X", 3500000);
//Car MadrkX = new Car("2008", "Black", "Toyota", "Mark X", 3500000);


//MarkX.Run();
//MarkX.Run(300);

//Math abc = new Math();
//abc.Sqrt(49);

//static function examples:
/*Math.Sqrt(49);
Console.WriteLine("dkf");

Console.WriteLine(Car.totalCars);
Car.paytax();



abstract public class Vehicle
{
    public string regNo;
    public string color;

    public static int totalCars = 0;
    public static int totalAmount = 0;
    public static int payingCars = 0;
    public static int nonPayingCars = 0;
    public virtual void Run()
    {
        Console.WriteLine($"{this.regNo} vehicle started running");

    }
}
abstract public class Car : Vehicle
{
    public string brand;
    public string model;
    public int price;
    public int basePrice = 2;
    public static int carCount = 0;
    public Car(string regno, string color, string brand, string model, int price)
    {
        this.regNo = regno;
        this.color = color;
        this.brand = brand;
        this.model = model;
        this.price = price;
        totalCars++;
        carCount++;
    }
    public static void paytax()
    {
        Console.WriteLine("Boom..! the race has begun. May the best be winner.");
        //payingCars++;
        //totalAmount += this.basePrice;

    }
    //method overriding
    public void passWithoutPaying()
    {
        Console.WriteLine($"{this.brand} {this.model} {this.regNo} started running");
        nonPayingCars++;
    }

    //method overloading
    public void Run(int speed)
    {
        Console.WriteLine($"{this.brand} {this.model} {this.regNo} started running at {speed} MPH.");
    }

}*/


/*
//INTERFACES
FrontEndDeveloper taha = new FrontEndDeveloper();
taha.ComplexDesign("Muhammad Taha");
taha.SimpleDesign();


*//*FullStackDeveloper Ebaad = new FullStackDeveloper();
Ebaad.SimpleDesign();
Ebaad.ComplexAPIs();*//*

//interface topicx
//{
//Interface
//static
//abstract
//}

interface FrontEndDeveloper
{
    public void SimpleDesign();

    public void ComplexDesign(string name);
}

interface BackEndDeveloper
{
    public void SimpleCrud();

    public void ComplexAPIs();

    public void Authentication();

}

public class FrontEndDeveloper : FrontEndDevelopment
{
    public void SimpleDesign()
    {
        Console.WriteLine("We will provide you simple and responsive design using HTML, CSS, and JS.");
    }

    public void ComplexDesign(string name)
    {
        Console.WriteLine($"Hi, this is {name}. We will provide you animated and responsive design using HTML, CSS, JS, ReactJS, and NextJS.");
    }
}*/


//Interfaces
FrontEndDeveloper ashar = new FrontEndDeveloper();
ashar.ComplexDesign("haseeb");
ashar.SimpleDesign();

//FullStackDeveloper usama new FullStackDeveloper();
//usama.SimpleDesign();
//usama.ComplexAPIs();
//interface topics
//{
//Interfaces,
// Static,
// Abstract
//}
//1 reference
interface FrontEndDevelopment
{
    //2 references
    public void SimpleDesign();
    public void ComplexDesign(string name);
}

interface BackEndDevelopment
{
    public void SimpleCrud();
    public void ComplexAPIs();
    public void Aunthentication();
}

public class FrontEndDeveloper : FrontEndDevelopment
{
    //method implementation

    public void SimpleDesign()
    {
        Console.WriteLine("we will provide you simple and responsive design using HTML, CSS and JS");
    }

    public void ComplexDesign(string name)
    {
        Console.WriteLine($"hi this is {name}, we will provide you animated and responsive design using HTML, CSS, JS, React, " + $"Nextjs.");
    }

}



