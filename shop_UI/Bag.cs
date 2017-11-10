using DAL.Entities;
using RegisteredUser;
using RegisteredUser_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop_UI
{
    public partial class Bag : Form
    {
        User currentUser;
        Order order;
        List<Order_item> order_items_list;
        double sum = 0;

        public Bag()
        {
            InitializeComponent();
            updateBag();
            order_items_list = new List<Order_item>();
        }

        public Bag(User user)
        {
            InitializeComponent();

            order_items_list = new List<Order_item>();
            currentUser = user;

            updateBag();

        }

        private void updateBag()
        {
            sum = 0;
            order_items_grid.AllowUserToAddRows = true;
            order_items_grid.Rows.Clear();

            order =(new Order_BL()).getUnPaidOrder(currentUser.user_ID);
            foreach (Order_item order_item in 
                (new OrderItem_BL()).getByOrderID(order.order_ID)) {
                order_items_list.Add(order_item);
                addRow(order_item);
            }
            totalSumLbl.Text = "Total sum: " + sum.ToString();

            order_items_grid.AllowUserToAddRows = false;
        }

        private void addRow(Order_item order_item)
        {
            Product product = (new Product_BL())
                                .getById(order_item.product_ID);

            double price = product.price * order_item.quantity;
            sum += price;

            DataGridViewRow row = (DataGridViewRow)order_items_grid.Rows[0].Clone();
            row.Cells[0].Value = product.name;
            row.Cells[1].Value = product.price+"*"+ order_item.quantity;
            row.Cells[2].Value = order_item.quantity;
            row.Cells[3].Value = Properties.Resources.Rubbish;
            row.Cells[4].Value = order_item.order_item_ID;
            row.Cells[5].Value = order_item.product_ID;
            order_items_grid.Rows.Add(row);
        }

        private void Bag_Load(object sender, EventArgs e)
        {

        }

        private void totalSumLbl_Click(object sender, EventArgs e)
        {

        }



        private void order_items_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (order_items_grid.CurrentCell.ColumnIndex == 3) {

                Order_item temp = new Order_item();
                temp.order_item_ID = (int)(order_items_grid.CurrentRow.Cells[4].Value);
                (new OrderItem_BL()).delete(temp);
                updateBag();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for the purchase!");
            (new Order_BL()).payForOrder(order.order_ID);
        }
    }
}
