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

Console.WriteLine("Student ID: " + rng.Next(100000, 1000000));
Console.WriteLine("Locker: " + rng.Next(1, 501));


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