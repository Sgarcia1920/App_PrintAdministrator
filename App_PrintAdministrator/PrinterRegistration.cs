using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;


namespace App_PrintAdministrator
{
	public partial class FrmPrinterRegistration : Form
	{
		public FrmPrinterRegistration()
		{
			InitializeComponent();
			dvgprinter.Columns.Add("Brand", "Brand");
			dvgprinter.Columns.Add("Series", "Series");
			dvgprinter.Columns.Add("SalePrice", "Sale Price");
			dvgprinter.Columns.Add("RentPrice", "Rent Price");
			dvgprinter.Columns.Add("Condition", "Condition");
			dvgprinter.Columns.Add("Description", "Description");
			dvgprinter.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dvgprinter.ReadOnly = true;
			txtbrand.Text = new Printer().Brand;
		}

		private void btnAddprinter_Click(object sender, EventArgs e)
		{
			try
			{
				switch (cbTypeprinter.SelectedIndex)
				{
					case 0:
						Workcenter workcenter = new Workcenter(txtserienumber.Text, Convert.ToDecimal(txtsaleprice.Text), Convert.ToDecimal(txtrentprice.Text));
						dvgprinter.Rows.Add(workcenter.ShowBrand(), workcenter.Series, workcenter.SalePrice, workcenter.RentPrice, cbconditionprinter.Text, txtdescripcion.Text);

						break;
					case 1:
						Phaser phaser = new Phaser(txtserienumber.Text, Convert.ToDecimal(txtsaleprice.Text), Convert.ToDecimal(txtrentprice.Text));
						dvgprinter.Rows.Add(phaser.ShowBrand(),phaser.Series, phaser.SalePrice, phaser.RentPrice, cbconditionprinter.Text, txtdescripcion.Text);
						break;
					case 2:
						VersaLink versaLink = new VersaLink(txtserienumber.Text, Convert.ToDecimal(txtsaleprice.Text), Convert.ToDecimal(txtrentprice.Text));
						dvgprinter.Rows.Add(versaLink.ShowBrand(), versaLink.Series, versaLink.SalePrice, versaLink.RentPrice, cbconditionprinter.Text, txtdescripcion.Text);
						break;
					default:
						MessageBox.Show("Please select a printer");
						break;
				}

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

		private void btnDeleteprinter_Click(object sender, EventArgs e)
		{
			if (dvgprinter.SelectedRows.Count > 0)
			{
				dvgprinter.Rows.RemoveAt(dvgprinter.SelectedRows[0].Index);
			}
			else
			{
				MessageBox.Show("Please select a row to delete");
			}
		}

		private void btnSavewordprinter_Click(object sender, EventArgs e)
		{
			
		
			DataGridViewRow selectedRow = dvgprinter.SelectedRows[0];
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Word Document (*.docx)|*.docx";
			saveFileDialog.FileName = selectedRow.Cells[1].Value.ToString() + ".docx";
			if (saveFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			string filePath = saveFileDialog.FileName;
			using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
			{
				MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
				mainPart.Document = new Document();
				Body body = mainPart.Document.AppendChild(new Body());

				// Agregar el título en negrita
				Paragraph titlePara = body.AppendChild(new Paragraph());
				Run titleRun = titlePara.AppendChild(new Run());
				titleRun.AppendChild(new Text("Printer Registration"));
				titleRun.RunProperties = new RunProperties(new Bold());


				foreach (DataGridViewCell cell in selectedRow.Cells)
				{
					Paragraph para = body.AppendChild(new Paragraph());
					Run run = para.AppendChild(new Run());
			      	RunProperties runProp = new RunProperties();
					FontSize fontSize = new FontSize() { Val = "24" }; 
					runProp.Append(fontSize);
					run.RunProperties = runProp;
					run.AppendChild(new Text(dvgprinter.Columns[cell.ColumnIndex].HeaderText + ": "));
					run.AppendChild(new Text(cell.Value.ToString()));


				}


			}
			MessageBox.Show("File saved successfully");

		}




		private void btnsearchpricesPrinter_Click(object sender, EventArgs e)
		{
			try
			{
				switch (cbTypeprinter.SelectedIndex)
				{
					case 0:
						Workcenter workcenter = new Workcenter();
						txtsaleprice.Text = workcenter.SalePrice.ToString();
						txtrentprice.Text = workcenter.RentPrice.ToString();
						break;
					case 1:
						Phaser phaser = new Phaser();
						txtsaleprice.Text = phaser.SalePrice.ToString();
						txtrentprice.Text = phaser.RentPrice.ToString();
						break;
					case 2:
						VersaLink versaLink = new VersaLink();
						txtsaleprice.Text = versaLink.SalePrice.ToString();
						txtrentprice.Text = versaLink.RentPrice.ToString();
						break;
					default:
						MessageBox.Show("Please select a printer");
						break;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

	}
}
