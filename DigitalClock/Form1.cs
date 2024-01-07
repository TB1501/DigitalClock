using System.Globalization;

namespace DigitalClock
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			lblTime.Visible = false;
			lblDate.Visible = false;


			lblTime.Anchor = AnchorStyles.None;
			lblTime.TextAlign = ContentAlignment.MiddleCenter;
			lblTime.BackColor = Color.Transparent;

			lblDate.Anchor = AnchorStyles.None;
			lblDate.TextAlign = ContentAlignment.MiddleCenter;
			lblDate.BackColor = Color.Transparent;

			panelhr1.Visible = false;
			panelusa1.Visible = false;
			paneluk1.Visible = false;
			panelde1.Visible = false;

		}



		private void dateTimeHR_Click(object sender, EventArgs e)
		{
			panelhr1.Show();
			panelhr1.BringToFront();
			panelusa1.Hide();
			paneluk1.Hide();
			panelde1.Hide();


			lblDate.Show();
			lblTime.Show();
			lblDate.BringToFront();
			lblTime.BringToFront();

			timer1.Start();


		}

		private void dateTimeUSA_Click(object sender, EventArgs e)
		{
			panelusa1.Show();
			panelusa1.BringToFront();
			panelhr1.Hide();
			paneluk1.Hide();
			panelde1.Hide();

			lblDate.Show();
			lblTime.Show();
			lblDate.BringToFront();
			lblTime.BringToFront();

			timer1.Start();

		}

		private void dateTimeUK_Click(object sender, EventArgs e)
		{
			paneluk1.Show();
			paneluk1.BringToFront();
			panelhr1.Hide();
			panelusa1.Hide();
			panelde1.Hide();

			lblDate.Show();
			lblTime.Show();
			lblDate.BringToFront();
			lblTime.BringToFront();

			timer1.Start();
		}

		private void dateTimeDE_Click(object sender, EventArgs e)
		{
			panelde1.Show();
			panelde1.BringToFront();
			panelhr1.Hide();
			panelusa1.Hide();
			paneluk1.Hide();

			lblDate.Show();
			lblTime.Show();
			lblDate.BringToFront();
			lblTime.BringToFront();

			timer1.Start();
		}

		private void lblDate_Click(object sender, EventArgs e)
		{



			timer1.Start();




		}
		private void lblTime_Click(object sender, EventArgs e)
		{
			timer1.Start();




		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (panelhr1.Visible)
			{
				lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
				lblDate.Text = DateTime.Now.ToString("dd.MM.yyyy.");

			}
			else if (panelusa1.Visible)
			{
				lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
				lblDate.Text = DateTime.Now.ToString("MMMM/dd/yyyy", CultureInfo.InvariantCulture);

			}
			else if (paneluk1.Visible)
			{
				lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
				lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

			}
			else if (panelde1.Visible)
			{
				lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
				lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd");

			}


		}

	}
}