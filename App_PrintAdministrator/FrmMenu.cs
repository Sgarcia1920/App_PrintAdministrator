using System.Data;
using System.Reflection.Metadata;

namespace App_PrintAdministrator
{
	public partial class FrmMenu : Form
	{
		public FrmMenu()
		{
			InitializeComponent();
		}

		private void btnSales_print_Click(object sender, EventArgs e)
		{
			
			if (Application.OpenForms.OfType<FrmSalePrints>().Count() == 0)
			{
				FrmSalePrints salePrints = new FrmSalePrints();
				salePrints.Show();
			}
		}
		private void btnPrinter_registration_Click(object sender, EventArgs e)
		{
			if (Application.OpenForms.OfType<FrmPrinterRegistration>().Count() == 0)
			{
				FrmPrinterRegistration printerRegistration = new FrmPrinterRegistration();
				printerRegistration.Show();
			}
		}
		private void btnPaper_register_Click(object sender, EventArgs e)
		{
			if (Application.OpenForms.OfType<FrmPaperRegister>().Count() == 0)
			{
				FrmPaperRegister paperRegister = new FrmPaperRegister();
				paperRegister.Show();
			}
		}

		private void btn_notes_Click(object sender, EventArgs e)
		{
			if (Application.OpenForms.OfType<FrmNotes>().Count() == 0)
			{
				FrmNotes notes = new FrmNotes();
				notes.Show();
			}
		}

	


	}
}
