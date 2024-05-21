namespace App_PrintAdministrator
{
	partial class FrmMenu
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnPaper_register = new FontAwesome.Sharp.IconButton();
			btnSales_print = new FontAwesome.Sharp.IconButton();
			btn_notes = new FontAwesome.Sharp.IconButton();
			btnPrinter_registration = new FontAwesome.Sharp.IconButton();
			SuspendLayout();
			// 
			// btnPaper_register
			// 
			btnPaper_register.BackColor = Color.LightGray;
			btnPaper_register.FlatAppearance.BorderColor = Color.White;
			btnPaper_register.FlatStyle = FlatStyle.Flat;
			btnPaper_register.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
			btnPaper_register.ForeColor = SystemColors.ButtonHighlight;
			btnPaper_register.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
			btnPaper_register.IconColor = SystemColors.ButtonHighlight;
			btnPaper_register.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnPaper_register.ImageAlign = ContentAlignment.MiddleRight;
			btnPaper_register.Location = new Point(498, 299);
			btnPaper_register.Name = "btnPaper_register";
			btnPaper_register.Size = new Size(298, 121);
			btnPaper_register.TabIndex = 0;
			btnPaper_register.Text = "Paper Register";
			btnPaper_register.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnPaper_register.UseVisualStyleBackColor = false;
			btnPaper_register.Click += btnPaper_register_Click;
			// 
			// btnSales_print
			// 
			btnSales_print.BackColor = Color.MediumAquamarine;
			btnSales_print.FlatStyle = FlatStyle.Flat;
			btnSales_print.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
			btnSales_print.ForeColor = Color.Ivory;
			btnSales_print.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
			btnSales_print.IconColor = Color.Ivory;
			btnSales_print.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnSales_print.Location = new Point(161, 139);
			btnSales_print.Name = "btnSales_print";
			btnSales_print.Size = new Size(298, 121);
			btnSales_print.TabIndex = 2;
			btnSales_print.Text = "Prints Sales";
			btnSales_print.TextAlign = ContentAlignment.MiddleRight;
			btnSales_print.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnSales_print.UseVisualStyleBackColor = false;
			btnSales_print.Click += btnSales_print_Click;
			// 
			// btn_notes
			// 
			btn_notes.BackColor = Color.DarkGray;
			btn_notes.FlatStyle = FlatStyle.Flat;
			btn_notes.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
			btn_notes.ForeColor = SystemColors.ButtonHighlight;
			btn_notes.IconChar = FontAwesome.Sharp.IconChar.NoteSticky;
			btn_notes.IconColor = SystemColors.ButtonHighlight;
			btn_notes.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btn_notes.ImageAlign = ContentAlignment.MiddleRight;
			btn_notes.Location = new Point(161, 299);
			btn_notes.Name = "btn_notes";
			btn_notes.Size = new Size(298, 121);
			btn_notes.TabIndex = 5;
			btn_notes.Text = "Notes";
			btn_notes.TextImageRelation = TextImageRelation.ImageBeforeText;
			btn_notes.UseVisualStyleBackColor = false;
			btn_notes.Click += btn_notes_Click;
			// 
			// btnPrinter_registration
			// 
			btnPrinter_registration.BackColor = Color.CornflowerBlue;
			btnPrinter_registration.FlatStyle = FlatStyle.Flat;
			btnPrinter_registration.Font = new Font("Cambria", 16.2F, FontStyle.Bold);
			btnPrinter_registration.ForeColor = Color.MintCream;
			btnPrinter_registration.IconChar = FontAwesome.Sharp.IconChar.Print;
			btnPrinter_registration.IconColor = Color.WhiteSmoke;
			btnPrinter_registration.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnPrinter_registration.Location = new Point(498, 139);
			btnPrinter_registration.Name = "btnPrinter_registration";
			btnPrinter_registration.Size = new Size(298, 121);
			btnPrinter_registration.TabIndex = 1;
			btnPrinter_registration.Text = "Printer registration";
			btnPrinter_registration.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnPrinter_registration.UseVisualStyleBackColor = false;
			btnPrinter_registration.Click += btnPrinter_registration_Click;
			// 
			// FrmMenu
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.AliceBlue;
			ClientSize = new Size(982, 553);
			Controls.Add(btn_notes);
			Controls.Add(btnSales_print);
			Controls.Add(btnPrinter_registration);
			Controls.Add(btnPaper_register);
			Name = "FrmMenu";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Menu";
			ResumeLayout(false);
		}

		#endregion

		private FontAwesome.Sharp.IconButton btnPaper_register;
		private FontAwesome.Sharp.IconButton btnSales_print;
		private FontAwesome.Sharp.IconButton btn_notes;
		private FontAwesome.Sharp.IconButton btnPrinter_registration;
	}
}
