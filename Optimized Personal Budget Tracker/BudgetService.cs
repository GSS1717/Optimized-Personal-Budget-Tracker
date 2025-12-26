using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimized_Personal_Budget_Tracker
{
    /// <summary>
    /// Manages the collection of transactions and provides business logic
    /// for calculating budget summaries. This class is the central point
    /// for all transaction-related operations.
    /// </summary>
    public class BudgetService
    {
        
        // This is the private field that will hold all our transaction objects in memory.
        // It's initialized here to ensure it's never null.
        private readonly List<Transaction> _transactions = new List<Transaction>();

        public BudgetService(List<Transaction> intialTransaction)
        {
            _transactions = intialTransaction ?? new List<Transaction>();
        }

        /// <summary>
        /// Adds a new transaction to the service's internal list.
        /// This is the primary method for introducing new data into the budget.
        /// </summary>
        /// <param name="transaction">The transaction object to add. It must not be null.</param>
        public void AddTransaction(Transaction transaction)
        {
            // A good practice is to validate input parameters.
            // We check if the provided transaction is null to prevent errors.
            if (transaction == null)
            {
                // Throwing an exception is the standard way to handle invalid arguments
                // that indicate a programming error.
                throw new ArgumentNullException(nameof(transaction), "Cannot add a null transaction.");
            }

            // Use the built-in Add method of the List<T> class to append the new transaction.
            _transactions.Add(transaction);
        }

        /// <summary>
        /// Retrieves a copy of all transactions currently managed by the service.
        /// </summary>
        /// <returns>
        /// A new list containing all transactions. Returning a copy ensures that the
        /// internal list of the service cannot be modified from the outside,
        /// preserving encapsulation.
        /// </returns>
        public List<Transaction> GetAllTransactions()
        {
            // We return a *new* list containing the elements of our private list.
            // This is a defensive copy. The caller gets the data but cannot modify
            // our service's internal _transactions list.
            return _transactions.ToList();
        }

        /// <summary>
        /// Calculates the sum of all income transactions.
        /// </summary>
        /// <returns>The total amount of income as a decimal.</returns>
        public decimal GetTotalIncome()
        {
            // We use a chain of LINQ methods to perform the calculation in a single, expressive line.
            // 1. .Where() filters the list to include only transactions of type Income.
            // 2. .Sum() then aggregates the Amount property of the filtered transactions.
            // If there are no income transactions, Sum() correctly returns 0.
            return _transactions
                .Where(t => t.Type == TransactionType.Income)
                .Sum(t => t.Amount);
        }

        /// <summary>
        /// Calculates the sum of all expense transactions.
        /// </summary>
        /// <returns>The total amount of expenses as a decimal.</returns>
        public decimal GetTotalExpenses()
        {
            // This LINQ chain is almost identical to GetTotalIncome(),
            // but it filters for transactions of type Expense.
            return _transactions
                .Where(t => t.Type == TransactionType.Expense)
                .Sum(t => t.Amount);
        }

        /// <summary>
        /// Calculates the current balance by subtracting total expenses from total income.
        /// This method reuses the existing income and expense calculation methods.
        /// </summary>
        /// <returns>The current financial balance as a decimal.</returns>
        public decimal GetCurrentBalance()
        {
            // Simple, readable, and maintainable. It leverages the work we've already done.
            return GetTotalIncome() - GetTotalExpenses();
        }
    }
}
