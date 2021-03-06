﻿using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    /// <summary>
    /// Manages the vendors from whom we purchase our inventory.
    /// </summary>
    public class Vendor 
    {
        public int VendorId { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }

        /// <summary>
        /// Sends an email to welcome a new vendor.
        /// </summary>
        /// <returns></returns>
        public string SendWelcomeEmail(string message)
        {
            var emailService = new EmailService();
            var subject = ("Hello " + this.CompanyName).Trim();
            var confirmation = emailService.SendMessage(subject, message, this.Email);
            return confirmation;
        }

        /// <summary>
        /// Sends a product order to a vendor
        /// </summary>
        /// <param name="product">Product to order</param>
        /// <param name="quantity">Number of products to order</param>
        /// <returns>
        /// Returns success bool
        /// </returns>
        public OperationResult PlaceOrder(Product product, int quantity)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }
            if (quantity <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(quantity));
            }

            var success = false;
            var orderText = "Order from ACME, Inc" + System.Environment.NewLine + "Product: " + product.ProductName + System.Environment.NewLine + "Quantity: " + quantity;
            var emailService = new EmailService();
            var confirmation = emailService.SendMessage("New Order", orderText, this.Email);

            if (confirmation.StartsWith("Message sent;"))
            {
                success = true;
            }
            var OperationResult = new OperationResult(success, orderText);
            return OperationResult;
        }
    }
}
