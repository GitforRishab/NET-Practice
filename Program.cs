/* using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World! \nIm Rishab Hari"); */

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

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

/*var pt = (x: 50, y: 2);
var slope = (double)pt.x/(double)pt.y;
Console.WriteLine($"The slope of points {pt}, is {slope}"); */
string choice;
var names = (Firstname : "", lastname : "");
do{
Console.WriteLine("Enter your first and last names: ");
names = (Firstname : Console.ReadLine(),
lastname : Console.ReadLine());
Console.WriteLine($"Your firstname is {names.Firstname}, your last name is {names.lastname}\nIs that correct? (Y/N)");
choice = Console.ReadLine();
}while(choice.ToUpper() =="N");
Console.WriteLine($"Your name {names.Firstname} {names.lastname} is set");
