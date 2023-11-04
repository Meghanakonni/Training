using System;

namespace Assignment_05
{
    class Sales_Product
    {
        public int salesNumber;
        public int productNumber;
        public double Price;
        public DateTime DateofSale;
        public int Quantity;
        public double TotalAmount;

        public Sales_Product(int salesNo,int productNo, double price, DateTime dateofSale,int quantity)
        {
            this.salesNumber = salesNo;            
            this.productNumber = productNo;
            this.Price = price;           
            this.DateofSale = dateofSale;           
            this.Quantity = quantity;      
            updateTotalAmount();
        }

        public void updateTotalAmount()
        {
            this.TotalAmount = this.Quantity * this.Price;
        }

        public void ShowData()
        {
            Console.WriteLine("Sales Number:" + salesNumber);
            Console.WriteLine("Product Number:" + productNumber);
            Console.WriteLine("Price of the Product :" + Price);
            Console.WriteLine("Product Purchase Date:" + DateofSale);
            Console.WriteLine("Quantity of the Product:" + Quantity);
            Console.WriteLine("Total cost of that Product :" + TotalAmount);
        }
    }

    class Sales
    {
        static void Main()
        {
            Console.WriteLine("Enter the Sales Number:");
            int salesNo = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Enter the Product Number:");
            int productNo = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the Price of the Product:");
            double price = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the Date and Time:");
            DateTime dateofSale = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Quantity of the Product:");
            int quantity = int.Parse(Console.ReadLine());

            Sales_Product Sale = new Sales_Product(salesNo,productNo,price,dateofSale,quantity);
            Sale.updateTotalAmount();
            Sale.ShowData();
        }
    }
}