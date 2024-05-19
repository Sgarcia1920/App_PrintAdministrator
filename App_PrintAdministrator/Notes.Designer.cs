namespace App_PrintAdministrator
{
	partial class FrmNotes
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
			btnOpennotes = new Button();
			btnSaveNotes = new Button();
			txtnotes = new TextBox();
			SuspendLayout();
			// 
			// btnOpennotes
			// 
			btnOpennotes.BackColor = Color.LightBlue;
			btnOpennotes.Font = new Font("Cambria", 12F, FontStyle.Bold);
			btnOpennotes.ForeColor = SystemColors.ButtonHighlight;
			btnOpennotes.Location = new Point(401, 89);
			btnOpennotes.Name = "btnOpennotes";
			btnOpennotes.Size = new Size(224, 86);
			btnOpennotes.TabIndex = 0;
			btnOpennotes.Text = "Open Notes";
			btnOpennotes.UseVisualStyleBackColor = false;
			btnOpennotes.Click += btnOpennotes_Click;
			// 
			// btnSaveNotes
			// 
			btnSaveNotes.BackColor = Color.Teal;
			btnSaveNotes.Font = new Font("Cambria", 12F, FontStyle.Bold);
			btnSaveNotes.ForeColor = SystemColors.ButtonHighlight;
			btnSaveNotes.Location = new Point(759, 89);
			btnSaveNotes.Name = "btnSaveNotes";
			btnSaveNotes.Size = new Size(224, 86);
			btnSaveNotes.TabIndex = 1;
			btnSaveNotes.Text = "Save Notes";
			btnSaveNotes.UseVisualStyleBackColor = false;
			btnSaveNotes.Click += btnSaveNotes_Click;
			// 
			// txtnotes
			// 
			txtnotes.BorderStyle = BorderStyle.None;
			txtnotes.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtnotes.ForeColor = Color.DarkBlue;
			txtnotes.Location = new Point(82, 199);
			txtnotes.Multiline = true;
			txtnotes.Name = "txtnotes";
			txtnotes.Size = new Size(1154, 501);
			txtnotes.TabIndex = 2;
			// 
			// FrmNotes
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.AliceBlue;
			ClientSize = new Size(1332, 743);
			Controls.Add(txtnotes);
			Controls.Add(btnSaveNotes);
			Controls.Add(btnOpennotes);
			Name = "FrmNotes";
			Text = "Notes";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnOpennotes;
		private Button btnSaveNotes;
		private TextBox txtnotes;
	}
}