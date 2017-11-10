using DAL.Entities;
using RegisteredUser;
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
    public partial class AddItem : Form
    {
        Product currentProduct;
        Order currentOrder;

        public AddItem()
        {
            InitializeComponent();
        }

        public AddItem(Product currentProduct,Order currentOrder)
        {
            InitializeComponent();
            this.currentProduct = currentProduct;
            this.currentOrder= currentOrder;

            initLabels();
        }

        private void initLabels()
        {
            itemName.Text = currentProduct.name;
            descriptionLabel.Text = currentProduct.description;
            priceLabel.Text = currentProduct.price.ToString()+"$";
        }

        private void amountPicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            Order_item orderItem = new Order_item();
            orderItem.order_ID = currentOrder.order_ID;
            orderItem.product_ID = currentProduct.product_ID;
            orderItem.quantity = (int)amountPicker.Value;
            orderItem.old_price = currentProduct.price;

            (new OrderItem_BL()).add(orderItem);
        }

        private void AddItem_Load(object sender, EventArgs e)
        {

        }
    }
}
