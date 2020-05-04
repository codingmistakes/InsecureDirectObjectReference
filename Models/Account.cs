namespace InsecureDirectObjectReference.Models
{
    public class Account
    {
        public Account()
        {
            FullName = "N/A";
            Title = "N/A";
            Description = "N/A";
        }

        public int ID { get; set; }
        public string Title { get; set; }
        public int UserID { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
        public string FullName { get; set; }
    }
}
