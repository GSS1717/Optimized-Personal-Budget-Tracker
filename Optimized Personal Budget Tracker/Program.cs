using System.Runtime.CompilerServices;

// We need to bring our custom namespaces into scope to use our services.
using Optimized_Personal_Budget_Tracker;

// The default Program.cs in newer .NET versions uses top-level statements.
// We will declare our services here, making them accessible throughout the file.

// 1. Instantiate the DataStorageService. 
// We need this first to load any existing data.
// We make it static so it's a single instance for the entire application's lifetime.
private static readonly DataStorageService _dataStorageService = new DataStorageService();

List<Transaction> loadedTransactions = _dataStoragesrvice.LoadTransactions();

// 2. Instantiate the BudgetService.
// This will be the central hub for all our business logic operations.
private static readonly BudgetService _budgetService = new BudgetService(loadedTransactions);

// The rest of your Program.cs Main method logic will go here.
// For example:
Console.WriteLine("Welcome to the Personal Budget Tracker!");
Console.WriteLine("All data has been loaded successfully.");

// This is the main application loop. It will run indefinitely until the user
// chooses to exit, which we will implement later.
while (true)
{
    // In the upcoming tasks, this is where we will clear the console,
    // display the menu, and handle user input.

    // For now, this loop is the foundational structure that keeps our application alive.
    // We'll add a temporary halt to prevent it from spinning infinitely fast
    // and consuming CPU. This line can be removed once we add input handling.
    System.Threading.Thread.Sleep(5000); // Wait for 5 seconds
}