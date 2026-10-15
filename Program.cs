/* using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World! \nIm Rishab Hari"); */

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using Microsoft.VisualBasic;

/* Console.Write("Enter your name : ");
string name = Console.ReadLine();
Console.Write("Jello " + name);
Console.WriteLine($"\nHello, {name.ToUpper()}! \n{name}, There are {name.Length} letters in your name!");

Console.Write("Enter your age : ");
int age = int.Parse(Console.ReadLine());
Console.WriteLine($"Hello, {name}. \nYou are {age + 20} years old!"); */

/* decimal result = 7m / 2m;
Console.WriteLine(result); */

/* Console.Write("Enter bill amount: ");
decimal Billamount = decimal.Parse(Console.ReadLine());
Console.Write("Enter tip amount: ");
decimal TipAmount = decimal.Parse(Console.ReadLine());
decimal TotalAmount = Billamount + TipAmount;
decimal tipPercentage = (TipAmount / Billamount) * 100;
Console.WriteLine($"Your total is : {TotalAmount} \nYour tip percentage is : {tipPercentage:F2}%");
*/

// tupless

/* var pt = (x: 50, y: 2);
var slope = (double)pt.x/(double)pt.y;
Console.WriteLine($"The slope of points {pt}, is {slope}"); 

string choice;
var names = (Firstname : "", lastname : "");
do{
Console.WriteLine("Enter your first and last names: ");
names = (Firstname : Console.ReadLine(),
lastname : Console.ReadLine());
Console.WriteLine($"Your firstname is {names.Firstname}, your last name is {names.lastname}\nIs that correct? (Y/N)");
choice = Console.ReadLine();
}while(choice.ToUpper() =="N");
Console.WriteLine($"Your name {names.Firstname} {names.lastname} is set"); */

//dynamic arrays

/* (List<string> names = [];
Console.WriteLine("Enter 5 names: ");
for(int i = 0; i<5; i++)
{
    names.Add(Console.ReadLine());
}
foreach (string name in names)
{
    Console.WriteLine(name);
} */

/* List<string> names  = [];

Console.WriteLine("Enter your names pretty plewase : ");

while (true)
{
    string name = Console.ReadLine();
    if (string.IsNullOrEmpty(name))
    {
        break;
    }
    names.Add(name);
}
Console.Write("Your names are: ");
foreach(string name in names)
{
    Console.Write(name + ", ");
}
*/
//generics

/* List<string> show = [];

void showdata(List<string>show)
{
    foreach (string item in show)
    {
        Console.WriteLine(item);   
         }
}
Console.WriteLine("program started");

Console.Write("Are you ready to enter your details? (Y/N) : ");
string? choice  = Console.ReadLine();
if(choice.ToUpper() == "Y")
{ 
    Console.WriteLine("Enter your details : ");
    while (true)
{
   
    var detail = Console.ReadLine();
    if (string.IsNullOrEmpty(detail))
    {
        break;
    }
    show.Add(detail);
}
showdata(show);
}


    else
    {
        Console.WriteLine("Alr, have a nice day cya");
    }

*/

//methods, out and ref param

/* int x;

void doublenum(out int x){
    x =  23;
}

doublenum(out x);

Console.WriteLine(x);*/

/* bool tf = int.TryParse(Console.ReadLine(), out int x);
Console.WriteLine(tf);
Console.WriteLine(x); */

/* int x = 10;
void change (ref int x)
{
    x = 20;
}

void change2 (int x)
{
    x = 20;
}
change2(x);
Console.WriteLine(x);
change (ref x);
Console.WriteLine(x); */

/* bool success = int.TryParse(Console.ReadLine(), out int x);
int? result = success ? x : null;
Console.WriteLine(result ?? 1234); */



