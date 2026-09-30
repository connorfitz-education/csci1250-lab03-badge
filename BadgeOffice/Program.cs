/*
* Name: Connor M Fitzgerald
* Course: CSCI 1250, Section 002
* Assignment: Lab 03, The Badge Office
* Date: September 30, 2026
* Description: Builds a student badge from a name, two random assignments,
* and the walking distance to a first class.
*/

Console.Write("Welcome to the Badge Creator \nPlease enter your full name: ");

string fullName = Console.ReadLine().Trim();

string lastName = fullName.Substring(fullName.IndexOf(" ")+1);
string firstName = fullName.Substring(0, fullName.IndexOf(" ")-1);
string username = (firstName.Substring(0,1) + lastName).ToLower();

System.Console.WriteLine($"\nName on badge: {fullName.ToUpper()}");
System.Console.WriteLine($"Username: {username}");
System.Console.WriteLine($"Initials: {firstName.Substring(0,1).ToUpper()}.{lastName.Substring(0,1).ToUpper()}.");
System.Console.WriteLine($"Letters in last name: {lastName.Length}\n");

Random rng = new Random();
int studentID = rng.Next(100000,1000000);
int studentLocker = rng.Next(1,501);
System.Console.WriteLine($"Student ID: {studentID}");
System.Console.WriteLine($"Student ID: {studentLocker}");
