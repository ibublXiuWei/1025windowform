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
	public partial class LoginForm2 : System.Windows.Forms.Form
	{
		public LoginForm2()
		{
			InitializeComponent();
		}

		private void loginbutton_Click(object sender, EventArgs e)
		{
			//to do 確認密碼是否正確

			//開啟Form1
			Form1 frm = new Form1();
			frm.Owner = this;
			frm.Show();

			//隱藏式窗this是這個Method 隱藏自己，不可以關閉自己
			this.Hide();
		}
	}
}
