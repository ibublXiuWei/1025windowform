using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace am2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void drawbutton_Click(object sender, EventArgs e)
		{
			Lottery lottery = new Lottery();
			int[] numbers = lottery.Draw(49, 6);
			Array.Sort(numbers);
			string msg = string.Join(",", numbers);
			label1.Text = msg;

		}
		public class Lottery
		{/// <summary>
		/// 從N個術中取出不重複的職
		/// </summary>
		/// <param name="number">1~number是取亂數</param>
		/// <param name="drawnumber">要取出幾個不重複的職</param>
		/// <returns>回傳陣列內涵不重複的職</returns>
			public int[] Draw(int number, int drawnumber)
			{
				
				return new int[]{1, 33, 24, 42, 3};
			}

		}
	}
}
