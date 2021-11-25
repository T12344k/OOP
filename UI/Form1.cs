using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
//using Entities;


namespace UI
{
    public partial class Form1 : Form
    {//constructor of this window
     //creating a new BL object. 
        ProductBL bl1; 
        public Form1()
        {   bl1 = new ProductBL();
            InitializeComponent();
            
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {//calling this method.
            try
            {
              //  bl1.ReadAll();
                textBoxAllProducts.AppendText(bl1.ReadAll().ToString() + "\r\n");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //display the form  
            

        }
    }
}
