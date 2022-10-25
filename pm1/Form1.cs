using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pm1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			comboBox1.SelectedIndex=0; // 預設為起始值
		}

		private void calcbutton_Click(object sender, EventArgs e)
		{
			//取得被選取的值
			int firstNumber = Getfirstnumber();
			//生成單一乘法表
			string table = Rendersingletable(firstNumber);
			//呈現結果
			textBox1.Text = table;
		}

		private string Rendersingletable(int number)
		{
			string result=string.Empty;
			for (int i = 1; i <=9; i++)
			{
				result+=($"{number}*{ i}={number*i}\r\n");
			}
			return result;
		}

		private int Getfirstnumber()
		{
			return Convert.ToInt32(comboBox1.SelectedItem);//SelectedItem為系統值
		}
		//也可簡化為
		//private int Getfirstnumber()
		//=>Convert.ToInt32(comboBox1.SelectedItem);
		
	}
}
