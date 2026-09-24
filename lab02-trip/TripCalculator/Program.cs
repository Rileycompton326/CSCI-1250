/*
* Name: Riley Compton
* Course: CSCI 1250, Section 002
* Assignment: Lab 02, Trip Calculator
* Date: September 23, 2026
* Description: Calculates the fuel, food, and work hours behind one road trip.
*/

Console.Write("What was the round trip in miles? ");
int milesForTheTrip = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the miles per gallon of the car you are using? ");
int milesPerGallon = Convert.ToInt32(Console.ReadLine());

Console.Write("What was the gas price? ");
double gasPrice = Convert.ToDouble(Console.ReadLine());

//do the math

    double gallonsNeeded = milesForTheTrip / (double)milesPerGallon;

    double fuelCost =  gallonsNeeded * gasPrice;
    
// do the output
System.Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
System.Console.WriteLine("Fuel Cost: " + fuelCost.ToString("C"));


//part 2
Console.Write("How many people are going? ");
int peopleGoing = Convert.ToInt32(Console.ReadLine());

Console.Write("How many Pizzas? ");
int foodAmount = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the price per Pizza? ");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());

//do the math
const int slicesPerPizza = 8;
double totalSlices = foodAmount * slicesPerPizza;

double slicesPerPerson = totalSlices / peopleGoing;

double pizzaCost = foodAmount * pricePerPizza;

//output
System.Console.WriteLine("Total Slices: "+ totalSlices.ToString("F2"));
System.Console.WriteLine("Slices Per Person: "+ slicesPerPerson.ToString("F2"));
System.Console.WriteLine("Total Price: " + pizzaCost.ToString("C"));


//part 3
Console.Write("What was the hours worked this week? ");
int hoursWorked = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the hourly rate? ");
double hourlyRate = Convert.ToDouble(Console.ReadLine());

//do the math
double grossPay = hoursWorked * hourlyRate;

const double taxRate=0.18;
double taxHeld = grossPay * taxRate;

double takeHomePay = grossPay - taxHeld;

//output
System.Console.WriteLine("Gross Pay: " + grossPay.ToString("C"));
System.Console.WriteLine("Tax WithHeld: " + taxHeld.ToString("C"));
System.Console.WriteLine("Take Home Pay: "+ takeHomePay.ToString("C"));


//part 4
//do the math
double tripTotal = fuelCost + pizzaCost;

double costPerPerson = tripTotal / peopleGoing;

double homePayPerHour = takeHomePay / hoursWorked;

double mustWork = costPerPerson / homePayPerHour;

//do the output
System.Console.WriteLine("Trip Total: " + tripTotal.ToString("C"));
System.Console.WriteLine("Cost Per Person: " + costPerPerson.ToString("C"));
System.Console.WriteLine("Take Home Pay Per Hour: "+ homePayPerHour.ToString("C"));
System.Console.WriteLine("Hours you must work to cover your share:" + mustWork.ToString("F2"));

