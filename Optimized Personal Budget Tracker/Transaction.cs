using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimized_Personal_Budget_Tracker
{
    // highlight-start
    /// <summary>
    /// Represents the type of a financial transaction.
    /// </summary>
    public enum TransactionType
    {
        /// <summary>
        /// A transaction that adds funds to the budget.
        /// </summary>
        Income,

        /// <summary>
        /// A transaction that subtracts funds from the budget.
        /// </summary>
        Expense
    }
    // highlight-end

    public class Transaction
    // highlight-end
    {
        /// <summary>
        /// Gets or sets the unique identifier for the transaction.
        /// A GUID ensures that every transaction has a unique ID that will not conflict with others.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the transaction occurred.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets a short description of the transaction (e.g., "Monthly Salary", "Groceries").
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the monetary value of the transaction.
        /// We use the 'decimal' type for financial calculations to avoid floating-point rounding errors.
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets the category of the transaction (e.g., "Food", "Salary", "Utilities").
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the type of the transaction, either Income or Expense.
        /// This uses the TransactionType enum for type safety and clarity.
        /// </summary>
        public TransactionType Type { get; set; }

        // highlight-start
        /// <summary>
        /// Overrides the default ToString() method to provide a formatted,
        /// human-readable string representation of the transaction.
        /// </summary>
        /// <returns>A formatted string with the transaction's details.</returns>
        public override string ToString()
        {
            // We use string interpolation and format specifiers to create a neat, aligned output.
            return $"{Date:yyyy-MM-dd} | {Type,-8} | {Amount,12:C} | {Category,-15} | {Description}";
        }
    }
}
