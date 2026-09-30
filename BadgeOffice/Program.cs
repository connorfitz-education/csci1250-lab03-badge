Console.Write("Welcome to the Badge Creator \nPlease enter your full name: ");

string? fullName = Console.ReadLine().Trim();

string lastName = fullName.Substring(fullName.IndexOf(" ")+1);
string firstName = fullName.Substring(0, fullName.IndexOf(" ")-1);
string username = (firstName.Substring(0,1) + lastName).ToLower();

System.Console.WriteLine($"Name on badge: {fullName.ToUpper()}");
System.Console.WriteLine($"Username: {username}");
System.Console.WriteLine($"Initials: {firstName.Substring(0,1).ToUpper()}.{lastName.Substring(0,1).ToUpper()}.");
System.Console.WriteLine($"Letters in last name: {lastName.Length}");