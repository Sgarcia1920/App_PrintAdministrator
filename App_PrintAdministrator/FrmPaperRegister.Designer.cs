namespace App_PrintAdministrator
{
	partial class FrmPaperRegister
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
			label2 = new Label();
			txtpackegepricepaper = new TextBox();
			label3 = new Label();
			cbsizepaper = new ComboBox();
			cbnamespaper = new ComboBox();
			txtpritingpricepaper = new TextBox();
			label4 = new Label();
			txtwhitesheetprice = new TextBox();
			label5 = new Label();
			btnaddpaper = new FontAwesome.Sharp.IconButton();
			btndeletepaper = new FontAwesome.Sharp.IconButton();
			dgvPaperdata = new DataGridView();
			btnopenfilepaper = new FontAwesome.Sharp.IconButton();
			btnsavefilepaper = new FontAwesome.Sharp.IconButton();
			((System.ComponentModel.ISupportInitialize)dgvPaperdata).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Cambria", 16.2F, FontStyle.Italic);
			label1.Location = new Point(120, 88);
			label1.Name = "label1";
			label1.Size = new Size(84, 33);
			label1.TabIndex = 0;
			label1.Text = "Name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Cambria", 16.2F, FontStyle.Italic);
			label2.Location = new Point(142, 170);
			label2.Name = "label2";
			label2.Size = new Size(62, 33);
			label2.TabIndex = 2;
			label2.Text = "Size";
			// 
			// txtpackegepricepaper
			// 
			txtpackegepricepaper.Font = new Font("Cambria", 16.2F);
			txtpackegepricepaper.Location = new Point(220, 276);
			txtpackegepricepaper.Name = "txtpackegepricepaper";
			txtpackegepricepaper.Size = new Size(249, 39);
			txtpackegepricepaper.TabIndex = 7;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Cambria", 16.2F, FontStyle.Italic);
			label3.Location = new Point(105, 249);
			label3.Name = "label3";
			label3.Size = new Size(115, 66);
			label3.TabIndex = 6;
			label3.Text = "Package\r\nPrice";
			// 
			// cbsizepaper
			// 
			cbsizepaper.Font = new Font("Cambria", 16.2F);
			cbsizepaper.FormattingEnabled = true;
			cbsizepaper.Items.AddRange(new object[] { "Separador Tabloide 12 x 18 pulgadas", "Tabloide 11 x 17 pulgadas", "Carta 8.5 x 11 pulgadas", "Oficio 8.5 x 14 pulgadas ", "A4 8.27 x 11.69 pulgadas" });
			cbsizepaper.Location = new Point(221, 167);
			cbsizepaper.Name = "cbsizepaper";
			cbsizepaper.Size = new Size(248, 40);
			cbsizepaper.TabIndex = 8;
			// 
			// cbnamespaper
			// 
			cbnamespaper.Font = new Font("Cambria", 16.2F);
			cbnamespaper.FormattingEnabled = true;
			cbnamespaper.Items.AddRange(new object[] { "Couche Delgado", "Couche Grueso ", "Opalina", "Adhesivo", "Hoja de Máquina" });
			cbnamespaper.Location = new Point(221, 85);
			cbnamespaper.Name = "cbnamespaper";
			cbnamespaper.Size = new Size(248, 40);
			cbnamespaper.TabIndex = 9;
			// 
			// txtpritingpricepaper
			// 
			txtpritingpricepaper.Font = new Font("Cambria", 16.2F);
			txtpritingpricepaper.Location = new Point(220, 393);
			txtpritingpricepaper.Name = "txtpritingpricepaper";
			txtpritingpricepaper.Size = new Size(249, 39);
			txtpritingpricepaper.TabIndex = 11;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Cambria", 16.2F, FontStyle.Italic);
			label4.Location = new Point(105, 366);
			label4.Name = "label4";
			label4.Size = new Size(119, 66);
			label4.TabIndex = 10;
			label4.Text = "Printing \r\nPrice";
			// 
			// txtwhitesheetprice
			// 
			txtwhitesheetprice.Font = new Font("Cambria", 16.2F);
			txtwhitesheetprice.Location = new Point(220, 511);
			txtwhitesheetprice.Name = "txtwhitesheetprice";
			txtwhitesheetprice.Size = new Size(249, 39);
			txtwhitesheetprice.TabIndex = 13;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Cambria", 16.2F, FontStyle.Italic);
			label5.Location = new Point(62, 484);
			label5.Name = "label5";
			label5.Size = new Size(162, 66);
			label5.TabIndex = 12;
			label5.Text = "White Sheet \r\nPrice";
			// 
			// btnaddpaper
			// 
			btnaddpaper.BackColor = Color.LightGreen;
			btnaddpaper.FlatStyle = FlatStyle.Flat;
			btnaddpaper.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnaddpaper.ForeColor = SystemColors.ButtonHighlight;
			btnaddpaper.IconChar = FontAwesome.Sharp.IconChar.None;
			btnaddpaper.IconColor = Color.Black;
			btnaddpaper.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnaddpaper.Location = new Point(189, 587);
			btnaddpaper.Name = "btnaddpaper";
			btnaddpaper.Size = new Size(185, 49);
			btnaddpaper.TabIndex = 14;
			btnaddpaper.Text = "Add";
			btnaddpaper.UseVisualStyleBackColor = false;
			btnaddpaper.Click += btnaddpaper_Click;
			// 
			// btndeletepaper
			// 
			btndeletepaper.BackColor = Color.LightCoral;
			btndeletepaper.FlatStyle = FlatStyle.Flat;
			btndeletepaper.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btndeletepaper.ForeColor = SystemColors.ButtonHighlight;
			btndeletepaper.IconChar = FontAwesome.Sharp.IconChar.None;
			btndeletepaper.IconColor = Color.Black;
			btndeletepaper.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btndeletepaper.Location = new Point(189, 649);
			btndeletepaper.Name = "btndeletepaper";
			btndeletepaper.Size = new Size(185, 49);
			btndeletepaper.TabIndex = 16;
			btndeletepaper.Text = "Delete";
			btndeletepaper.UseVisualStyleBackColor = false;
			btndeletepaper.Click += btndeletepaper_Click;
			// 
			// dgvPaperdata
			// 
			dgvPaperdata.BackgroundColor = Color.LightBlue;
			dgvPaperdata.BorderStyle = BorderStyle.None;
			dgvPaperdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvPaperdata.Location = new Point(581, 121);
			dgvPaperdata.Name = "dgvPaperdata";
			dgvPaperdata.RowHeadersWidth = 51;
			dgvPaperdata.Size = new Size(725, 589);
			dgvPaperdata.TabIndex = 17;
			// 
			// btnopenfilepaper
			// 
			btnopenfilepaper.BackColor = Color.PowderBlue;
			btnopenfilepaper.FlatStyle = FlatStyle.Flat;
			btnopenfilepaper.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnopenfilepaper.ForeColor = SystemColors.ButtonHighlight;
			btnopenfilepaper.IconChar = FontAwesome.Sharp.IconChar.None;
			btnopenfilepaper.IconColor = Color.Black;
			btnopenfilepaper.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnopenfilepaper.Location = new Point(616, 42);
			btnopenfilepaper.Name = "btnopenfilepaper";
			btnopenfilepaper.Size = new Size(221, 61);
			btnopenfilepaper.TabIndex = 18;
			btnopenfilepaper.Text = "Open File ";
			btnopenfilepaper.UseVisualStyleBackColor = false;
			btnopenfilepaper.Click += btnopenfilepaper_Click;
			// 
			// btnsavefilepaper
			// 
			btnsavefilepaper.BackColor = Color.Teal;
			btnsavefilepaper.FlatStyle = FlatStyle.Flat;
			btnsavefilepaper.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnsavefilepaper.ForeColor = SystemColors.ButtonHighlight;
			btnsavefilepaper.IconChar = FontAwesome.Sharp.IconChar.None;
			btnsavefilepaper.IconColor = Color.Black;
			btnsavefilepaper.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnsavefilepaper.Location = new Point(1070, 42);
			btnsavefilepaper.Name = "btnsavefilepaper";
			btnsavefilepaper.Size = new Size(221, 61);
			btnsavefilepaper.TabIndex = 20;
			btnsavefilepaper.Text = "Save as txt";
			btnsavefilepaper.UseVisualStyleBackColor = false;
			btnsavefilepaper.Click += btnsavefilepaper_Click;
			// 
			// FrmPaperRegister
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.AliceBlue;
			ClientSize = new Size(1332, 743);
			Controls.Add(btnsavefilepaper);
			Controls.Add(btnopenfilepaper);
			Controls.Add(dgvPaperdata);
			Controls.Add(btndeletepaper);
			Controls.Add(btnaddpaper);
			Controls.Add(txtwhitesheetprice);
			Controls.Add(label5);
			Controls.Add(txtpritingpricepaper);
			Controls.Add(label4);
			Controls.Add(cbnamespaper);
			Controls.Add(cbsizepaper);
			Controls.Add(txtpackegepricepaper);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "FrmPaperRegister";
			Text = "FrmPaperRegister";
			((System.ComponentModel.ISupportInitialize)dgvPaperdata).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox txtpackegepricepaper;
		private Label label3;
		private ComboBox cbsizepaper;
		private ComboBox cbnamespaper;
		private TextBox txtpritingpricepaper;
		private Label label4;
		private TextBox txtwhitesheetprice;
		private Label label5;
		private FontAwesome.Sharp.IconButton btnaddpaper;
		private FontAwesome.Sharp.IconButton btndeletepaper;
		private DataGridView dgvPaperdata;
		private FontAwesome.Sharp.IconButton btnopenfilepaper;
		private FontAwesome.Sharp.IconButton btnsavefilepaper;
	}
}