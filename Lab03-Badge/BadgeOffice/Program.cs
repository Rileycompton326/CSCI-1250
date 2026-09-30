/*
* Name: Riley Compton
* Course: CSCI 1250, Section 002
* Assignment: Lab 03, The Badge Office
* Date: September 30, 2026
* Description: Builds a student badge from a name, two random assignments,
* and the walking distance to a first class.
*/

//Part 1//
Console.Write("Full Name: ");
string fullName = Console.ReadLine();
fullName = fullName.Trim();

int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);

string username = firstName.Substring(0, 1) + lastName;
string lowerUsername = username.ToLower();
string firstInitials = firstName.Substring (0,1);
string lastInitials = lastName.Substring (0,1);
int lastNameLength = lastName.Length;
Console.WriteLine($"Name On Badge : {firstName} {lastName}");
Console.WriteLine($"Username: {lowerUsername}"); 
Console.WriteLine($"Inititals: {firstInitials},{lastInitials}. ");
Console.WriteLine($"letters In Last Name: {lastNameLength}");


//Part 2//
Random rng = new Random();
int studentID = rng.Next(100000, 1000000);   
int lockerNumber = rng.Next(1, 501); 

Console.WriteLine ("Student ID:" + studentID);
Console.WriteLine ("Locker: " + lockerNumber);
Console.WriteLine();

//Part 3//
Console.Write("Dorm x: ");
double dormX = Convert.ToDouble(Console.ReadLine());

Console.Write("Dorm y: ");
double dormY = Convert.ToDouble(Console.ReadLine());

Console.Write("Class x: ");
double classX = Convert.ToDouble(Console.ReadLine());

 Console.Write("Class y: ");
double classY = Convert.ToDouble(Console.ReadLine());

Console.Write("Walking speed in feet per second: ");
double speed = Convert.ToDouble(Console.ReadLine());

//Math//
double deltaX = classX - dormX;
double deltaY = classY - dormY;
double distance = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
distance = Math.Round(distance, 1);          // one decimal place

 
double totalSecondsDouble = distance / speed;
int totalSeconds = (int)Math.Round(totalSecondsDouble);  // whole seconds
int minutes = totalSeconds / 60;
int seconds = totalSeconds % 60;

Console.WriteLine("Distance: " + distance + " feet");
Console.WriteLine("Walk time: " + minutes + " minutes " + seconds + " seconds");
Console.WriteLine();

//Part 4//
int checkDigit = studentID % 9;
string fullID = studentID + "-" + checkDigit;
string bar = "==================================";
Console.WriteLine(bar);
Console.WriteLine("ETSU STUDENT BADGE");
Console.WriteLine(bar);
Console.WriteLine("NAME".PadRight(10) + username);
Console.WriteLine("USERNAME".PadRight(10) + username);
Console.WriteLine("ID".PadRight(10) + fullID);
Console.WriteLine("LOCKER".PadRight(10) + lockerNumber);
Console.WriteLine("WALK".PadRight(10) + minutes + " min " + seconds + " sec");
Console.WriteLine(bar);