namespace Ir.Interview.Models
{
    public class ProductForCsv
    {
        public decimal Id { get; set; }
        public string? Name { get; set; }
        public string? Barnd { get; set; }

        private string inventory;

        public string Inventory
        {
            get { return inventory; }
            set 
            {
                if (value == "0")
                {
                    inventory = "OUTOFSTOCK";
                }
                else
                {
                    inventory = value;
                }
            }
        }


    }
}
