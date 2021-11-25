using System; 
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BL
{
    class BlTest
    {
        static void Main(string[] args)
        {
            {
                try
                {
                    //create new list
                    ProductDAL pro = new ProductDAL();
                    //Console.WriteLine("Create new product: Write product number ");
                    //string productNum = Console.ReadLine();
                    //Console.WriteLine("Write product name, (then press enter)");
                    //string productName = Console.ReadLine();
                    //Console.WriteLine("Write product cost per unit(then press enter)");
                    //double cost = double.Parse(Console.ReadLine());
                    //Console.WriteLine("How many in stock?");
                    //int stock = int.Parse(Console.ReadLine());
                    //pro.Create(productNum, productName, cost, stock);

                    //Console.WriteLine("which product would you like to see?");
                    //string toSee;
                    //toSee = Console.ReadLine();



                    //// pro.Initializelist();

                    ////  pro.Create();
                    //Console.WriteLine(pro.Read(toSee));

                    //string toUpdate;
                    //Console.WriteLine("which product would you like to update?");
                    //toUpdate = Console.ReadLine();
                    //Console.WriteLine("what is the (new) product name?");
                    //string answer = Console.ReadLine();
                    //Console.WriteLine("What is the (new) product cost?");
                    //double answer2 = double.Parse(Console.ReadLine());
                    //Console.WriteLine("How many in stock?");
                    //int stockNew = int.Parse(Console.ReadLine());
                    //Product prod = new Product(toUpdate, answer, answer2, stockNew);
                    //pro.Update(toUpdate, prod);

                    //string toDelete;
                    //Console.WriteLine("which product would you like to delete? (Write product name)");
                    //toDelete = Console.ReadLine();
                    //pro.Delete(toDelete);


                    //read whole list to see all other methods worked
                    // Console.WriteLine(string.Join('\n pro.ReadAll()')); 
                    pro.ReadAll();
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}

