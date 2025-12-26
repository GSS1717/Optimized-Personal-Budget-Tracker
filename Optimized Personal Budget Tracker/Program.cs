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

// In the next tasks, we will build out the main application loop here.