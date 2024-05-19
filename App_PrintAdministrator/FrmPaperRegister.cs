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
	public partial class FrmPaperRegister : Form
	{
		public TypePaper[] paper;
		
		int currentindex;
		public FrmPaperRegister()
		{
			InitializeComponent();
			dgvPaperdata.Columns.Add("Name", "Name");
			dgvPaperdata.Columns.Add("Size", "Size");
			dgvPaperdata.Columns.Add("PricePacket", "PricePacket");
			dgvPaperdata.Columns.Add("PricePrint", "PricePrint");
			dgvPaperdata.Columns.Add("WhiteSheetPrice", "WhiteSheetPrice");
			dgvPaperdata.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvPaperdata.ReadOnly = true;
			paper = new TypePaper[20];
			currentindex = 0;
		}

		public void btnaddpaper_Click(object sender, EventArgs e)
		{

			if (currentindex == paper.Length)
			{
				MessageBox.Show("Full base");
				return;
			}
			try
			{

				TypePaper newTypePaper = new TypePaper();
				newTypePaper.Name = cbnamespaper.Text;
				newTypePaper.Size = cbsizepaper.Text;
				newTypePaper.Pricepacket = Convert.ToDecimal(txtpackegepricepaper.Text);
				newTypePaper.Priceprint = Convert.ToDecimal(txtpritingpricepaper.Text);
				newTypePaper.WhitesheetPrice = Convert.ToDecimal(txtwhitesheetprice.Text);
				paper[currentindex] = newTypePaper;
				currentindex++;
				dgvPaperdata.Rows.Add(newTypePaper.Name, newTypePaper.Size, newTypePaper.Pricepacket, newTypePaper.Priceprint, newTypePaper.WhitesheetPrice);
			}
			catch (FormatException)
			{
				MessageBox.Show("Incorrect format. Please try again");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void btndeletepaper_Click(object sender, EventArgs e)
		{
			if (dgvPaperdata.SelectedRows.Count == 0)
			{
				MessageBox.Show("Select a row to delete");
				return;
			}
			DataGridViewRow selectedRow = dgvPaperdata.SelectedRows[0];

			dgvPaperdata.Rows.Remove(selectedRow);
			for (int i = 0; i < currentindex; i++)
			{
				if (paper[i].Name == selectedRow.Cells[0].Value.ToString())
				{
					for (int j = i; j < currentindex - 1; j++)
					{
						paper[j] = paper[j + 1];
					}
					currentindex--;
					break;
				}
			}
			dgvPaperdata.Rows.Clear();
			for (int i = 0; i < currentindex; i++)
			{
				dgvPaperdata.Rows.Add(paper[i].Name, paper[i].Size, paper[i].Pricepacket, paper[i].Priceprint, paper[i].WhitesheetPrice);
			}

		}

		private void btnopenfilepaper_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFile = new OpenFileDialog();
			openFile.Filter = "Text files (*.txt)|*.txt";
			openFile.Title = "Open file";
			if (openFile.ShowDialog() != DialogResult.OK)
			{
				MessageBox.Show("No file selected");
				return;
			}
			dgvPaperdata.Rows.Clear();
			currentindex = 0;
			string[] lines = System.IO.File.ReadAllLines(openFile.FileName);
			for (int i = 0; i < lines.Length; i++)
			{
				string[] parts = lines[i].Split(',');
				TypePaper newTypePaper = new TypePaper();
				newTypePaper.Name = parts[0];
				newTypePaper.Size = parts[1];
				newTypePaper.Pricepacket = Convert.ToDecimal(parts[2]);
				newTypePaper.Priceprint = Convert.ToDecimal(parts[3]);
				newTypePaper.WhitesheetPrice = Convert.ToDecimal(parts[4]);
				paper[currentindex] = newTypePaper;
				currentindex++;
				dgvPaperdata.Rows.Add(newTypePaper.Name, newTypePaper.Size, newTypePaper.Pricepacket, newTypePaper.Priceprint, newTypePaper.WhitesheetPrice);
			}
		}

		private void btnsavefilepaper_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFile = new SaveFileDialog();
			saveFile.Filter = "Text files (*.txt)|*.txt";
			saveFile.Title = "Save file";
			try
			{
				if (saveFile.ShowDialog() != DialogResult.OK)
				{
					MessageBox.Show("No file selected");
					return;
				}
				using (System.IO.StreamWriter file = new System.IO.StreamWriter(saveFile.FileName))
				{
					for (int i = 0; i < currentindex; i++)
					{
						file.WriteLine(paper[i].Name + "," + paper[i].Size + "," + paper[i].Pricepacket + "," + paper[i].Priceprint + "," + paper[i].WhitesheetPrice);
					}
				}
				MessageBox.Show("File saved");
			}
			catch (Exception ex)
			{
				MessageBox.Show("The document could not be saved.Try again. " + ex);

			}

		}

	}
}

