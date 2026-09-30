/*
* Name: Connor M Fitzgerald
* Course: CSCI 1250, Section 002
* Assignment: Lab 03, The Badge Office
* Date: September 30, 2026
* Description: Builds a student badge from a name, two random assignments,
* and the walking distance to a first class.
*/

Console.Write("Welcome to the Badge Creator \nPlease enter your full name: ");

string? fullName = Console.ReadLine().Trim();

string lastName = fullName.Substring(fullName.IndexOf(" ")+1);
string firstName = fullName.Substring(0, fullName.IndexOf(" ")-1);
string username = (firstName.Substring(0,1) + lastName).ToLower();

System.Console.WriteLine($"\nName on badge: {fullName.ToUpper()}");
System.Console.WriteLine($"Username: {username}");
System.Console.WriteLine($"Initials: {firstName.Substring(0,1).ToUpper()}.{lastName.Substring(0,1).ToUpper()}.");
System.Console.WriteLine($"Letters in last name: {lastName.Length}");

Random rng = new Random();
int studentID = rng.Next(100000,1000000);
int studentLocker = rng.Next(1,501);
System.Console.WriteLine($"\nStudent ID: {studentID}");
System.Console.WriteLine($"Student ID: {studentLocker}");


System.Console.Write("Please enter your dorm's X coordinate: ");
string? dormInputX = Console.ReadLine(); int dormX = Convert.ToInt32(dormInputX);

System.Console.Write("Please enter your dorm's Y coordinate: ");
string? dormInputY = Console.ReadLine(); int dormY = Convert.ToInt32(dormInputY);

System.Console.Write("Please enter your class's X coordinate: ");
string? classInputX = Console.ReadLine(); int classX = Convert.ToInt32(classInputX);

System.Console.Write("Please enter your class's Y coordinate: ");
string? classInputY = Console.ReadLine(); int classY = Convert.ToInt32(classInputY);

System.Console.Write("Please enter your walking speed (ft/s): ");
string? walkInput = Console.ReadLine();
double walkSpeed = Convert.ToDouble(walkInput);

double distance = Math.Sqrt(Math.Pow(classX - dormX, 2)+ Math.Pow(classY - dormY, 2));
System.Console.WriteLine($"Distance: {Math.Round(distance, 2)} feet");
System.Console.WriteLine($"Walk time: {(int)(distance/walkSpeed)/60} minutes {(int)(distance/walkSpeed)%60} seconds");