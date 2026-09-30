/*
* Name: Connor M Fitzgerald
* Course: CSCI 1250, Section 002
* Assignment: Lab 03, The Badge Office
* Date: September 30, 2026
* Description: Builds a student badge from a name, two random assignments,
* and the walking distance to a first class.
*/

//Section 1

Console.Write("Welcome to the Badge Creator\n\nPlease enter your full name: ");

string? fullName = Console.ReadLine().Trim();
string lastName = fullName.Substring(fullName.IndexOf(" ")+1);
string firstName = fullName.Substring(0, fullName.IndexOf(" ")-1);
string username = (firstName.Substring(0,1) + lastName).ToLower();

System.Console.WriteLine($"\nName on badge: {fullName.ToUpper()}");
System.Console.WriteLine($"Username: {username}");
System.Console.WriteLine($"Initials: {firstName.Substring(0,1).ToUpper()}.{lastName.Substring(0,1).ToUpper()}.");
System.Console.WriteLine($"Letters in last name: {lastName.Length}");

// Section 2
Random rng = new Random();
int studentID = rng.Next(100000,1000000);
int studentLocker = rng.Next(1,501);

System.Console.WriteLine($"\nStudent ID: {studentID}");
System.Console.WriteLine($"Student Locker: {studentLocker}");

// Secion 3
System.Console.Write("\nPlease enter your dorm's X coordinate: ");
string? dormInputX = Console.ReadLine(); int dormX = Convert.ToInt32(dormInputX);

System.Console.Write("\nPlease enter your dorm's Y coordinate: ");
string? dormInputY = Console.ReadLine(); int dormY = Convert.ToInt32(dormInputY);

System.Console.Write("\nPlease enter your class's X coordinate: ");
string? classInputX = Console.ReadLine(); int classX = Convert.ToInt32(classInputX);

System.Console.Write("\nPlease enter your class's Y coordinate: ");
string? classInputY = Console.ReadLine(); int classY = Convert.ToInt32(classInputY);

System.Console.Write("\nPlease enter your walking speed (ft/s): ");
string? walkInput = Console.ReadLine();
double walkSpeed = Convert.ToDouble(walkInput);

double distance = Math.Sqrt(Math.Pow(classX - dormX, 2)+ Math.Pow(classY - dormY, 2));
System.Console.WriteLine($"\nDorm X: {dormX}");
System.Console.WriteLine($"Dorm Y: {dormY}");
System.Console.WriteLine($"Class X: {classX}");
System.Console.WriteLine($"Dorm X: {classY}");
System.Console.WriteLine($"Walk speed: {walkSpeed}\n");
System.Console.WriteLine($"Distance: {Math.Round(distance, 2)} feet");
int walkTimeMin = (int)distance/(int)walkSpeed/60;
int walkTimeSec = (int)distance/(int)walkSpeed%60;

System.Console.WriteLine($"Walk time: {walkTimeMin} minutes {walkTimeSec} seconds\n");

// Section 4

System.Console.WriteLine("==================================");
System.Console.WriteLine("        ETSU STUDENT BADGE        ");
System.Console.WriteLine("==================================\n");
System.Console.WriteLine("NAME".PadRight(10) + fullName.ToUpper());
System.Console.WriteLine("USERNAME".PadRight(10) + username);
string idAndCheck = studentID + "-" + studentID%9;
System.Console.WriteLine("ID".PadRight(10) + idAndCheck);
System.Console.WriteLine($"LOCKER".PadRight(10) + studentLocker);
System.Console.WriteLine("WALK".PadRight(10) + walkTimeMin + " minute(s) " + walkTimeSec + " seconds");