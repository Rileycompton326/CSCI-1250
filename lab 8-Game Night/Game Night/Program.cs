/*
* Name: Riley Compton
* Course: CSCI 1250, Section 002
* Assignment: Lab 08, Game Night
* Date: November 18, 2026
* Description: Keeps a game night leaderboard in three text files. Shows the
* season so far, records tonight's points, saves the new totals,
* and adds tonight's result to a history that grows every week.
*/

const string PLAYERS_FILE = "players.txt";
const string POINTS_FILE = "points.txt";
const string HISTORY_FILE = "history.txt";
const int MAX_POINTS = 20;

// Look for the files in my lab 8 folder
string projectFolder = Path.GetFullPath(
    Path.Combine(AppContext.BaseDirectory, "..", "..", ".."));
Directory.SetCurrentDirectory(projectFolder);

// ---------- Methods ----------
static int LeaderIndex(string[] points)
{
    
    int leader = 0;
    for (int i = 1; i < points.Length; i++)
    {
        if (Convert.ToInt32(points[i]) > Convert.ToInt32(points[leader]))
        {
            leader = i;
        }
    }
    return leader;
}

static int TotalPoints(string[] points)
{
    // returns the total sum
    int total = 0;
    foreach (string p in points)
    {
        total += Convert.ToInt32(p);
    }
    return total;
}

// returns a statement with my histroy info
static string HistoryEntry(int night, string winner, int points)
{
    return $"Night {night}: {winner} won with {points} points";
}

// Part 1: 
string[] players = File.ReadAllLines(PLAYERS_FILE);
string[] points = File.ReadAllLines(POINTS_FILE);

 Console.WriteLine("PLAYER".PadRight(11) + "POINTS");

for (int i = 0; i < players.Length; i++)
{
    Console.WriteLine(players[i].PadRight(11) + points[i]);
}

int leader = LeaderIndex(points);
Console.WriteLine($"Leader: {players[leader]} with {points[leader]}");

int total = TotalPoints(points);
Console.WriteLine($"Season total: {total}");

// Part 2
int bestTonight = -1;
string winnerTonight = "";

for (int i = 0; i < players.Length; i++)
{
    int tonight;
    while (true)
    {
        Console.Write($"Points tonight for {players[i]}: ");
        tonight = Convert.ToInt32(Console.ReadLine());

        if (tonight >= 0 && tonight <= MAX_POINTS)
            break;

        Console.WriteLine("Points must be from 0 to 20.");
    }

int season = Convert.ToInt32(points[i]) + tonight;
points[i] = season.ToString();

    if (tonight > bestTonight)
    {
        bestTonight = tonight;
        winnerTonight = players[i];
    }
}

Console.WriteLine($"Tonight's winner: {winnerTonight} with {bestTonight}");

File.WriteAllLines(POINTS_FILE, points);
Console.WriteLine("Saved points.txt.");


// Part 3
string[] history = File.ReadAllLines(HISTORY_FILE);

Console.WriteLine("=== GAME NIGHT LEADERBOARD ===");

if (history.Length == 0)
{
    Console.WriteLine("No nights played yet.");
    Console.WriteLine("Tonight is Night 1.");
}
else
{
    Console.WriteLine($"Nights played: {history.Length}");

    // foreach: every previous night is just text
    foreach (string line in history)
    {
        Console.WriteLine("  " + line);
    }

    Console.WriteLine($"Tonight is Night {history.Length + 1}.");
}

Console.WriteLine();

int tonightNumber = history.Length + 1;

string[] entry = { HistoryEntry(tonightNumber, winnerTonight, bestTonight) };
File.AppendAllLines(HISTORY_FILE, entry);

// adds to my history.txt
Console.WriteLine($"Added to history.txt: {entry[0]}");
