using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ordertest;

namespace orderGraphis {
	public partial class FormEdit : Form {
		public Order Result { get => (Order)orderBindingSource.Current; }

		public FormEdit() {
			InitializeComponent();
			InitCustomerGoods();
		}

		public void InitCustomerGoods() {
			Customer customer1 = new Customer(1, "Customer1");
			Customer customer2 = new Customer(2, "Customer2");
			customerBindingSource.Add(customer1);
			customerBindingSource.Add(customer2);

			Goods milk = new Goods(1, "Milk", 69.9);
			Goods eggs = new Goods(2, "eggs", 4.99);
			Goods apple = new Goods(3, "apple", 5.59);
			goodsBindingSource.Add(milk);
			goodsBindingSource.Add(eggs);
			goodsBindingSource.Add(apple);
		}

		public FormEdit(Order order) : this() {
			orderBindingSource.DataSource = order;
		}

		private void FormEdit_Load(object sender, EventArgs e) {
			comboBox3.SelectedItem = ((Order)orderBindingSource.Current).Customer;
			if (detailsBindingSource.Current != null) {
				comboBox1.SelectedItem = ((OrderDetail)detailsBindingSource.Current).Goods;
			}
			else {
				tableLayoutPanel1.Enabled = false;
			}
		}

		private void label1_Click(object sender, EventArgs e) {

		}

		private void label3_Click(object sender, EventArgs e) {

		}

		private void button1_Click(object sender, EventArgs e) {
			OrderDetail detail = new OrderDetail();
			((Order)orderBindingSource.Current).AddDetails(detail);
			detailsBindingSource.MoveLast();
			comboBox1.SelectedItem = null;
			orderBindingSource.ResetBindings(false);
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
			((OrderDetail)detailsBindingSource.Current).Goods = (Goods)comboBox1.SelectedItem;
			detailsBindingSource.ResetBindings(false);
		}

		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e) {
			((Order)orderBindingSource.Current).Customer = (Customer)comboBox3.SelectedItem;
			detailsBindingSource.ResetBindings(false);
		}

		private void textBox2_TextChanged(object sender, EventArgs e) {
			orderBindingSource.ResetBindings(false);
		}

		private void detailsBindingSource_AddingNew(object sender, AddingNewEventArgs e) {
			tableLayoutPanel1.Enabled = true;
		}

		private void button2_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void detailsBindingSource_CurrentChanged(object sender, EventArgs e) {
			if (detailsBindingSource.Current != null) {
				comboBox1.SelectedItem = ((OrderDetail)detailsBindingSource.Current).Goods;
			} else {
				tableLayoutPanel1.Enabled = false;
			}
		}
	}
}
