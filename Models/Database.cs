using System.Collections.Generic;

namespace InsecureDirectObjectReference.Models
{
    public class Database
    {
        public List<User> Users { get; set; }

        public List<Account> Accounts { get; set; }
    }
}
