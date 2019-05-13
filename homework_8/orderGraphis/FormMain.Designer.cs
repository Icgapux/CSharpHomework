using System.Windows.Forms;
using System.Drawing;
using System;

namespace orderGraphis {
	partial class FormMain {
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		private Button searchButton;
		private Button addOrderButton;
		private Button changeOrderButton;
		private Button deleteOrderButton;
		private Button exportOrderButton;
		private Button importOrderButton;

		private ComboBox searchOption;
		private TextBox searchInputTextBox;

		private BindingSource orderBindingSource;
		private BindingSource detailsBindingSource;
		//private BindingSource customerBindingSource;
		//private BindingSource goodsBindingSource;

		private DataGridView orderGrid;

		private DataGridView detailGrid;


		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.searchButton = new System.Windows.Forms.Button();
			this.addOrderButton = new System.Windows.Forms.Button();
			this.changeOrderButton = new System.Windows.Forms.Button();
			this.deleteOrderButton = new System.Windows.Forms.Button();
			this.exportOrderButton = new System.Windows.Forms.Button();
			this.importOrderButton = new System.Windows.Forms.Button();
			this.searchOption = new System.Windows.Forms.ComboBox();
			this.searchInputTextBox = new System.Windows.Forms.TextBox();
			this.orderGrid = new System.Windows.Forms.DataGridView();
			this.detailGrid = new System.Windows.Forms.DataGridView();
			this.detailGoodsGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.detailAmountGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.detailPriceGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderIDGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderCustomerGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderPriceGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.openFileDialog = new OpenFileDialog();
			this.saveFileDialog = new SaveFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.detailGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// orderBindingSource
			// 
			this.orderBindingSource.DataSource = typeof(ordertest.Order);
			// 
			// detailsBindingSource
			// 
			this.detailsBindingSource.DataMember = "Details";
			this.detailsBindingSource.DataSource = this.orderBindingSource;
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(327, 23);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(75, 23);
			this.searchButton.TabIndex = 0;
			this.searchButton.Text = "搜索订单";
			this.searchButton.Click += new System.EventHandler(this.SearchOrders);
			// 
			// addOrderButton
			// 
			this.addOrderButton.Location = new System.Drawing.Point(32, 65);
			this.addOrderButton.Name = "addOrderButton";
			this.addOrderButton.Size = new System.Drawing.Size(75, 23);
			this.addOrderButton.TabIndex = 0;
			this.addOrderButton.Text = "添加订单";
			this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
			// 
			// changeOrderButton
			// 
			this.changeOrderButton.Location = new System.Drawing.Point(218, 65);
			this.changeOrderButton.Name = "changeOrderButton";
			this.changeOrderButton.Size = new System.Drawing.Size(75, 23);
			this.changeOrderButton.TabIndex = 0;
			this.changeOrderButton.Text = "修改订单";
			this.changeOrderButton.Click += new System.EventHandler(this.changeOrderButton_Click);
			// 
			// deleteOrderButton
			// 
			this.deleteOrderButton.Location = new System.Drawing.Point(126, 65);
			this.deleteOrderButton.Name = "deleteOrderButton";
			this.deleteOrderButton.Size = new System.Drawing.Size(75, 23);
			this.deleteOrderButton.TabIndex = 0;
			this.deleteOrderButton.Text = "删除订单";
			this.deleteOrderButton.Click += new System.EventHandler(this.deleteOrderButton_Click);
			// 
			// exportOrderButton
			// 
			this.exportOrderButton.Location = new System.Drawing.Point(312, 65);
			this.exportOrderButton.Name = "exportOrderButton";
			this.exportOrderButton.Size = new System.Drawing.Size(75, 23);
			this.exportOrderButton.TabIndex = 0;
			this.exportOrderButton.Text = "导出订单";
			this.exportOrderButton.Click += new System.EventHandler(this.exportOrderButton_Click);
			// 
			// importOrderButton
			// 
			this.importOrderButton.Location = new System.Drawing.Point(405, 65);
			this.importOrderButton.Name = "importOrderButton";
			this.importOrderButton.Size = new System.Drawing.Size(75, 23);
			this.importOrderButton.TabIndex = 0;
			this.importOrderButton.Text = "导入订单";
			this.importOrderButton.Click += new System.EventHandler(this.importOrderButton_Click);
			// 
			// searchOption
			// 
			this.searchOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.searchOption.Items.AddRange(new object[] {
            "全部订单",
            "ID",
            "客户名",
            "货物名",
            "价格大于"});
			this.searchOption.Location = new System.Drawing.Point(32, 23);
			this.searchOption.Name = "searchOption";
			this.searchOption.Size = new System.Drawing.Size(121, 20);
			this.searchOption.TabIndex = 1;
			// 
			// searchInputTextBox
			// 
			this.searchInputTextBox.Location = new System.Drawing.Point(172, 22);
			this.searchInputTextBox.Name = "searchInputTextBox";
			this.searchInputTextBox.Size = new System.Drawing.Size(135, 21);
			this.searchInputTextBox.TabIndex = 2;
			// 
			// orderGrid
			// 
			this.orderGrid.AutoGenerateColumns = false;
			this.orderGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDGridColumn,
            this.orderCustomerGridColumn,
            this.orderPriceGridColumn});
			this.orderGrid.DataSource = this.orderBindingSource;
			this.orderGrid.Location = new System.Drawing.Point(32, 128);
			this.orderGrid.Name = "orderGrid";
			this.orderGrid.Size = new System.Drawing.Size(448, 304);
			this.orderGrid.TabIndex = 3;
			// 
			// detailGrid
			// 
			this.detailGrid.AutoGenerateColumns = false;
			this.detailGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detailGoodsGridColumn,
            this.detailAmountGridColumn,
            this.detailPriceGridColumn});
			this.detailGrid.DataSource = this.detailsBindingSource;
			this.detailGrid.Location = new System.Drawing.Point(533, 128);
			this.detailGrid.Name = "detailGrid";
			this.detailGrid.Size = new System.Drawing.Size(458, 304);
			this.detailGrid.TabIndex = 4;
			// 
			// detailGoodsGridColumn
			// 
			this.detailGoodsGridColumn.DataPropertyName = "Goods";
			this.detailGoodsGridColumn.HeaderText = "货物";
			this.detailGoodsGridColumn.Name = "detailGoodsGridColumn";
			this.detailGoodsGridColumn.Width = 200;
			// 
			// detailAmountGridColumn
			// 
			this.detailAmountGridColumn.DataPropertyName = "Quantity";
			this.detailAmountGridColumn.HeaderText = "数量";
			this.detailAmountGridColumn.Name = "detailAmountGridColumn";
			// 
			// detailPriceGridColumn
			// 
			this.detailPriceGridColumn.DataPropertyName = "Price";
			this.detailPriceGridColumn.HeaderText = "总价";
			this.detailPriceGridColumn.Name = "detailPriceGridColumn";
			this.detailPriceGridColumn.ReadOnly = true;
			// 
			// orderIDGridColumn
			// 
			this.orderIDGridColumn.DataPropertyName = "Id";
			this.orderIDGridColumn.HeaderText = "订单号";
			this.orderIDGridColumn.Name = "orderIDGridColumn";
			this.orderIDGridColumn.Width = 50;
			// 
			// orderCustomerGridColumn
			// 
			this.orderCustomerGridColumn.DataPropertyName = "Customer";
			this.orderCustomerGridColumn.HeaderText = "客户";
			this.orderCustomerGridColumn.Name = "orderCustomerGridColumn";
			this.orderCustomerGridColumn.Width = 250;
			// 
			// orderPriceGridColumn
			// 
			this.orderPriceGridColumn.DataPropertyName = "TotalAmount";
			this.orderPriceGridColumn.HeaderText = "总价";
			this.orderPriceGridColumn.Name = "orderPriceGridColumn";
			this.orderPriceGridColumn.ReadOnly = true;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1042, 542);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.addOrderButton);
			this.Controls.Add(this.deleteOrderButton);
			this.Controls.Add(this.changeOrderButton);
			this.Controls.Add(this.exportOrderButton);
			this.Controls.Add(this.importOrderButton);
			this.Controls.Add(this.searchOption);
			this.Controls.Add(this.searchInputTextBox);
			this.Controls.Add(this.orderGrid);
			this.Controls.Add(this.detailGrid);
			this.Name = "FormMain";
			this.Text = "Order Service";
			((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.detailGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}


		#endregion
		private DataGridViewTextBoxColumn detailGoodsGridColumn;
		private DataGridViewTextBoxColumn detailAmountGridColumn;
		private DataGridViewTextBoxColumn detailPriceGridColumn;
		private DataGridViewTextBoxColumn orderIDGridColumn;
		private DataGridViewTextBoxColumn orderCustomerGridColumn;
		private DataGridViewTextBoxColumn orderPriceGridColumn;
		private OpenFileDialog openFileDialog;
		private SaveFileDialog saveFileDialog;
	}
}

