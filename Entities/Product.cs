using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product
    {
        //product number property
        public string Product_Number { get; set; }
        //product name property
        public string Product_Name { get; set; }
        //cost per unir property
        public double Cost_Per_Unit { get; set; }
        public int AmountInStock { get; set; }


        /// <summary>
        /// ctor to initialize property values
        /// </summary>
        /// <param name="productNumber">set as Product_Number</param>
        /// <param name="productName">set as Product_Name</param>
        /// <param name="costPerUnit">set as Cost_Per_Unit</param>
        public Product(string productNumber, string productName, double costPerUnit, int amountInStock)
        {
            Product_Number = productNumber;
            Product_Name = productName;
            Cost_Per_Unit = costPerUnit;
            AmountInStock = amountInStock;
        }

        /// <summary>
        /// to string method for product. 
        /// </summary>
        /// <returns>properties of product</returns>
        public override string ToString()
        {
            return $"Product name is:{Product_Name}" +
                $"\n Product number is: {Product_Number}\n" +
                $"Cost per unit is: {Cost_Per_Unit}\n" +
                $"Amount left in stock is: {AmountInStock}";
        }
    }
}
