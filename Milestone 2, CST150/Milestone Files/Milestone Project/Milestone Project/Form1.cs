using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Dalton Danz
//CST-150
//May 15, 2022
//This is my own work

namespace Milestone_Project
{
    public partial class Form1 : Form
    {
        //create inventory list field
        private List<InventoryItems> inventoryList = new List<InventoryItems>();

        public Form1()
        {
            InitializeComponent();
        }

        //method to set item values
        private void GetData(ref InventoryItems inventoryItem)
        {
            try
            {
                inventoryItem.name = addItemNameBox.Text;
                inventoryItem.inventoryQty = int.Parse(initialQtyBox.Text);
                inventoryItem.itemPrice = decimal.Parse(addItemPriceBox.Text);
                inventoryItem.isDiscounted = discountYesBox.Checked;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //Add new items to inventory
        private void addItemButton_Click(object sender, EventArgs e)
        {

           InventoryItems inventoryItem = new InventoryItems();

            GetData(ref inventoryItem);

            //add inventory item to list
            inventoryList.Add(inventoryItem);

            //display inventory item in list box
            string output;
            output = inventoryItem.inventoryQty + " total " + inventoryItem.name + " in inventory. normal price is " + inventoryItem.itemPrice
                 + " item is discounted? " + inventoryItem.isDiscounted; 
            inventoryListBox.Items.Add(output);

            //clear textboxes
            addItemNameBox.Clear();
            addItemPriceBox.Clear();
            initialQtyBox.Clear();
            discountYesBox.Checked = false;

        }

        //remove items from inventory
        private void completeOrderButton_Click(object sender, EventArgs e)
        {

        }

        //order more of existing item for inventory
        private void orderMoreButton_Click(object sender, EventArgs e)
        {
            
        }


        //Exit button
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    //create class
    public class InventoryItems
    {
        public string name;
        public int inventoryQty;
        public decimal itemPrice;
        public bool isDiscounted;
    }
}
