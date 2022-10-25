using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace am3
{
	public partial class Form1 : System.Windows.Forms.Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Owner.Show();
		}
	}
}
