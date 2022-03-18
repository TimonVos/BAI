using Week1Opdracht8;

const int NoOfPlayers = 7;

int BuzzNum = 1;
bool Running = true;
char[] PlayerNames = { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
int[] PlayerNoOfBuzzes = { 0, 0, 0, 0, 0, 0, 0 };
int PlayerTurn = 0;

Console.WriteLine("Welcome to Buzz!\npress any key to begin");
Console.ReadKey();


Console.WriteLine("Player A begins!");


while (BuzzNum < 10000000 && Running) // maybe add a bool to exit the while loop
{
    Console.WriteLine(PlayerNames[PlayerTurn] + ": ");
    
    if (ContainsSeven(BuzzNum))
    {
        string inputtedBuzz = Console.ReadLine().Trim();
        if (inputtedBuzz.ToLower() == "buzz")
        {
            PlayerNoOfBuzzes[PlayerTurn]++;
            BuzzNum++;
        } else
        {
            Running = false;
        }
    } else
    {
        int inputtedNum = int.Parse(Console.ReadLine());
        if (inputtedNum == BuzzNum)
        {
            BuzzNum++;
        } else
        {
            Running = false;
        }
    }
    if (PlayerTurn < (NoOfPlayers - 1))
    {
        PlayerTurn++;
    } else
    {
        PlayerTurn = 0;
    }

}

for (int player = 0; player < NoOfPlayers; player++)
{
    Console.WriteLine($"{PlayerNames[player]} Number of BUZZes: {PlayerNoOfBuzzes[player]}");
}



static bool ContainsSeven(int FullInt)
{
    int checkNum;
    for (int TableOfSeven = 7; TableOfSeven < 10000000; TableOfSeven += 7)
    {
        if (FullInt == TableOfSeven)
        {
            return true;
        }
    }
    while (FullInt != 0)
    {
        checkNum = FullInt % 10;
        FullInt = FullInt / 10;

        if (checkNum == 7)
        {
            return true;
        }
    }

    return false;
}