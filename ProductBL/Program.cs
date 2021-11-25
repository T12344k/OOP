using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BL
{
    public class ProductBL
    {
        //create product
        public void Create(string productNum1, string productName1, double cost1, int amountIn1)
        {
            ProductDAL proDal = new ProductDAL();
            proDal.Create(productNum1, productName1, cost1, amountIn1);
            //return true;
        }

        //read specific product
        public Product Read(string toSee)
        {
            ProductDAL proDal = new ProductDAL();
            return proDal.Read(toSee);
        }


        //read all products
        public List<Product> ReadAll()
        {
            ProductDAL proDal = new ProductDAL();
            return proDal.ReadAll();
        }

        //update product
        public bool Update(string toUpdate1, Product prod1)
        {
            ProductDAL proDal = new ProductDAL();
            return proDal.Update(toUpdate1, prod1);
        }

        //delete product
        public bool Delete(string toDelete)
        {
            ProductDAL proDal = new ProductDAL();
            return proDal.Delete(toDelete);
        }

    }
}
