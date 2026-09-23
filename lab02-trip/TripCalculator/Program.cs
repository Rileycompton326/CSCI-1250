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
double totalSlices = foodAmount * 8;

double slicesPerPerson = totalSlices / peopleGoing;

double pizzaCost = foodAmount * pricePerPizza;

//output
System.Console.WriteLine("Total Slices: ");
System.Console.WriteLine("Slices Per Person: "+ slicesPerPerson.ToString("F2"));
System.Console.WriteLine("Total Price: " + pizzaCost.ToString("C"));


//part 3
Console.Write("What was the hours worked this week? ");
int hoursWorked = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the hourly rate? ");
int hourlyRate = Convert.ToInt32(Console.ReadLine());

//do the math
double grossPay = hoursWorked * hourlyRate;

double taxHeld = grossPay * 18;

double takeHomePay = grossPay - taxHeld;

//output
System.Console.WriteLine("Gross Pay: ");
System.Console.WriteLine("Tax WithHeld: " + taxHeld.ToString("F2"));
System.Console.WriteLine("Take Home Pay: "+ takeHomePay.ToString("C"));


//part 4
//do the math
double tripTotal = fuelCost + pizzaCost;

double costPerPerson = tripTotal / peopleGoing;

double homePayPerHour = takeHomePay / hoursWorked;

double mustWork = costPerPerson / homePayPerHour;

//do the output
System.Console.WriteLine("Trip Total: " + tripTotal.ToString("F2"));
System.Console.WriteLine("Cost Per Person: " + costPerPerson.ToString("F2"));
System.Console.WriteLine("Take Home Pay Per Hour: "+ homePayPerHour.ToString("F2"));
System.Console.WriteLine("HoursMust Work: " + mustWork.ToString("C"));
