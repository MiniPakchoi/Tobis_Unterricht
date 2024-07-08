namespace ExpensesTracker
{
    internal class Expense
    {
        //Properties
        string Name { get; set; } 
        decimal Price { get; set; }    
        string Category { get; set; }
        DateTime CreatedAt { get; set; }

        public Expense (string name, decimal price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
            CreatedAt = DateTime.Now;
        }
    }
}
