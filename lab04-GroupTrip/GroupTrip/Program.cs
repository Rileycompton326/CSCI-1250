/*
* Name: Riley Compton
* Course: CSCI 1250, Section 002
* Assignment: Lab 04, The Group Trip
* Date: October 7, 2026
* Description: Rebuilds the trip calculator with methods and arrays so it
* reports on a whole group instead of one person.
*/

//Part 1

//Constants
const int slicesPerPizza = 8;
const double taxRate=0.18;

//Input
Console.Write("What was the round trip in miles? ");
int milesForTheTrip = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the miles per gallon of the car you are using? ");
int milesPerGallon = Convert.ToInt32(Console.ReadLine());

Console.Write("What was the gas price? ");
double gasPrice = Convert.ToDouble(Console.ReadLine());

Console.Write("How many pizzas? ");
double pizzaAmount = Convert.ToDouble(Console.ReadLine());

Console.Write("What is the cost per pizza ");
double pizzaCost = Convert.ToDouble(Console.ReadLine());

//Math
double fuelCost = FuelCost(milesForTheTrip, milesPerGallon, gasPrice);
  
double totalPizza = pizzaAmount * pizzaCost;

double totalCost = fuelCost + totalPizza;

//Output
System.Console.WriteLine("\n\n=== Part 1: The Trip ===");
System.Console.WriteLine($"Fuel cost: {fuelCost.ToString("C")}");
System.Console.WriteLine($"Pizza cost: {totalPizza.ToString("C")}");
System.Console.WriteLine($"Trip total: {totalCost.ToString("C")}\n\n");

//Part 2

//Input
string[] names = {"Ada", "Grace", "Alan", "Katherine"};
double[] hoursWorked = { 22, 15, 30, 18};
double [] hourlyRates = {13.50, 16.00, 11.20, 14.80};

//Math
int peopleGoing = names.Length;
double slicesPerPerson = pizzaAmount * slicesPerPizza / peopleGoing;
double costPerPerson = totalCost / peopleGoing;

//Output
System.Console.WriteLine("=== Part 2: The Group ===");
System.Console.WriteLine($"People going: {peopleGoing.ToString()}");
System.Console.WriteLine($"Slices each: {slicesPerPerson.ToString("F1")}");
System.Console.WriteLine($"Cost per person: {costPerPerson.ToString("C")}\n\n");

//Part 3 

//Constants
double totalHours = 0;
double totalTakeHome = 0;
double longest = 0;

System.Console.WriteLine("=== Part 3: Who Works How Long===\n");
for (int i = 0; i < names.Length; i++)

//Input
System.Console.WriteLine("=== Part 3: Who Works How Long===\n");
for (int i = 0; i < names.Length; i++)
{

//Math
double takeHomePay = TakeHomePay(hoursWorked[i], hourlyRates[i], taxRate);

double takeHomePayPerHours = takeHomePay / hoursWorked[i];

double hoursToCover = HoursToCover(costPerPerson, takeHomePayPerHours);

totalHours = totalHours += hoursWorked[i];
totalTakeHome = totalTakeHome += takeHomePay;
longest = Math.Max(longest, hoursToCover);

//output
System.Console.WriteLine($"{names[i]}: takes home {takeHomePay.ToString("C")} for {hoursWorked[i].ToString("F0")} hours, {takeHomePayPerHours.ToString("C")} per hour, must work {hoursToCover.ToString("f2")} hours");

System.Console.WriteLine($"\n\nTotal hours worked: {totalHours.ToString("F0")}");
System.Console.WriteLine($"Total take home pay: {totalTakeHome.ToString("C")}");

System.Console.WriteLine($"Longest anyone must work: {longest.ToString("F2")}");

//METHODS
static double FuelCost(double miles, double milesPerGallon, double pricePerGallon)
{ double gallons = miles / milesPerGallon;
return gallons * pricePerGallon;
}

static double TakeHomePay(double hours, double hourlyRate, double taxRate)
{ 
double grossPay = hours * hourlyRate;
double taxWithheld = grossPay * taxRate;
return grossPay - taxWithheld;
}

//HoursToCover, returns the amount each individual must pay divided by the their net take home pay
static double HoursToCover(double amountOwed, double takeHomePayPerHour)
{   return amountOwed/takeHomePayPerHour;
}}
