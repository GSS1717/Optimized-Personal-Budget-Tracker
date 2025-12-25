using System;
using System.Collections.Generic;

// Required for file system operations, like writing to a file.
using System.IO;

// Required for JSON serialization and deserialization.
using System.Text.Json;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimized_Personal_Budget_Tracker
{
    /// <summary>
    /// Handles the persistence of transaction data.
    /// This service is responsible for saving transactions to a file
    /// and loading them back into the application.
    /// It separates the data storage concern from the business logic concern.
    /// </summary>
    public class DataStorageService
    {
        // In the upcoming tasks, we will add methods here to handle
        // file read/write operations and JSON serialization.
        
        // A private constant to hold the name of our data file.
        // Using a const ensures the file path is defined in one place and cannot be changed,
        // preventing "magic strings" and making the code easier to maintain.
        private const string FilePath = "transactions.json";

        public void SaveTransactions(List<Transaction> transactions)
        {
            // 1. Serialize the list of transactions into a JSON-formatted string.
            // We use JsonSerializerOptions to make the output "pretty-printed" (indented),
            // which is great for debugging and readability.
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(transactions, options);

            // 2. Write the JSON string to the file specified by our FilePath constant.
            // File.WriteAllText will create the file if it doesn't exist,
            // or completely overwrite it if it does.
            File.WriteAllText(FilePath, jsonString);
        }

        public List<Transaction> LoadTransactions()
        {
            // 1. Check if the data file even exists.
            if (!File.Exists(FilePath))
            {
                // If not, return a new, empty list to prevent any errors.
                return new List<Transaction>();
            }

            // 2. If the file exists, read its entire content into a string.
            string jsonString = File.ReadAllText(FilePath);

            // highlight-start
            // 3. Add a second defensive check: Is the file content empty?
            // If the file exists but is empty, deserializing it would cause an error.
            // string.IsNullOrEmpty() gracefully handles both null and empty strings.
            if (string.IsNullOrEmpty(jsonString))
            {
                // Just like when the file doesn't exist, an empty file means there's
                // no data to load. We return a new, empty list for a clean start.
                return new List<Transaction>();
            }
            // highlight-end

            // 4. Only if the file exists AND contains content, we proceed to deserialize.
            // This line is now protected from both a missing file and an empty file.
            List<Transaction> transactions = JsonSerializer.Deserialize<List<Transaction>>(jsonString);

            // 5. Return the loaded list of transactions.
            return transactions;

        }
    }
}
