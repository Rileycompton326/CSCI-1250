/*
* Name: Riley Compton
* Course: CSCI 1250, Section 002
* Assignment: Lab 06, Three Short Problems
* Date: October 23, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/
using System.Runtime.CompilerServices;

//The Menu
Random rng = new Random(4000);

int choice;
const int choiceOne = 1;
const int choiceTwo = 2;
const int choiceThree = 3;
const int choiceAll = 4;
const int leaveValue = 5;

//whole function
do
{
    
//section layout info   
Console.WriteLine("\n=== CSCI 1250 Lab 06 ===");
System.Console.WriteLine("1. The Grade Checker");
System.Console.WriteLine("2. The Dice Table");
System.Console.WriteLine("3. The Score Report");
System.Console.WriteLine("4. All three");
System.Console.WriteLine("5. Quit");

//choice
System.Console.Write("Choose an integer 1-5: ");
choice = Convert.ToInt32(Console.ReadLine());

//pick again if out of scope
while (choice < choiceOne || choice > leaveValue)
{
    System.Console.WriteLine("Choose an integer  1-5.");
    System.Console.Write("Choose 1-5: ");
    choice = Convert.ToInt32(Console.ReadLine());
}

if(choice == choiceOne || choice == choiceAll)
{

bool validInput = false;
char gradeLetter;

System.Console.WriteLine("\n=== Exercise 1: The Grade Checker ===");

while (!validInput)
{

System.Console.Write("Score: ");
int gradeNum = Convert.ToInt32(Console.ReadLine());

if (gradeNum >= 0 && gradeNum <= 100)
{

gradeNum = Convert.ToInt32(gradeNum);
validInput = true;

if(gradeNum >= 90)
{
gradeLetter = 'A';
}

else if(gradeNum >= 80)
{
gradeLetter = 'B';
}

else if(gradeNum >= 70)
{
gradeLetter = 'C';
}

else if(gradeNum >= 60)
{
gradeLetter = 'D';
}

else
{
gradeLetter = 'F';
}

System.Console.WriteLine($"{gradeNum} earns a {gradeLetter}.");
}

else
{
System.Console.WriteLine("A score must be between 0 and 100.");
}
}
}

if(choice == choiceTwo || choice == choiceAll)
{
char rollAgain = 'y';
int rollAmount = 0;
int wonAmount = 0;

System.Console.WriteLine("\n=== Exercise 2: The Dice Table ===");

while(rollAgain != 'n')
{
rollAmount++;

const int snakeEyeValue = 1;
const int diceWinSeven = 7;
const int diceWinEleven = 11;
int diceRoll = rng.Next(1,7);
int anotherDiceRoll = rng.Next(1,7);
int totalDiceAmount = diceRoll + anotherDiceRoll;
string outcome;
    
if (diceRoll == snakeEyeValue && anotherDiceRoll == snakeEyeValue)
{
outcome = "Snake eyes.";
}
else if(diceRoll == anotherDiceRoll)
{
outcome = "Doubles!";
}
else if(totalDiceAmount == diceWinSeven || totalDiceAmount == diceWinEleven)
{
outcome = "A winner.";
wonAmount++;
}

else
{
outcome = "";
}

System.Console.WriteLine($"Roll {rollAmount}: {diceRoll} and {anotherDiceRoll}, total {totalDiceAmount}. {outcome}");
System.Console.WriteLine("Roll again? (y/n): ");
rollAgain = Console.ReadLine()![0];
}
System.Console.WriteLine($"You rolled {rollAmount} times and won {wonAmount}.");
}
    

if(choice == choiceThree || choice == choiceAll)
{
int[] scoreValues = new int[5];
int total = 0;
int passingAmount = 0;
const int passingScoreMin = 60;

System.Console.WriteLine("\n=== Exercise 3: The Score Report ===");

for(int i = 0; i < scoreValues.Length; i++)
{
System.Console.WriteLine($"Score {i + 1}: ");
scoreValues[i] = Convert.ToInt32(Console.ReadLine());
}

int max = scoreValues.Max();

foreach(int score in scoreValues)
{
total += score;
            
if(score >= passingScoreMin)
{
passingAmount++;
}
}

double average = Convert.ToDouble(total)/scoreValues.Length;

System.Console.WriteLine($"\nScores entered: {scoreValues.Length}");
System.Console.WriteLine($"Total: {total}");
System.Console.WriteLine($"Average: {average}");
System.Console.WriteLine($"Highest: {max}");
System.Console.WriteLine($"Passing: {passingAmount} of {scoreValues.Length}");
}
}
while(choice != leaveValue);

//ending
Console.WriteLine("/nGoodbye." );