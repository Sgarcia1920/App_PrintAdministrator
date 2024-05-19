namespace App_PrintAdministrator
{
	partial class FrmPrinterRegistration
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
			txtbrand = new TextBox();
			txtserienumber = new TextBox();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			txtrentprice = new TextBox();
			txtsaleprice = new TextBox();
			txtdescripcion = new TextBox();
			label5 = new Label();
			label7 = new Label();
			cbconditionprinter = new ComboBox();
			dvgprinter = new DataGridView();
			btnAddprinter = new FontAwesome.Sharp.IconButton();
			btnDeleteprinter = new FontAwesome.Sharp.IconButton();
			btnSavewordprinter = new Button();
			cbTypeprinter = new ComboBox();
			label6 = new Label();
			btnsearchpricesPrinter = new FontAwesome.Sharp.IconButton();
			((System.ComponentModel.ISupportInitialize)dvgprinter).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Cambria", 13.8F, FontStyle.Italic);
			label1.Location = new Point(86, 40);
			label1.Name = "label1";
			label1.Size = new Size(71, 27);
			label1.TabIndex = 0;
			label1.Text = "Brand";
			label1.TextAlign = ContentAlignment.TopCenter;
			// 
			// txtbrand
			// 
			txtbrand.Enabled = false;
			txtbrand.Font = new Font("Cambria", 13.8F);
			txtbrand.ForeColor = Color.Red;
			txtbrand.Location = new Point(165, 40);
			txtbrand.Name = "txtbrand";
			txtbrand.ReadOnly = true;
			txtbrand.Size = new Size(249, 34);
			txtbrand.TabIndex = 1;
			// 
			// txtserienumber
			// 
			txtserienumber.Font = new Font("Cambria", 13.8F);
			txtserienumber.Location = new Point(167, 168);
			txtserienumber.Name = "txtserienumber";
			txtserienumber.Size = new Size(247, 34);
			txtserienumber.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Cambria", 13.8F, FontStyle.Italic);
			label2.Location = new Point(97, 171);
			label2.Name = "label2";
			label2.Size = new Size(60, 27);
			label2.TabIndex = 2;
			label2.Text = "Serie";
			label2.TextAlign = ContentAlignment.TopCenter;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Cambria", 13.8F, FontStyle.Italic);
			label3.Location = new Point(93, 303);
			label3.Name = "label3";
			label3.Size = new Size(61, 54);
			label3.TabIndex = 6;
			label3.Text = "Rent\r\nPrice";
			label3.TextAlign = ContentAlignment.TopCenter;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Cambria", 13.8F, FontStyle.Italic);
			label4.Location = new Point(92, 217);
			label4.Name = "label4";
			label4.Size = new Size(61, 54);
			label4.TabIndex = 4;
			label4.Text = "Sale\r\nPrice";
			label4.TextAlign = ContentAlignment.TopCenter;
			// 
			// txtrentprice
			// 
			txtrentprice.Enabled = false;
			txtrentprice.Font = new Font("Cambria", 13.8F);
			txtrentprice.Location = new Point(167, 323);
			txtrentprice.Name = "txtrentprice";
			txtrentprice.ReadOnly = true;
			txtrentprice.Size = new Size(247, 34);
			txtrentprice.TabIndex = 12;
			// 
			// txtsaleprice
			// 
			txtsaleprice.Enabled = false;
			txtsaleprice.Font = new Font("Cambria", 13.8F);
			txtsaleprice.Location = new Point(165, 237);
			txtsaleprice.Name = "txtsaleprice";
			txtsaleprice.ReadOnly = true;
			txtsaleprice.Size = new Size(249, 34);
			txtsaleprice.TabIndex = 13;
			// 
			// txtdescripcion
			// 
			txtdescripcion.Font = new Font("Cambria", 13.8F);
			txtdescripcion.Location = new Point(60, 476);
			txtdescripcion.Multiline = true;
			txtdescripcion.Name = "txtdescripcion";
			txtdescripcion.Size = new Size(416, 151);
			txtdescripcion.TabIndex = 16;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Cambria", 13.8F, FontStyle.Italic);
			label5.Location = new Point(110, 446);
			label5.Name = "label5";
			label5.Size = new Size(319, 27);
			label5.TabIndex = 15;
			label5.Text = "Physical condition observations ";
			label5.TextAlign = ContentAlignment.TopCenter;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Cambria", 13.8F, FontStyle.Italic);
			label7.Location = new Point(60, 389);
			label7.Name = "label7";
			label7.Size = new Size(104, 27);
			label7.TabIndex = 17;
			label7.Text = "Condition";
			label7.TextAlign = ContentAlignment.TopCenter;
			// 
			// cbconditionprinter
			// 
			cbconditionprinter.Font = new Font("Cambria", 13.8F);
			cbconditionprinter.FormattingEnabled = true;
			cbconditionprinter.Items.AddRange(new object[] { "Completely new", "Used", "Damaged", "Unusable" });
			cbconditionprinter.Location = new Point(165, 386);
			cbconditionprinter.Name = "cbconditionprinter";
			cbconditionprinter.Size = new Size(256, 35);
			cbconditionprinter.TabIndex = 18;
			// 
			// dvgprinter
			// 
			dvgprinter.BackgroundColor = Color.LightBlue;
			dvgprinter.BorderStyle = BorderStyle.None;
			dvgprinter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dvgprinter.Location = new Point(538, 40);
			dvgprinter.Name = "dvgprinter";
			dvgprinter.RowHeadersWidth = 51;
			dvgprinter.Size = new Size(748, 530);
			dvgprinter.TabIndex = 19;
			// 
			// btnAddprinter
			// 
			btnAddprinter.BackColor = Color.LightGreen;
			btnAddprinter.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
			btnAddprinter.ForeColor = SystemColors.ButtonHighlight;
			btnAddprinter.IconChar = FontAwesome.Sharp.IconChar.None;
			btnAddprinter.IconColor = Color.Black;
			btnAddprinter.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnAddprinter.Location = new Point(76, 648);
			btnAddprinter.Name = "btnAddprinter";
			btnAddprinter.Size = new Size(166, 50);
			btnAddprinter.TabIndex = 20;
			btnAddprinter.Text = "Add";
			btnAddprinter.UseVisualStyleBackColor = false;
			btnAddprinter.Click += btnAddprinter_Click;
			// 
			// btnDeleteprinter
			// 
			btnDeleteprinter.BackColor = Color.LightCoral;
			btnDeleteprinter.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
			btnDeleteprinter.ForeColor = SystemColors.ButtonHighlight;
			btnDeleteprinter.IconChar = FontAwesome.Sharp.IconChar.None;
			btnDeleteprinter.IconColor = Color.Black;
			btnDeleteprinter.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnDeleteprinter.Location = new Point(263, 648);
			btnDeleteprinter.Name = "btnDeleteprinter";
			btnDeleteprinter.Size = new Size(166, 50);
			btnDeleteprinter.TabIndex = 21;
			btnDeleteprinter.Text = "Delete";
			btnDeleteprinter.UseVisualStyleBackColor = false;
			btnDeleteprinter.Click += btnDeleteprinter_Click;
			// 
			// btnSavewordprinter
			// 
			btnSavewordprinter.BackColor = Color.Teal;
			btnSavewordprinter.FlatAppearance.BorderColor = Color.White;
			btnSavewordprinter.FlatStyle = FlatStyle.Flat;
			btnSavewordprinter.Font = new Font("Cambria", 13.8F, FontStyle.Bold);
			btnSavewordprinter.ForeColor = SystemColors.ButtonHighlight;
			btnSavewordprinter.Location = new Point(789, 601);
			btnSavewordprinter.Name = "btnSavewordprinter";
			btnSavewordprinter.Size = new Size(233, 66);
			btnSavewordprinter.TabIndex = 22;
			btnSavewordprinter.Text = "Save printer word";
			btnSavewordprinter.UseVisualStyleBackColor = false;
			btnSavewordprinter.Click += btnSavewordprinter_Click;
			// 
			// cbTypeprinter
			// 
			cbTypeprinter.Font = new Font("Cambria", 13.8F);
			cbTypeprinter.FormattingEnabled = true;
			cbTypeprinter.Items.AddRange(new object[] { "Phaser", "Workcenter", "VersaLink" });
			cbTypeprinter.Location = new Point(165, 99);
			cbTypeprinter.Name = "cbTypeprinter";
			cbTypeprinter.Size = new Size(249, 35);
			cbTypeprinter.TabIndex = 24;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Cambria", 13.8F, FontStyle.Italic);
			label6.Location = new Point(93, 102);
			label6.Name = "label6";
			label6.Size = new Size(59, 27);
			label6.TabIndex = 23;
			label6.Text = "Type";
			label6.TextAlign = ContentAlignment.TopCenter;
			// 
			// btnsearchpricesPrinter
			// 
			btnsearchpricesPrinter.BackColor = Color.LightYellow;
			btnsearchpricesPrinter.ForeColor = SystemColors.ButtonHighlight;
			btnsearchpricesPrinter.IconChar = FontAwesome.Sharp.IconChar.Search;
			btnsearchpricesPrinter.IconColor = Color.Goldenrod;
			btnsearchpricesPrinter.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnsearchpricesPrinter.IconSize = 30;
			btnsearchpricesPrinter.Location = new Point(420, 167);
			btnsearchpricesPrinter.Name = "btnsearchpricesPrinter";
			btnsearchpricesPrinter.Size = new Size(41, 35);
			btnsearchpricesPrinter.TabIndex = 25;
			btnsearchpricesPrinter.UseVisualStyleBackColor = false;
			btnsearchpricesPrinter.Click += btnsearchpricesPrinter_Click;
			// 
			// FrmPrinterRegistration
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.AliceBlue;
			ClientSize = new Size(1332, 743);
			Controls.Add(btnsearchpricesPrinter);
			Controls.Add(cbTypeprinter);
			Controls.Add(label6);
			Controls.Add(btnSavewordprinter);
			Controls.Add(btnDeleteprinter);
			Controls.Add(btnAddprinter);
			Controls.Add(dvgprinter);
			Controls.Add(cbconditionprinter);
			Controls.Add(label7);
			Controls.Add(txtdescripcion);
			Controls.Add(label5);
			Controls.Add(txtsaleprice);
			Controls.Add(txtrentprice);
			Controls.Add(label3);
			Controls.Add(label4);
			Controls.Add(txtserienumber);
			Controls.Add(label2);
			Controls.Add(txtbrand);
			Controls.Add(label1);
			Name = "FrmPrinterRegistration";
			Text = "PrinterRegistration";
			((System.ComponentModel.ISupportInitialize)dvgprinter).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtbrand;
		private TextBox txtserienumber;
		private Label label2;
		private Label label3;
		private Label label4;
		private TextBox txtrentprice;
		private TextBox txtsaleprice;
		private TextBox txtdescripcion;
		private Label label5;
		private Label label7;
		private ComboBox cbconditionprinter;
		private DataGridView dvgprinter;
		private FontAwesome.Sharp.IconButton btnAddprinter;
		private FontAwesome.Sharp.IconButton btnDeleteprinter;
		private Button btnSavewordprinter;
		private ComboBox cbTypeprinter;
		private Label label6;
		private FontAwesome.Sharp.IconButton btnsearchpricesPrinter;
	}
}