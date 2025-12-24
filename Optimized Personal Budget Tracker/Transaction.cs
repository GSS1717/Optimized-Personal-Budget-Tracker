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

    internal class Transaction
    {
    }
}
