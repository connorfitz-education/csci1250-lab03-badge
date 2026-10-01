/*
* Name: Connor M Fitzgerald
* Course: CSCI 1250, Section 002
* Assignment: Lab 03, The Badge Office
* Date: September 30, 2026
* Description: Builds a student badge from a name, two random assignments,
* and the walking distance to a first class.
*/

//Section 1
Console.Write("Welcome to the Badge Creator, please respond to the prompts.\n\nFull name: ");

string fullName = Console.ReadLine().Trim();
while(!fullName.Contains(" ") || fullName.Any(char.IsDigit))
{
    System.Console.Write("\nError! improper format, please enter your name in the format 'FirstName LastName'\nFull name: ");
    fullName = Console.ReadLine().Trim();
}
string lastName = fullName.Substring(fullName.IndexOf(" ")+1);
string firstName = fullName.Substring(0, fullName.IndexOf(" ")-1);
string username = (firstName.Substring(0,1) + lastName).ToLower();

System.Console.WriteLine($"Name on badge: {fullName.ToUpper()}");
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
System.Console.Write("\nPlease respond to the following prompts:\n\n");
System.Console.WriteLine("What are your Dorm Coordinates?");

System.Console.Write("Dorm X: ");
string? dormInputX = Console.ReadLine();
while(!dormInputX.All(char.IsDigit)){
    Console.Write("Please enter a valid integer\nDorm X: ");
    dormInputX = Console.ReadLine();
}
int dormX = Convert.ToInt32(dormInputX);

System.Console.Write("Dorm Y: ");
string? dormInputY = Console.ReadLine();
while(!dormInputY.All(char.IsDigit)){
    Console.Write("Please enter a valid integer\nDorm Y: ");
    dormInputY = Console.ReadLine();
}
int dormY = Convert.ToInt32(dormInputY);

System.Console.WriteLine("What are your Class Coordinates?");

System.Console.Write("Class X: ");
string? classInputX = Console.ReadLine();
while(!classInputX.All(char.IsDigit)){
    Console.Write("Please enter a valid integer\nClass X: ");
    classInputX = Console.ReadLine();
}
int classX = Convert.ToInt32(classInputX);

System.Console.Write("Class Y: ");
string? classInputY = Console.ReadLine();
while(!classInputY.All(char.IsDigit)){
    Console.Write("Please enter a valid integer\nClass X: ");
    classInputY = Console.ReadLine();
}
int classY = Convert.ToInt32(classInputY);

System.Console.WriteLine("How fast do you walk?");
System.Console.Write("Walking speed (ft/s): ");
string? walkInput = Console.ReadLine();
while (walkInput.Any(char.IsAsciiLetter)){
    Console.Write("Please enter a valid integer or decimal\nWalking speed (ft/s): ");
    walkInput = Console.ReadLine();
}
double walkSpeed = Convert.ToDouble(walkInput);

double distance = Math.Sqrt(Math.Pow(classX - dormX, 2)+ Math.Pow(classY - dormY, 2));
System.Console.WriteLine($"\nDistance: {Math.Round(distance, 2)} feet");
int walkTimeMin = (int)distance/(int)walkSpeed/60;
double walkTimeSec = Math.Round(distance/walkSpeed%60, 0);

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
System.Console.WriteLine("WALK".PadRight(10) + walkTimeMin + " minute(s) " + walkTimeSec + " seconds\n");
