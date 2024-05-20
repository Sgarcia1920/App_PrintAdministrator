namespace App_PrintAdministrator
{
	partial class FrmSalePrints
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			cbsize = new ComboBox();
			cbAvailablepaper = new ComboBox();
			label2 = new Label();
			label3 = new Label();
			cbSalesOptions = new ComboBox();
			label4 = new Label();
			txtPricesales = new TextBox();
			txtNumberPrints = new TextBox();
			label5 = new Label();
			groupBox1 = new GroupBox();
			btnExporttxtpaper = new Button();
			btnclearcontrols = new Button();
			btnpricepaper = new FontAwesome.Sharp.IconButton();
			btnsearchAvailablepaper = new FontAwesome.Sharp.IconButton();
			btncancel_purchase = new Button();
			btnAddsales = new Button();
			groupBox2 = new GroupBox();
			btnexportsalesexcel = new Button();
			btnExportpdfXML = new Button();
			btncalculate = new Button();
			txtChange = new TextBox();
			label9 = new Label();
			txtPayment = new TextBox();
			label10 = new Label();
			txtTotal = new TextBox();
			label8 = new Label();
			txtIVA = new TextBox();
			label7 = new Label();
			txtSubtotal = new TextBox();
			label6 = new Label();
			dgvSalePrint = new DataGridView();
			btnreset = new FontAwesome.Sharp.IconButton();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvSalePrint).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Cambria", 13.8F, FontStyle.Italic);
			label1.Location = new Point(62, 41);
			label1.Name = "label1";
			label1.Size = new Size(50, 27);
			label1.TabIndex = 0;
			label1.Text = "Size";
			// 
			// cbsize
			// 
			cbsize.Font = new Font("Cambria", 10.2F);
			cbsize.FormattingEnabled = true;
			cbsize.Items.AddRange(new object[] { "Separador Tabloide 12 x 18 pulgadas", "Tabloide 11 x 17 pulgadas", "Carta 8.5 x 11 pulgadas", "Oficio 8.5 x 14 pulgadas ", "A4 8.27 x 11.69 pulgadas" });
			cbsize.Location = new Point(117, 42);
			cbsize.Name = "cbsize";
			cbsize.Size = new Size(186, 28);
			cbsize.TabIndex = 1;
			// 
			// cbAvailablepaper
			// 
			cbAvailablepaper.Font = new Font("Cambria", 10.2F);
			cbAvailablepaper.FormattingEnabled = true;
			cbAvailablepaper.Location = new Point(117, 114);
			cbAvailablepaper.Name = "cbAvailablepaper";
			cbAvailablepaper.Size = new Size(186, 28);
			cbAvailablepaper.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Cambria", 13F, FontStyle.Italic);
			label2.Location = new Point(10, 94);
			label2.Name = "label2";
			label2.Size = new Size(102, 52);
			label2.TabIndex = 2;
			label2.Text = "Available \r\nPaper";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Cambria", 13.8F, FontStyle.Italic);
			label3.Location = new Point(378, 42);
			label3.Name = "label3";
			label3.Size = new Size(61, 27);
			label3.TabIndex = 6;
			label3.Text = "Price";
			// 
			// cbSalesOptions
			// 
			cbSalesOptions.Font = new Font("Cambria", 10.2F);
			cbSalesOptions.FormattingEnabled = true;
			cbSalesOptions.Items.AddRange(new object[] { "Pricepacket", "Priceprint", "WhitesheetPrice" });
			cbSalesOptions.Location = new Point(117, 181);
			cbSalesOptions.Name = "cbSalesOptions";
			cbSalesOptions.Size = new Size(186, 28);
			cbSalesOptions.TabIndex = 5;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Cambria", 13.8F, FontStyle.Italic);
			label4.Location = new Point(27, 174);
			label4.Name = "label4";
			label4.Size = new Size(85, 54);
			label4.TabIndex = 4;
			label4.Text = "Sales \r\nOptions";
			// 
			// txtPricesales
			// 
			txtPricesales.Font = new Font("Cambria", 10.2F);
			txtPricesales.Location = new Point(447, 42);
			txtPricesales.Name = "txtPricesales";
			txtPricesales.ReadOnly = true;
			txtPricesales.Size = new Size(186, 27);
			txtPricesales.TabIndex = 7;
			// 
			// txtNumberPrints
			// 
			txtNumberPrints.Font = new Font("Cambria", 10.2F);
			txtNumberPrints.Location = new Point(462, 116);
			txtNumberPrints.Name = "txtNumberPrints";
			txtNumberPrints.Size = new Size(186, 27);
			txtNumberPrints.TabIndex = 9;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Cambria", 13.8F, FontStyle.Italic);
			label5.Location = new Point(365, 116);
			label5.Name = "label5";
			label5.Size = new Size(95, 27);
			label5.TabIndex = 8;
			label5.Text = "Quantity";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(btnExporttxtpaper);
			groupBox1.Controls.Add(btnclearcontrols);
			groupBox1.Controls.Add(btnpricepaper);
			groupBox1.Controls.Add(btnsearchAvailablepaper);
			groupBox1.Controls.Add(btncancel_purchase);
			groupBox1.Controls.Add(txtNumberPrints);
			groupBox1.Controls.Add(btnAddsales);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(cbsize);
			groupBox1.Controls.Add(txtPricesales);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(cbAvailablepaper);
			groupBox1.Controls.Add(cbSalesOptions);
			groupBox1.Controls.Add(label4);
			groupBox1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			groupBox1.ForeColor = Color.DarkBlue;
			groupBox1.Location = new Point(23, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(750, 323);
			groupBox1.TabIndex = 10;
			groupBox1.TabStop = false;
			groupBox1.Text = "Register Sale";
			// 
			// btnExporttxtpaper
			// 
			btnExporttxtpaper.BackColor = Color.SteelBlue;
			btnExporttxtpaper.FlatStyle = FlatStyle.Flat;
			btnExporttxtpaper.Font = new Font("Cambria", 12F, FontStyle.Bold);
			btnExporttxtpaper.ForeColor = SystemColors.ButtonHighlight;
			btnExporttxtpaper.Location = new Point(551, 249);
			btnExporttxtpaper.Name = "btnExporttxtpaper";
			btnExporttxtpaper.Size = new Size(167, 64);
			btnExporttxtpaper.TabIndex = 16;
			btnExporttxtpaper.Text = "Extract Paper\r\nDatabase";
			btnExporttxtpaper.UseVisualStyleBackColor = false;
			btnExporttxtpaper.Click += btnExporttxtpaper_Click;
			// 
			// btnclearcontrols
			// 
			btnclearcontrols.BackColor = Color.LightSkyBlue;
			btnclearcontrols.FlatStyle = FlatStyle.Flat;
			btnclearcontrols.Font = new Font("Cambria", 12F, FontStyle.Bold);
			btnclearcontrols.ForeColor = SystemColors.ButtonHighlight;
			btnclearcontrols.Location = new Point(369, 249);
			btnclearcontrols.Name = "btnclearcontrols";
			btnclearcontrols.Size = new Size(171, 64);
			btnclearcontrols.TabIndex = 18;
			btnclearcontrols.Text = "Clear";
			btnclearcontrols.UseVisualStyleBackColor = false;
			btnclearcontrols.Click += btnclearcontrols_Click;
			// 
			// btnpricepaper
			// 
			btnpricepaper.BackColor = Color.LightYellow;
			btnpricepaper.IconChar = FontAwesome.Sharp.IconChar.Search;
			btnpricepaper.IconColor = Color.Goldenrod;
			btnpricepaper.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnpricepaper.IconSize = 30;
			btnpricepaper.Location = new Point(639, 38);
			btnpricepaper.Name = "btnpricepaper";
			btnpricepaper.Size = new Size(41, 35);
			btnpricepaper.TabIndex = 17;
			btnpricepaper.UseVisualStyleBackColor = false;
			btnpricepaper.Click += btnpricepaper_Click;
			// 
			// btnsearchAvailablepaper
			// 
			btnsearchAvailablepaper.BackColor = Color.LightYellow;
			btnsearchAvailablepaper.IconChar = FontAwesome.Sharp.IconChar.Search;
			btnsearchAvailablepaper.IconColor = Color.Goldenrod;
			btnsearchAvailablepaper.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnsearchAvailablepaper.IconSize = 30;
			btnsearchAvailablepaper.Location = new Point(309, 111);
			btnsearchAvailablepaper.Name = "btnsearchAvailablepaper";
			btnsearchAvailablepaper.Size = new Size(41, 35);
			btnsearchAvailablepaper.TabIndex = 16;
			btnsearchAvailablepaper.UseVisualStyleBackColor = false;
			btnsearchAvailablepaper.Click += btnsearchAvailablepaper_Click;
			// 
			// btncancel_purchase
			// 
			btncancel_purchase.BackColor = Color.IndianRed;
			btncancel_purchase.FlatStyle = FlatStyle.Flat;
			btncancel_purchase.Font = new Font("Cambria", 12F, FontStyle.Bold);
			btncancel_purchase.ForeColor = SystemColors.ButtonHighlight;
			btncancel_purchase.Location = new Point(186, 250);
			btncancel_purchase.Name = "btncancel_purchase";
			btncancel_purchase.Size = new Size(171, 64);
			btncancel_purchase.TabIndex = 15;
			btncancel_purchase.Text = "Cancel purchase";
			btncancel_purchase.UseVisualStyleBackColor = false;
			btncancel_purchase.Click += btncancel_purchase_Click;
			// 
			// btnAddsales
			// 
			btnAddsales.BackColor = Color.LightGreen;
			btnAddsales.FlatStyle = FlatStyle.Flat;
			btnAddsales.Font = new Font("Cambria", 12F, FontStyle.Bold);
			btnAddsales.ForeColor = SystemColors.ButtonHighlight;
			btnAddsales.Location = new Point(9, 249);
			btnAddsales.Name = "btnAddsales";
			btnAddsales.Size = new Size(171, 64);
			btnAddsales.TabIndex = 14;
			btnAddsales.Text = "Add";
			btnAddsales.UseVisualStyleBackColor = false;
			btnAddsales.Click += btnAddsales_Click;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(btnexportsalesexcel);
			groupBox2.Controls.Add(btnExportpdfXML);
			groupBox2.Controls.Add(btncalculate);
			groupBox2.Controls.Add(txtChange);
			groupBox2.Controls.Add(label9);
			groupBox2.Controls.Add(txtPayment);
			groupBox2.Controls.Add(label10);
			groupBox2.Controls.Add(txtTotal);
			groupBox2.Controls.Add(label8);
			groupBox2.Controls.Add(txtIVA);
			groupBox2.Controls.Add(label7);
			groupBox2.Controls.Add(txtSubtotal);
			groupBox2.Controls.Add(label6);
			groupBox2.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			groupBox2.ForeColor = Color.DarkRed;
			groupBox2.Location = new Point(850, 21);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(470, 710);
			groupBox2.TabIndex = 11;
			groupBox2.TabStop = false;
			groupBox2.Text = "Payment";
			// 
			// btnexportsalesexcel
			// 
			btnexportsalesexcel.BackColor = Color.YellowGreen;
			btnexportsalesexcel.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
			btnexportsalesexcel.ForeColor = SystemColors.ButtonHighlight;
			btnexportsalesexcel.Location = new Point(154, 496);
			btnexportsalesexcel.Name = "btnexportsalesexcel";
			btnexportsalesexcel.Size = new Size(223, 64);
			btnexportsalesexcel.TabIndex = 22;
			btnexportsalesexcel.Text = "Export Sales";
			btnexportsalesexcel.UseVisualStyleBackColor = false;
			btnexportsalesexcel.Click += btnexportsalesexcel_Click;
			// 
			// btnExportpdfXML
			// 
			btnExportpdfXML.BackColor = Color.DarkSalmon;
			btnExportpdfXML.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
			btnExportpdfXML.ForeColor = SystemColors.ButtonHighlight;
			btnExportpdfXML.Location = new Point(154, 412);
			btnExportpdfXML.Name = "btnExportpdfXML";
			btnExportpdfXML.Size = new Size(223, 64);
			btnExportpdfXML.TabIndex = 13;
			btnExportpdfXML.Text = "Export Invoice";
			btnExportpdfXML.UseVisualStyleBackColor = false;
			btnExportpdfXML.Click += btnExportpdfXML_Click;
			// 
			// btncalculate
			// 
			btncalculate.BackColor = Color.Firebrick;
			btncalculate.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
			btncalculate.ForeColor = SystemColors.ButtonHighlight;
			btncalculate.Location = new Point(154, 333);
			btncalculate.Name = "btncalculate";
			btncalculate.Size = new Size(223, 64);
			btncalculate.TabIndex = 17;
			btncalculate.Text = "Calculate";
			btncalculate.UseVisualStyleBackColor = false;
			btncalculate.Click += btncalculate_Click;
			// 
			// txtChange
			// 
			txtChange.Font = new Font("Cambria", 10.2F);
			txtChange.Location = new Point(205, 270);
			txtChange.Name = "txtChange";
			txtChange.ReadOnly = true;
			txtChange.Size = new Size(186, 27);
			txtChange.TabIndex = 21;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Cambria", 13.8F, FontStyle.Italic);
			label9.Location = new Point(115, 270);
			label9.Name = "label9";
			label9.Size = new Size(83, 27);
			label9.TabIndex = 20;
			label9.Text = "Change";
			// 
			// txtPayment
			// 
			txtPayment.Font = new Font("Cambria", 10.2F);
			txtPayment.Location = new Point(205, 221);
			txtPayment.Name = "txtPayment";
			txtPayment.Size = new Size(186, 27);
			txtPayment.TabIndex = 19;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Cambria", 13.8F, FontStyle.Italic);
			label10.Location = new Point(44, 221);
			label10.Name = "label10";
			label10.Size = new Size(156, 27);
			label10.TabIndex = 18;
			label10.Text = "Payment in full";
			// 
			// txtTotal
			// 
			txtTotal.Font = new Font("Cambria", 10.2F);
			txtTotal.Location = new Point(202, 168);
			txtTotal.Name = "txtTotal";
			txtTotal.ReadOnly = true;
			txtTotal.Size = new Size(186, 27);
			txtTotal.TabIndex = 17;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Cambria", 13.8F, FontStyle.Italic);
			label8.Location = new Point(139, 172);
			label8.Name = "label8";
			label8.Size = new Size(61, 27);
			label8.TabIndex = 16;
			label8.Text = "Total";
			// 
			// txtIVA
			// 
			txtIVA.Font = new Font("Cambria", 10.2F);
			txtIVA.Location = new Point(202, 120);
			txtIVA.Name = "txtIVA";
			txtIVA.ReadOnly = true;
			txtIVA.Size = new Size(186, 27);
			txtIVA.TabIndex = 15;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Cambria", 13.8F, FontStyle.Italic);
			label7.Location = new Point(154, 124);
			label7.Name = "label7";
			label7.Size = new Size(44, 27);
			label7.TabIndex = 14;
			label7.Text = "IVA";
			// 
			// txtSubtotal
			// 
			txtSubtotal.Font = new Font("Cambria", 10.2F);
			txtSubtotal.Location = new Point(205, 72);
			txtSubtotal.Name = "txtSubtotal";
			txtSubtotal.ReadOnly = true;
			txtSubtotal.Size = new Size(186, 27);
			txtSubtotal.TabIndex = 13;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Cambria", 13.8F, FontStyle.Italic);
			label6.Location = new Point(105, 72);
			label6.Name = "label6";
			label6.Size = new Size(93, 27);
			label6.TabIndex = 12;
			label6.Text = "Subtotal";
			// 
			// dgvSalePrint
			// 
			dgvSalePrint.BackgroundColor = Color.LightBlue;
			dgvSalePrint.BorderStyle = BorderStyle.None;
			dgvSalePrint.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvSalePrint.Location = new Point(12, 341);
			dgvSalePrint.Name = "dgvSalePrint";
			dgvSalePrint.RowHeadersWidth = 51;
			dgvSalePrint.Size = new Size(832, 390);
			dgvSalePrint.TabIndex = 12;
			// 
			// btnreset
			// 
			btnreset.BackColor = Color.LightYellow;
			btnreset.IconChar = FontAwesome.Sharp.IconChar.Redo;
			btnreset.IconColor = Color.LightCoral;
			btnreset.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnreset.Location = new Point(779, 284);
			btnreset.Name = "btnreset";
			btnreset.Size = new Size(61, 51);
			btnreset.TabIndex = 19;
			btnreset.UseVisualStyleBackColor = false;
			btnreset.Click += btnreset_Click;
			// 
			// FrmSalePrints
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoScroll = true;
			BackColor = Color.AliceBlue;
			ClientSize = new Size(1332, 743);
			Controls.Add(btnreset);
			Controls.Add(dgvSalePrint);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Name = "FrmSalePrints";
			Text = "SalePrints";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvSalePrint).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
		private ComboBox cbsize;
		private ComboBox cbAvailablepaper;
		private Label label2;
		private Label label3;
		private ComboBox cbSalesOptions;
		private Label label4;
		private TextBox txtPricesales;
		private TextBox txtNumberPrints;
		private Label label5;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private TextBox txtSubtotal;
		private Label label6;
		private TextBox txtTotal;
		private Label label8;
		private TextBox txtIVA;
		private Label label7;
		private DataGridView dgvSalePrint;
		private TextBox txtChange;
		private Label label9;
		private TextBox txtPayment;
		private Label label10;
		private Button btnExportpdfXML;
		private Button btnAddsales;
		private Button btncancel_purchase;
		private Button btnExporttxtpaper;
		private FontAwesome.Sharp.IconButton btnsearchAvailablepaper;
		private FontAwesome.Sharp.IconButton btnpricepaper;
		private Button btnclearcontrols;
		private Button btncalculate;
		private Button btnexportsalesexcel;
		private FontAwesome.Sharp.IconButton btnreset;
	}
}