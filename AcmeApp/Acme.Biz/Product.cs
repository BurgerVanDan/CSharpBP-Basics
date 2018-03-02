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
        }
        public Product(string productName, string description, int productId) :this()
        {
            this.ProductName = productName;
            this.Description = description;
            this.ProductId = productId;
            Console.WriteLine("Product created with name: " + ProductName);
        }

        private string productName;

        public string ProductName
        {
            get { return productName; }
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

        public string SayHello()
        {
            return "Hello " + ProductName + " (" + ProductId + "): " + Description;
        }
    }
}
