using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    /// <summary>
    /// Manages products carried in inventory
    /// </summary>
    public class Product
    {
        public Product()
        {
            Console.WriteLine("Product instance created");
            ProductVendor = new Vendor();
        }
        public Product(string productName, string description, int productId) :this()
        {
            this.ProductName = productName;
            this.Description = description;
            this.ProductId = productId;
            Console.WriteLine("Product created with name: " + ProductName);
        }

        private DateTime? availabilityDate;

        public DateTime? AvailabilityDate
        {
            get { return availabilityDate; }
            set { availabilityDate = value; }
        }

        public decimal Cost { get; set; }

        private string productName;

        public string ProductName
        {
            get {
                var formattedString = productName?.Trim();
                return formattedString;
            }
            set { productName = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private int productId;

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }
        private Vendor productVendor;

        public Vendor ProductVendor
        {
            get { return productVendor; }
            set { productVendor = value; }
        }


        public string SayHello()
        {
            return "Hello " + ProductName + " (" + ProductId + "): " + Description + " Available on: " + AvailabilityDate?.ToShortDateString();
        }

        public decimal CalculateSuggestedPrice(decimal markupPercent) =>
            this.Cost + (this.Cost * markupPercent / 100);
    }
}
