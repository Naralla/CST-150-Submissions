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
//June 5, 2022
//This is my own work

namespace Milestone_Project
{
    public partial class Form1 : Form
    {
        //create inventory list 
        List<InventoryItems> inventoryList = new List<InventoryItems>();
        

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
            string[] output= new string[inventoryList.Count];

            try
            {
                //get data for item
                inventoryItem.name = itemNameBox.Text;
                inventoryItem.itemPrice = decimal.Parse(itemPriceBox.Text);
                inventoryItem.inventoryQty = int.Parse(itemQtyBox.Text);                
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }

            //add stock to manager list
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
            
            
            //search by name
            if (temp.searchInventoryName(inventoryList, selection) != -1)
            {
                //search by price
                if (decimal.TryParse(searchProductPriceBox.Text, out selectionPrice))
                {
                    //if found
                    if (temp.searchInventoryPrice(inventoryList, selectionPrice) != -1)
                    {
                        int priceIndex = temp.searchInventoryPrice(inventoryList, selectionPrice);

                        //display search result
                        MessageBox.Show("That item was found in inventory " + inventoryList.ElementAt(priceIndex).name.ToString()
                            + " " + inventoryList.ElementAt(priceIndex).inventoryQty.ToString() + " total in inventory" +
                            " $" + inventoryList.ElementAt(priceIndex).itemPrice.ToString());
                    }
                }
                //if not found
                else
                {
                    MessageBox.Show("No item found with that price");
                }
            }
            //cannot find item
            else
            {
                MessageBox.Show("No Item found with that name");
            }
        }



        //order more of existing item for inventory
        private void orderMoreButton_Click(object sender, EventArgs e)
        {
            var temp = new InventoryManager();
            string selection = "";
            selection = searchProductNameBox.Text.ToString();


            //search by name
            if (temp.searchInventoryName(inventoryList, selection) != -1)
            {
                int index = temp.searchInventoryName(inventoryList, selection);

                inventoryList.ElementAt(index).inventoryQty += 100;

                string[] refreshListBox = temp.inventoryDisplay(inventoryList);
                displayResults(refreshListBox);
            }
            //cannot find name
            else
            {
                MessageBox.Show("No Item found with that name");
            }

            //empty boxes after search
            searchProductPriceBox.Text = "";
            searchProductNameBox.Text = "";
        }

        
        //Exit button
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //to remove item from the inventory
        private void removeItemButton_Click(object sender, EventArgs e)
        {
            var temp = new InventoryManager();
            string selection = "";
            selection = searchProductNameBox.Text.ToString();


            //search by name
            if (temp.searchInventoryName(inventoryList, selection) != -1)
            {
                int index = temp.searchInventoryName(inventoryList, selection);

                temp.removeStockName(inventoryList, index);

                string[] refreshListBox = temp.inventoryDisplay(inventoryList);
                displayResults(refreshListBox);
            }
            //cannot find name
            else
            {
                MessageBox.Show("No Item found with that name");
            }

            //empty boxes after removal
            searchProductNameBox.Text = "";
            searchProductPriceBox.Text = "";
        }

        //Array to populate listbox entries
        public void displayResults(string[] result)
        {
            //hide form 1
            this.Hide();

            // create an instance of form 2
            Form2 currentInventoryForm = new Form2();

            //populate form 2's list box with current inventory
            currentInventoryForm.inventoryListBox.Items.Clear();
            for (int i = 0; i < result.Length; i++)
            {
                currentInventoryForm.inventoryListBox.Items.Add(result[i]);
            };

            //display form 2
            currentInventoryForm.ShowDialog();

            //when form2 closed
            currentInventoryForm = null;

            //re-show main form
            this.Show();

        }

        //milestone 5 addition. allows for user to check what is in inventory currently
        private void currentInventoryButton_Click(object sender, EventArgs e)
        {
            var temp = new InventoryManager();
            string[] result = new string[inventoryList.Count];
            result = temp.inventoryDisplay(inventoryList);

            //hide form 1
            this.Hide();

            // create an instance of form 2
            Form2 currentInventoryForm = new Form2();

            //populate form 2's list box with current inventory
            currentInventoryForm.inventoryListBox.Items.Clear();
            for (int i = 0; i < result.Length; i++)
            {
                currentInventoryForm.inventoryListBox.Items.Add(result[i]);
            };

            //display form 2
            currentInventoryForm.ShowDialog();

            //when form2 closed
            currentInventoryForm = null;

            //re-show main form
            this.Show();
        }
    }




    //class for inventory item objects
    public class InventoryItems 
    {
        public string name = "";
        public int inventoryQty = 0;
        public decimal itemPrice = 0m;
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
        public void addStock(List<InventoryItems> inventoryList, InventoryItems inventoryItem)
        {
            inventoryList.Add(inventoryItem);

            checkForRestockItem(inventoryList);
        }


        //remove item from stock by name
        public void removeStockName(List<InventoryItems> inventoryList, int index)
        {
            inventoryList.RemoveAt(index);

            checkForRestockItem(inventoryList);
        }


        //restock a low item
        public void checkForRestockItem(List<InventoryItems>inventoryList)
        {
            foreach (InventoryItems inventoryItem in inventoryList)
            {
                if(inventoryItem.inventoryQty <= 50)
                {
                    MessageBox.Show("Automatically ordered 50 " + inventoryItem.name);

                    inventoryItem.inventoryQty += 50;
                }
            }
        }

        //search the inventory for name
        public int searchInventoryName(List<InventoryItems> inventoryList, string value)
        {
            int index = inventoryList.FindIndex(item => item.name == value);


            return index;
        }

        //search the inventory for price
        public int searchInventoryPrice(List<InventoryItems> inventoryList, decimal value)
        {
            int index = inventoryList.FindIndex(item => item.itemPrice == value);

            return index;
        }


        //display inventory
        public string[] inventoryDisplay(List<InventoryItems> inventoryList)
        {     
            string[] output = new string[inventoryList.Count];
            for (int i = 0; i < inventoryList.Count; i++)
            {

                output[i] = inventoryList[i].name + " " + inventoryList[i].inventoryQty.ToString() + 
                    " in stock $" + inventoryList[i].itemPrice.ToString();

            }
            return output;
        }
    }
    
}
