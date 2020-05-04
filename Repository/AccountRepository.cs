using InsecureDirectObjectReference.Models;
using System.Collections.Generic;
using System.Linq;

namespace InsecureDirectObjectReference.Repository
{
    public class AccountRepository
    {
        public Database Database { get; set; }
        public AccountRepository()
        {
            List<User> users = new List<User>();
            users.Add(new User() { ID = 1, Username = "asmith", FullName = "Adam Smith" });
            users.Add(new User() { ID = 2, Username = "jdoe", FullName = "John Doe" });
            users.Add(new User() { ID = 3, Username = "jzaza", FullName = "Joey Zaza" });
            users.Add(new User() { ID = 4, Username = "jnolan", FullName = "Jim Nolan" });
            users.Add(new User() { ID = 5, Username = "pmonterey", FullName = "Pilon Monterey" });

            List<Account> accounts = new List<Account>();
            accounts.Add(new Account() { ID = 718276, UserID = 1, FullName = "Adam Smith", Amount = 4522.6, Title = "Primary", Description = "Primary bank account" });
            accounts.Add(new Account() { ID = 212345, UserID = 1, FullName = "Adam Smith", Amount = 3412.3, Title = "Secondary", Description = "Secondary bank account" });
            accounts.Add(new Account() { ID = 374653, UserID = 1, FullName = "Adam Smith", Amount = 529.7, Title = "Savings", Description = "Savings bank account" });
            accounts.Add(new Account() { ID = 436251, UserID = 1, FullName = "Adam Smith", Amount = 2123.1, Title = "Credit", Description = "Credit card bank account" });
            accounts.Add(new Account() { ID = 574832, UserID = 1, FullName = "Adam Smith", Amount = 2922.0, Title = "Extra", Description = "Extra bank account" });
            accounts.Add(new Account() { ID = 623848, UserID = 1, FullName = "Adam Smith", Amount = 5633.6, Title = "Special", Description = "Special bank account" });
            accounts.Add(new Account() { ID = 718273, UserID = 2, FullName = "John Doe", Amount = 9575.3, Title = "Primary", Description = "Primary bank account" });
            accounts.Add(new Account() { ID = 893174, UserID = 2, FullName = "John Doe", Amount = 7563.5, Title = "Secondary", Description = "Secondary bank account" });
            accounts.Add(new Account() { ID = 994733, UserID = 2, FullName = "John Doe", Amount = 9264.6, Title = "Savings", Description = "Savings bank account" });
            accounts.Add(new Account() { ID = 101293, UserID = 2, FullName = "John Doe", Amount = 85463.1, Title = "Credit", Description = "Credit card bank account" });
            accounts.Add(new Account() { ID = 111347, UserID = 2, FullName = "John Doe", Amount = 9474.2, Title = "Special", Description = "Special bank account" });
            accounts.Add(new Account() { ID = 124912, UserID = 2, FullName = "John Doe", Amount = 523.3, Title = "Extra", Description = "Extra bank account" });
            accounts.Add(new Account() { ID = 130137, UserID = 3, FullName = "Joey Zaza", Amount = 937.4, Title = "Primary", Description = "Primary bank account" });
            accounts.Add(new Account() { ID = 142947, UserID = 3, FullName = "Joey Zaza", Amount = 324.5, Title = "Secondary", Description = "Secondary bank account" });
            accounts.Add(new Account() { ID = 158632, UserID = 3, FullName = "Joey Zaza", Amount = 967.6, Title = "Savings", Description = "Savings bank account" });
            accounts.Add(new Account() { ID = 718275, UserID = 4, FullName = "Jim Nolan", Amount = 274.7, Title = "Primary", Description = "Primary bank account" });
            accounts.Add(new Account() { ID = 171293, UserID = 4, FullName = "Jim Nolan", Amount = 758.8, Title = "Secondary", Description = "Secondary bank account" });
            accounts.Add(new Account() { ID = 181292, UserID = 4, FullName = "Jim Nolan", Amount = 437.9, Title = "Extra", Description = "Extra bank account" });
            accounts.Add(new Account() { ID = 191281, UserID = 4, FullName = "Jim Nolan", Amount = 937.4, Title = "Credit", Description = "Credit bank account" });
            accounts.Add(new Account() { ID = 200473, UserID = 5, FullName = "Pilon Monterey", Amount = 483.3, Title = "Primary", Description = "Primary bank account" });
            accounts.Add(new Account() { ID = 212821, UserID = 5, FullName = "Pilon Monterey", Amount = 39373.2, Title = "Secondary", Description = "Secondary bank account" });
            accounts.Add(new Account() { ID = 224537, UserID = 5, FullName = "Pilon Monterey", Amount = 9463.1, Title = "Credit", Description = "Credit card bank account" });

            Database = new Database() { Accounts = accounts, Users = users };
        }

        public Account GetAccount(int accountID)
        {
            return Database.Accounts.Where(d => d.ID == accountID).FirstOrDefault();
        }

        public IEnumerable<Account> GetAccounts(int userID)
        {
            return Database.Accounts.Where(d => d.UserID == userID);
        }
    }
}