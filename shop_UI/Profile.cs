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
    public partial class Profile : Form
    {
        User currentUser;
        double sum;

        public Profile()
        {
            InitializeComponent();
        }

        public Profile(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;

            updateLV();
        }

        private void updateLV()
        {
            loginLbl.Text = currentUser.login;
            emailLbl.Text = currentUser.email;
            List<Order> orders = (new Order_BL()).findUserOrders(currentUser.user_ID);
            foreach (Order order in orders) {
                ordersLV.Groups.Add(new ListViewGroup("Date: " + order.date.ToString(),
                                                        HorizontalAlignment.Left));
                sum = 0;
                if (!order.isPaid) continue;

                foreach (Order_item order_item in
                        (new OrderItem_BL())
                        .getByOrderID(order.order_ID)) {
                    addItemToLVLastGroup(order_item);
                }

                addSum();
            }

        }

        private void addSum()
        {
            int lastInd = ordersLV.Groups.Count - 1;
            
            ListViewItem item = new ListViewItem(new[] {"","","",sum.ToString() });

            ordersLV.Items.Add(item).Group = ordersLV.Groups[lastInd];

        }

        private void addItemToLVLastGroup(Order_item order_item)
        {
            int lastInd=ordersLV.Groups.Count-1;
            Product product=(new Product_BL()).getById(order_item.product_ID);

            ListViewItem item = new ListViewItem(product.name);
            item.SubItems.Add(order_item.old_price.ToString());
            item.SubItems.Add(order_item.quantity.ToString());
            sum += order_item.old_price * order_item.quantity;

            ordersLV.Items.Add(item).Group=ordersLV.Groups[lastInd];
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }
    }
}
