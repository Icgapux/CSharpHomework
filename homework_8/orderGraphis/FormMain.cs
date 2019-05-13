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
	public partial class FormMain : Form {
		private OrderService os = new OrderService();
		public String Keyword { get; set; }

		public FormMain() {
			InitializeComponent();
			InitOrders();
		}

		private void InitOrders() {
			Customer customer1 = new Customer(1, "Customer1");
			Customer customer2 = new Customer(2, "Customer2");

			Goods milk = new Goods(1, "Milk", 69.9);
			Goods eggs = new Goods(2, "eggs", 4.99);
			Goods apple = new Goods(3, "apple", 5.59);

			OrderDetail orderDetails1 = new OrderDetail(1, apple, 8);
			OrderDetail orderDetails2 = new OrderDetail(2, eggs, 2);
			OrderDetail orderDetails3 = new OrderDetail(3, milk, 1);

			Order order1 = new Order(1, customer1);
			Order order2 = new Order(2, customer2);
			Order order3 = new Order(3, customer2);
			order1.AddDetails(orderDetails1);
			order1.AddDetails(orderDetails2);
			order1.AddDetails(orderDetails3);

			order2.AddDetails(orderDetails2);
			order2.AddDetails(orderDetails3);
			order3.AddDetails(orderDetails3);

			os.AddOrder(order1);
			os.AddOrder(order2);
			os.AddOrder(order3);

			orderBindingSource.DataSource = os.QueryAllOrders();
			searchInputTextBox.DataBindings.Add("Text", this, "Keyword");
		}

		private void UpdateBindingSource() {
			orderBindingSource.DataSource = os.QueryAllOrders();
			orderBindingSource.ResetBindings(false);
		}

		private void SearchOrders(object sender, EventArgs e) {
			switch (searchOption.SelectedIndex) {
				case 0:
					orderBindingSource.DataSource = os.QueryAllOrders();
					break;
				case 1:
					uint.TryParse(Keyword, out uint id);
					orderBindingSource.DataSource = os.GetById(id);
					break;
				case 2:
					orderBindingSource.DataSource = os.QueryByCustomerName(Keyword);
					break;
				case 3:
					orderBindingSource.DataSource = os.QueryByGoodsName(Keyword);
					break;
				case 4:
					double.TryParse(Keyword, out double amount);
					orderBindingSource.DataSource = os.QueryByTotalAmount(amount);
					break;
			}
			orderBindingSource.ResetBindings(false);
		}

		private void deleteOrderButton_Click(object sender, EventArgs e) {
			Order o = (Order)orderBindingSource.Current;
			if (o != null) {
				os.RemoveOrder(o.Id);
				UpdateBindingSource();
			}
		}

		private void addOrderButton_Click(object sender, EventArgs e) {
			FormEdit form = new FormEdit(new Order());
			form.ShowDialog();
			if (form.Result != null) {
				os.AddOrder(form.Result);
				UpdateBindingSource();
			}
		}

		private void changeOrderButton_Click(object sender, EventArgs e) {
			FormEdit form = new FormEdit((Order)orderBindingSource.Current);
			form.ShowDialog();
			UpdateBindingSource();
		}

		private void exportOrderButton_Click(object sender, EventArgs e) {
			DialogResult res = saveFileDialog.ShowDialog();
			if (res.Equals(DialogResult.OK)) {
				String fileName = saveFileDialog.FileName;
				os.Export(fileName);
			}
		}

		private void importOrderButton_Click(object sender, EventArgs e) {
			DialogResult res = openFileDialog.ShowDialog();
			if (res.Equals(DialogResult.OK)) {
				String fileName = openFileDialog.FileName;
				os.Import(fileName);
				UpdateBindingSource();
			}
		}
	}
}
