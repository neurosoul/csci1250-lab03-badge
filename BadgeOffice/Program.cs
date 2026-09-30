/*
* Name: Zander Malone
* Course: CSCI 1250, Section 001
* Assignment: Lab 03, The Badge Office
* Date: September 30, 2026
* Description: Builds a student badge from a name, two random assignments,
* and the walking distance to a first class.
*/

// Part 1: The Name

using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

Console.WriteLine("What is your first and last name? ");
string fullName = Console.ReadLine();
fullName = fullName.Trim();


int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);



Console.WriteLine("Name on Badge: " + fullName);

Console.WriteLine("Username: " +  fullName.Substring(0,1).ToLower() + lastName.ToLower() );

Console.WriteLine("Initials: " + fullName.Substring(0,1).ToUpper() + "." + fullName.Substring(spacePosition +1, 1) + ".");

Console.WriteLine("Letters in last name: " + (lastName).Length );

//Part 2: The Numbers
Console.WriteLine(" ");
Console.WriteLine("ID AND LOCKER:");

Random rng = new Random();

int studentID = rng.Next(100000, 1000000);
Console.WriteLine("Student ID: " + studentID);
int lockerNum = rng.Next(1, 501);
Console.WriteLine("Locker: " + lockerNum);


//Part 3: The Walk
Console.WriteLine(" ");

Console.WriteLine("What is your dorm's x coordinate? ");
int dormX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is your dorm's y coordinate? ");
int dormY = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is your classroom's x coordinate? ");
int classX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is your classroom's y coordinate? ");
int classY = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is your walking speed in feet per second? ");
int walkSpeed = Convert.ToInt32(Console.ReadLine());


double distance = Convert.ToDouble(Math.Sqrt(Math.Pow(classX - dormX, 2) + Math.Pow(classY - classX, 2)));

int walkTimeMin = Convert.ToInt32(distance) / walkSpeed;
int walkTimeSec = Convert.ToInt32(distance) % walkSpeed;

Console.WriteLine("Distance: " + distance.ToString("F1") + " feet");
Console.WriteLine("Walk time: " + walkTimeMin + " minutes " + walkTimeSec + " seconds");

//Part 4: The Badge
Console.WriteLine(" ");

int checkDigit = studentID % 9;

Console.WriteLine("==================================");
Console.WriteLine("ETSU STUDENT BADGE".PadLeft(10));
Console.WriteLine("==================================");
Console.WriteLine("NAME".PadRight(10) + fullName);
Console.WriteLine("USERNAME".PadRight(10) + fullName.Substring(0,1).ToLower() + lastName.ToLower());
Console.WriteLine("ID".PadRight(10) + studentID + "-" + checkDigit);
Console.WriteLine("LOCKER".PadRight(10) + lockerNum);
Console.WriteLine("WALK".PadRight(10) + walkTimeMin + " min " + walkTimeSec + "sec");
Console.WriteLine("==================================");
