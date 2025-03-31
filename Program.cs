Console.Clear();
Console.WriteLine("Hello, World!");

int sticks = 45;
int player = 1;
int take;

Console.WriteLine("Welcome to the Game of Sticks!");
Console.WriteLine("Players take turns removing 1-5 sticks. The player who removes the last stick loses.\n");

int v = (player == 1) ? 2 : 1;

while (sticks > 1) // Continue until one stick is left
{
    // Display sticks visually
    Console.WriteLine(new string('|', sticks));
    Console.WriteLine($"Sticks left: {sticks}");

    // Player input
    Console.Write($"Player {player}, how many sticks would you like to take? (1-5): ");
    while (!int.TryParse(Console.ReadLine(), out take) || take < 1 || take > 5 || take > sticks)
    {
        Console.Write($"Invalid choice. Please enter a number between 1 and 5 (up to {sticks} remaining): ");
    }

    sticks -= take;

    // Check if game ends
    if (sticks == 0)
    {
        Console.Clear();
        Console.WriteLine(new string('|', sticks));
        Console.WriteLine($"Sticks left: {sticks}");
        Console.WriteLine($"Player {player} loses!");
        // Announce winner (the player who did not take the last stick)
        int winner = (player == 1) ? 2 : 1;
        Console.WriteLine($"Player {winner} wins! Game Over.");
        break;
    }
    player = player != 1 ? 1 : 2;
}
