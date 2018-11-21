using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonFool_Click(object sender, EventArgs e)
		{
			buttonExit.Visible = true;
			buttonRetry.Visible = true;
			buttonFool.Visible = false;
			buttonNotFool.Visible = false;
			labelShow.Text = "You Are Fool";
			labelShow.Visible = true;
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void buttonRetry_Click(object sender, EventArgs e)
		{
			buttonExit.Visible = false;
			buttonRetry.Visible = false;
			buttonFool.Visible = true;
			buttonNotFool.Visible = true;
			labelShow.Visible = false;
			buttonNotFool.Location = new Point(489,115);
		}

		private void buttonNotFoolEnter(object sender, EventArgs e)
		{
			Random rnd = new Random();
			buttonNotFool.Location = new Point(rnd.Next(90, 600), rnd.Next(90, 280));
		}

		private void buttonNotFool_Click(object sender, EventArgs e)
		{
			buttonExit.Visible = true;
			buttonRetry.Visible = true;
			buttonFool.Visible = false;
			buttonNotFool.Visible = false;
			labelShow.Text = "You Are Not Fool";
			labelShow.Visible = true;
		}
	}
}
