using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Entities;
using RegisteredUser;
using RegisteredUser_BL;
using System.Threading;

namespace shop_UI
{
    public partial class Home : Form
    {
        private User currentUser;
        private Order currentOrder;

        public Home()
        {
            InitializeComponent();
            initOrder();
        }

        public Home(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            initOrder();


            updateItems();
        }

        private void initOrder()
        {
            Order_BL order_BL = new Order_BL();
            currentOrder = order_BL.getUnPaidOrder(currentUser.user_ID);
        }

        private void updateItems()
        {
            ItemsDataGrid.AllowUserToAddRows = true;
            ItemsDataGrid.Rows.Clear();
            List<Product> list = (new Product_BL()).getAllProduct();
            foreach (Product product in list) {
                DataGridViewRow row = (DataGridViewRow)ItemsDataGrid.Rows[0].Clone();
                row.Cells[0].Value = product.name;
                row.Cells[1].Value = product.price;
                row.Cells[2].Value = product.category;
                row.Cells[3].Value = product.product_ID;
                row.Cells[4].Value = product.description;
                ItemsDataGrid.Rows.Add(row);
            }
            ItemsDataGrid.AllowUserToAddRows = false;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void ItemsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
           Product product = new Product();

                product.name= (string)ItemsDataGrid.CurrentRow.Cells[0].Value;
                product.price= (double)ItemsDataGrid.CurrentRow.Cells[1].Value;
                product.category = (string)ItemsDataGrid.CurrentRow.Cells[2].Value;
                product.product_ID=(int)ItemsDataGrid.CurrentRow.Cells[3].Value;
                product.description= (string)ItemsDataGrid.CurrentRow.Cells[4].Value;

            AddItem addItemForm = new AddItem(product,currentOrder);
                addItemForm.ShowDialog(this);
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (menuStrip1.Items[0].Equals(e.ClickedItem))
            {
                Bag bag = new Bag(currentUser);
                if (bag.ShowDialog(this) == DialogResult.OK) {
                    initOrder();
                }

            }

            if (menuStrip1.Items[1].Equals(e.ClickedItem))
            {
                Profile profile = new Profile(currentUser);
                profile.ShowDialog(this);
            }

            if (menuStrip1.Items[2].Equals(e.ClickedItem))
            {
                this.Close();
                Thread th = new Thread(openNewForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }

        void openNewForm()
        {
            Application.Run(new Enter());
        }

        private void ItemsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void outToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
