// Part 1: The Name

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
