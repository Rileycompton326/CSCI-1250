using System;

class Program
{
static void Main(string[] args)
{

string[] names = { "Riley Compton", "Katherine Smith", "John Doe", "Emily Johnson", "Alex Brown" };

string[] usernames = new string[names.Length];
string[] studentIDs = new string[names.Length];

for (int i = 0; i < names.Length; i++)
 {
usernames[i] = MakeUsername(names[i]);
studentIDs[i] = "S" + (1000 + i);          // simple ID example
}

Console.WriteLine("=== Generated Student Accounts ===");
for (int i = 0; i < names.Length; i++)
{
Console.WriteLine($"{names[i]} → {usernames[i]} | ID: {studentIDs[i]}");
 }

int choice;
do
{
Console.Write("\nEnter student number (1-" + names.Length + ") or -1 to quit: ");
choice = Convert.ToInt32(Console.ReadLine());

if (choice == -1)
{
Console.WriteLine("Goodbye!");
}
else if (choice >= 1 && choice <= names.Length)
 {
int index = choice - 1;
Console.WriteLine($"\nName: {names[index]}");
Console.WriteLine($"Username: {usernames[index]}");
Console.WriteLine($"Student ID: {studentIDs[index]}");
            }
            else
            {
                Console.WriteLine("Invalid choice. Try again.");
 }

  } while (choice != -1);
  }
static string MakeUsername(string fullName)
    {
 string[] parts = fullName.Split(' ');
string firstInitial = parts[0].Substring(0, 1).ToLower();
 string lastName = parts[parts.Length - 1].ToLower();
 return firstInitial + lastName;
    }
}
