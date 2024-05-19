using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_PrintAdministrator
{
	public partial class FrmNotes : Form
	{
		public FrmNotes()
		{
			InitializeComponent();
		}

		private void btnSaveNotes_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
			if (saveFileDialog.ShowDialog() != DialogResult.OK)
			{
				MessageBox.Show("No data entry");
			}
			System.IO.StreamWriter file = new System.IO.StreamWriter(saveFileDialog.FileName);
			file.WriteLine(txtnotes.Text);
			file.Close();
		}

		private void btnOpennotes_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				MessageBox.Show("No data entry");
			}
			System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog.FileName);
			txtnotes.Text = file.ReadToEnd();
			file.Close();

		}
	}
}
