using Microsoft.VisualBasic.FileIO;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace App_PrintAdministrator
{
	public partial class FrmSalePrints : Form
	{
		TypePaper[] paper;
		Sales[,] sales;
		int currentindex;
		decimal searchprice;
		int currentRowIndex;
		public FrmSalePrints()
		{
			InitializeComponent();
			dgvSalePrint.Columns.Add("Size", "Size");
			dgvSalePrint.Columns.Add("Name", "Name");
			dgvSalePrint.Columns.Add("SalesOptions", "SalesOptions");
			dgvSalePrint.Columns.Add("Price", "Price");
			dgvSalePrint.Columns.Add("Quantity", "Quantity");
			dgvSalePrint.Columns.Add("Total", "Total");
			dgvSalePrint.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvSalePrint.ReadOnly = true;
			paper = new TypePaper[20];
			sales = new Sales[15, 2];
			currentindex = 0;
			searchprice = 0;
			currentRowIndex = 0;
		}
		private void btnAddsales_Click(object sender, EventArgs e)
		{
			try
			{

				Sales newSale = new Sales();
				newSale.Size = cbsize.Text;
				newSale.AvailablePaperSales = cbAvailablepaper.Text;
				newSale.Salesoptions = cbSalesOptions.Text;
				newSale.PriceSale = Convert.ToDecimal(txtPricesales.Text);
				newSale.Numberprints = Convert.ToInt32(txtNumberPrints.Text);

				if (currentindex >= sales.Length)
				{
					MessageBox.Show("No more sales can be added.");
					return;
				}
				sales[currentRowIndex, 0] = newSale;
				dgvSalePrint.Rows.Add(newSale.Size, newSale.AvailablePaperSales, newSale.Salesoptions, newSale.PriceSale, newSale.Numberprints, newSale.Calculates_totalsale());
				currentRowIndex++;

				decimal totalVentas = (AddTotalsSales(sales));
				txtSubtotal.Text = totalVentas.ToString("F2" );
				CalculateIVA(totalVentas, txtIVA);
				decimal totalWithIva = totalVentas * 1.16m;
				txtTotal.Text = totalWithIva.ToString("F2");
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
		private void btnsearchAvailablepaper_Click(object sender, EventArgs e)
		{
			cbAvailablepaper.Items.Clear();
			for (int i = 0; i < currentindex; i++)
			{
				if (paper[i].Size == cbsize.Text)
				{
					cbAvailablepaper.Items.Add(paper[i].Name);

				}
			}
		}
		private void btnpricepaper_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < currentindex; i++)
			{
				if (paper[i].Name == cbAvailablepaper.Text)
				{
					switch (cbSalesOptions.Text)
					{
						case "Pricepacket":
							searchprice = paper[i].Pricepacket;
							break;
						case "Priceprint":
							searchprice = paper[i].Priceprint;
							break;
						case "WhitesheetPrice":
							searchprice = paper[i].WhitesheetPrice;
							break;
					}
					break;
				}

			}
			txtPricesales.Text = searchprice.ToString();
		}

		private void btnExporttxtpaper_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFile = new OpenFileDialog();
			openFile.Filter = "Text files (*.txt)|*.txt";
			openFile.Title = "Open file";
			if (openFile.ShowDialog() != DialogResult.OK)
			{
				MessageBox.Show("No file selected");
				return;
			}
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
			}
		}


		private void btnclearcontrols_Click(object sender, EventArgs e)
		{
			cbsize.Text = "";
			cbAvailablepaper.Text = "";
			cbSalesOptions.Text = "";
			txtPricesales.Text = "";
			txtNumberPrints.Text = "";
		}
		public static decimal AddTotalsSales(Sales[,] allSales)
		{
			decimal totalVentas = 0;
			for (int i = 0; i < allSales.GetLength(0); i++)
			{
				for (int j = 0; j < allSales.GetLength(1); j++)
				{
					if (allSales[i, j] != null)
					{
						totalVentas += allSales[i, j].Calculates_totalsale();
					}
				}
			}
			return totalVentas;
		}

		public static void CalculateIVA(decimal totalventas, TextBox txtIVA)
		{
			decimal iva = totalventas * 0.16m;
			txtIVA.Text = iva.ToString("F2");
		}

		private void btncalculate_Click(object sender, EventArgs e)
		{
		
			if (Convert.ToDecimal(txtPayment.Text) < Convert.ToDecimal(txtTotal.Text))
			{
				MessageBox.Show("The payment must be greater than the total");
				return;
			}

			txtChange.Text = (Convert.ToDecimal(txtPayment.Text) - Convert.ToDecimal(txtTotal.Text)).ToString();

		}

		private void btncancel_purchase_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < sales.GetLength(0); i++)
			{
				for (int j = 0; j < sales.GetLength(1); j++)
				{
					sales[i, j] = null;
				}
			}
			dgvSalePrint.Rows.Clear();
			txtSubtotal.Text = "";
			txtIVA.Text = "";
			txtTotal.Text = "";
			txtPayment.Text = "";
			txtChange.Text = "";
		}

		private void btnExportpdfXML_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFile = new SaveFileDialog();
			saveFile.Filter = "XML files (*.xml)|*.xml";
			saveFile.Title = "Save file";

			if (saveFile.ShowDialog() != DialogResult.OK)
			{
				MessageBox.Show("No file selected");
				return;
			}

			try
			{
				using (XmlWriter xmlWriter = XmlWriter.Create(saveFile.FileName))
				{
					xmlWriter.WriteStartDocument();
					xmlWriter.WriteStartElement("Sales");

					for (int i = 0; i < sales.GetLength(0); i++)
					{
						for (int j = 0; j < sales.GetLength(1); j++)
						{
							if (sales[i, j] != null)
							{
								xmlWriter.WriteStartElement("Sale");
								xmlWriter.WriteElementString("Size", sales[i, j].Size);
								xmlWriter.WriteElementString("AvailablePaperSales", sales[i, j].AvailablePaperSales);
								xmlWriter.WriteElementString("SalesOptions", sales[i, j].Salesoptions);
								xmlWriter.WriteElementString("Price", sales[i, j].PriceSale.ToString("F2"));
								xmlWriter.WriteElementString("Quantity", sales[i, j].Numberprints.ToString());
								xmlWriter.WriteElementString("Total", sales[i, j].Calculates_totalsale().ToString("F2"));
								xmlWriter.WriteEndElement();
							}
						}
					}

					xmlWriter.WriteEndElement();
					xmlWriter.WriteEndDocument();
				}

				MessageBox.Show("File saved successfully!");
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred while saving the file: " + ex.Message);
			}
		}

		private void btnexportsalesexcel_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFile = new SaveFileDialog();
			saveFile.Filter = "Excel files (*.xlsx)|*.xlsx";
			saveFile.Title = "Save file";
			if (saveFile.ShowDialog() != DialogResult.OK)
			{
				MessageBox.Show("No file selected");
				return;
			}

			string filePath = saveFile.FileName;

			using (ExcelPackage package = new ExcelPackage())
			{
				ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sales Report");

				worksheet.Cells[1, 1].Value = "Size";
				worksheet.Cells[1, 2].Value = "Available Paper";
				worksheet.Cells[1, 3].Value = "Sales Option";
				worksheet.Cells[1, 4].Value = "Price Sale";
				worksheet.Cells[1, 5].Value = "Number of Prints";
				worksheet.Cells[1, 6].Value = "Total Sale";

				using (var range = worksheet.Cells[1, 1, 1, 6])
				{
					range.Style.Font.Bold = true;
					range.Style.Fill.PatternType = ExcelFillStyle.Solid;
					range.Style.Fill.BackgroundColor.SetColor(Color.LightGray);
					range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
				}

				int currentRow = 2;
				for (int i = 0; i < sales.GetLength(0); i++)
				{
					for (int j = 0; j < sales.GetLength(1); j++)
					{
						if (sales[i, j] != null)
						{
							worksheet.Cells[currentRow, 1].Value = sales[i,j].Size;
							worksheet.Cells[currentRow, 2].Value = sales[i,j].AvailablePaperSales;
							worksheet.Cells[currentRow, 3].Value = sales[i,j].Salesoptions;
							worksheet.Cells[currentRow, 4].Value = sales[i,j].PriceSale;
							worksheet.Cells[currentRow, 5].Value = sales[i,j].Numberprints;
							worksheet.Cells[currentRow, 6].Value = sales[i,j].Calculates_totalsale();
								currentRow++;
						}
					}
				}

				worksheet.Cells[currentRow, 5].Value = "Subtotal";
				worksheet.Cells[currentRow, 6].Value = Convert.ToDecimal(txtSubtotal.Text);
				currentRow++;
				worksheet.Cells[currentRow, 5].Value = "IVA";
				worksheet.Cells[currentRow, 6].Value = Convert.ToDecimal(txtIVA.Text);
				currentRow++;
				worksheet.Cells[currentRow, 5].Value = "Total";
				worksheet.Cells[currentRow, 6].Value = Convert.ToDecimal(txtTotal.Text);
				currentRow++;

				worksheet.Cells[2, 4, currentRow, 6].Style.Numberformat.Format = "#,##0.00";

				worksheet.Cells.AutoFitColumns();

				FileInfo fileInfo = new FileInfo(filePath);
				package.SaveAs(fileInfo);
			}

			MessageBox.Show("File saved successfully!");
		}
	}
}
