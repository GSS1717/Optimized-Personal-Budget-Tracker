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
Console.WriteLine("Press any key to enter the main menu...");
Console.ReadKey(); // Wait for user to acknowledge the welcome message

// This is the main application loop. It will run indefinitely until the user
// chooses to exit, which we will implement later.
while (true)
{
    // On each iteration, first clear the console to keep the display clean.
    Console.Clear();

    // Now, display the main menu options to the user.
    Console.WriteLine("=====================================");
    Console.WriteLine("   Personal Budget Tracker Menu");
    Console.WriteLine("=====================================");
    Console.WriteLine("1. Add Income");
    Console.WriteLine("2. Add Expense");
    Console.WriteLine("3. View All Transactions");
    Console.WriteLine("4. View Balance Summary");
    Console.WriteLine("5. Save & Exit");
    Console.WriteLine("=====================================");
    Console.Write("Please select an option: "); // Use Console.Write to keep cursor on same line
                                                // highlight-end
    string userChoice = Console.ReadLine();
    // The code to read and handle user input will go here in the next task.
    // For now, we will add a temporary ReadKey to pause the loop.
    switch (userChoice)
    {
        case "1":
            HandleAddIncome();
            break; // 'break' is essential to exit the switch block
        case "2":
            HandleAddExpense();
            break;
        case "3":
            DisplayAllTransactions();
            break;
        case "4":
            DisplaySummary();
            break;
        case "5":
            // We will implement the save and exit logic in a later task.
            // For now, it's a placeholder.
            Console.WriteLine("Saving and exiting... Feature to be implemented.");
            Console.ReadKey();
            break;
        default:
            // The default case handles any input that doesn't match a case.
            Console.WriteLine("Invalid option. Please try again.");
            Console.ReadKey(); // Pause to let the user read the message
            break;
    }
}

#region Menu Action Methods

/// <summary>
/// Placeholder method for handling the 'Add Income' action.
/// </summary>
private static void HandleAddIncome()
{
    Console.Clear();
    Console.WriteLine("Add Income feature is not yet implemented.");
    Console.WriteLine("Press any key to return to the menu.");
    Console.ReadKey();
}

/// <summary>
/// Placeholder method for handling the 'Add Expense' action.
/// </summary>
private static void HandleAddExpense()
{
    Console.Clear();
    Console.WriteLine("Add Expense feature is not yet implemented.");
    Console.WriteLine("Press any key to return to the menu.");
    Console.ReadKey();
}

/// <summary>
/// Placeholder method for displaying all transactions.
/// </summary>
private static void DisplayAllTransactions()
{
    Console.Clear();
    Console.WriteLine("View All Transactions feature is not yet implemented.");
    Console.WriteLine("Press any key to return to the menu.");
    Console.ReadKey();
}

/// <summary>
/// Placeholder method for displaying the budget summary.
/// </summary>
private static void DisplaySummary()
{
    Console.Clear();
    Console.WriteLine("View Balance Summary feature is not yet implemented.");
    Console.WriteLine("Press any key to return to the menu.");
    Console.ReadKey();
}

#endregion