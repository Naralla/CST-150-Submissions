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
//May 27, 2022
//This is my own work

namespace Milestone_Project
{
    public partial class Form1 : Form
    {
        //create inventory array 
        InventoryItems[] inventoryList = new InventoryItems[10];
        

        public Form1()
        {
            InitializeComponent();
        }


        //Add new items to inventory
        public void addItemButton_Click(object sender, EventArgs e)
        {
            //declare variables
            var temp = new InventoryManager();
            InventoryItems inventoryItem = new InventoryItems();
            string output;

            try
            {
                inventoryItem.name = itemNameBox.Text;
                inventoryItem.itemPrice = decimal.Parse(itemPriceBox.Text);
                inventoryItem.inventoryQty = int.Parse(itemQtyBox.Text);
                inventoryItem.isDiscounted = discountYesBox.Checked;
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }

            //add stock to manager array
            temp.addStock(inventoryList, inventoryItem);

            //clear textboxes
            itemNameBox.Clear();
            itemPriceBox.Clear();
            itemQtyBox.Clear();

            //get output
            output = temp.inventoryDisplay(inventoryList);

            //display output in log
            displayResults(output);
        }


        //search for items in inventory
        private void searchInventoryButton_Click(object sender, EventArgs e)
        {
            var temp = new InventoryManager();
            string selection = "";
            decimal selectionPrice = 0;

            selection = searchProductNameBox.Text.ToString();
            selectionPrice = decimal.Parse(searchProducPriceBox.Text);

            //search by name
            if (temp.searchArrayName(inventoryList, selection) != 1)
            {
                var index = temp.searchArrayName(inventoryList, selection);
                inventoryListBox.Items.Add(inventoryList[index]);
            }
            //search by price
            else if (temp.searchArrayPrice(inventoryList, selectionPrice) != 1)
            {
                var index = temp.searchArrayPrice(inventoryList, selectionPrice);
                inventoryListBox.Items.Add(inventoryList[index]);
            }
            //cannot find item
            else
            {
                MessageBox.Show("No Item found with that name or price");
            }
        }



        //order more of existing item for inventory
        private void orderMoreButton_Click(object sender, EventArgs e)
        {
            string output;
            var temp = new InventoryManager();

            if(inventoryListBox.SelectedIndex != -1)
            {
                int index = inventoryListBox.SelectedIndex;
                if(inventoryList[index].inventoryQty <= 50)
                {
                    inventoryList[index].inventoryQty += 100;

                    output = temp.inventoryDisplay(inventoryList);

                    displayResults(output);
                }
            }    
        }

        
        //Exit button
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void removeItemButton_Click(object sender, EventArgs e)
        {
            var temp = new InventoryManager();
            string selection = "";
            int selectionPrice = 0;

            selection = searchProductNameBox.Text.ToString();

            //search by name
            if (temp.searchArrayName(inventoryList, selection) != 1)
            {
                temp.removeStockName(inventoryList, selection);

                //search by price
                if (temp.searchArrayPrice(inventoryList, selectionPrice) != 1)
                {
                    temp.removeStockPrice(inventoryList, selectionPrice);
                }

                //cannot find price
                else
                {
                    MessageBox.Show("No Item found with that price");
                }
            }
            //cannot find name
            else
            {
                MessageBox.Show("No Item found with that name");
            }
        }

        public void displayResults(string result)
        {
            inventoryListBox.Items.Add(result);
        }
    }




    //class for inventory item objects
    public class InventoryItems
    {
        public string name = "";
        public int inventoryQty = 0;
        public decimal itemPrice = 0;
        public bool isDiscounted = false;
    }





    //inventory manager class
    public class InventoryManager
    {
        public InventoryItems inventoryItem
        {
            get; set;
        }

        public InventoryManager()
        {
        }



        //add new item to stock
        public void addStock(InventoryItems[] inventoryList, InventoryItems inventoryItem)
        {
            for(int i = 0; i < inventoryList.Length; i++)
            {
                if(inventoryList[i] == null)
                {
                    inventoryList[i] = inventoryItem;
                }

                i++;               
            }
            inventoryDisplay(inventoryList);
        }

        //remove item from stock by name
        public void removeStockName(InventoryItems[] inventoryList, string name)
        {
            int numIndex = Array.IndexOf(inventoryList, name);
            inventoryList = inventoryList.Where((val, idx) => idx != numIndex).ToArray();
            //string itemName = "";
            //for(int i =0; i < inventoryList.Length; i++)
            //{
            //    if(inventoryList[i].name != null)
            //    {
            //        itemName = inventoryList[i].name;
            //    }              
            //    if(itemName == name)
            //    {
            //        inventoryList[i]=null;
            //    }
            //}
        }

        //remove item from stock by price
        public void removeStockPrice(InventoryItems[] inventoryList, decimal price)
        {
            decimal itemPrice = 0;
            for (int i = 0; i < inventoryList.Length; i++)
            {
                if(inventoryList[i] != null)
                itemPrice = inventoryList[i].itemPrice;
                if (itemPrice == price)
                {
                    inventoryList[i] = null;
                }
            }
        }



        //restock a low item
        public void restockItem()
        {

        }

        //search the inventory for name
        public int searchArrayName(InventoryItems[] inventoryList, string value)
        {
            bool found = false;
            int index = 0;
            int position = inventoryList.Length;
            string itemName = "";
            while (!found && index < inventoryList.Length)
            {
                if (inventoryList[index] != null)
                {
                    itemName = inventoryList[index].name;
                }               
                if (itemName == value)
                {
                    found = true;
                    position = index;
                }
                index++;

            //    inventoryDisplay(inventoryList);
                
            }
            return position;
        }

        //search the inventory for price
        public int searchArrayPrice(InventoryItems[] inventoryList, decimal value)
        {
            bool found = false;
            int index = 0;
            int position = inventoryList.Length;
            while (!found && index < inventoryList.Length)
            {
                if( inventoryList[index] != null)
                {
                    if (inventoryList[index].itemPrice == value)
                    {
                        found = true;
                        position = index;
                    }
                    index++;
                }
            }
            return position;
        }


        //display inventory
        public string inventoryDisplay(InventoryItems[] inventoryList)
        {     
            string output = "";
            for (int i = 0; i < inventoryList.Length; i++)
            { 
                //display inventory item in list box
                if(inventoryList[i] != null)
                {
                    output = output + Environment.NewLine + inventoryList[i].name + " " 
                        + inventoryList[i].inventoryQty + " in stock $" + inventoryList[i].itemPrice;            
                }               
            }
            return output;
        }
    }
    
}
