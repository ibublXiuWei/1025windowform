using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AM6
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void resultbutton_Click(object sender, EventArgs e)
		{
			int firstNumber, secondNumber;
			try//取第一個直
			{
				firstNumber=GetFirstnumber();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			//取締二個職
			try
			{
				secondNumber=GetSecondnumber();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return ;
			}

			string operation;
			try
			{
				operation = Getoperation();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			int result;
			try
			{
				result = Calc(firstNumber, secondNumber, operation);
				resultlabel.Text = result.ToString();
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
		}

		private int Calc(int firstNumber, int secondNumber, string operation)
		{
			switch(operation)
			{
				case "+":
					return firstNumber + secondNumber;
				case "-":
					return firstNumber - secondNumber;
				case "*":
					return firstNumber * secondNumber;
				case "/":
					return secondNumber==0 ? throw new Exception("" ):firstNumber / secondNumber;
			}
			throw new Exception($"不支援此計算方式{operation}");
		}

		private string Getoperation()
		{
			ComboBox control = this.optionCbobox;
			object selectedItem=control.SelectedItem;

			return selectedItem != null ? selectedItem.ToString() : throw new Exception("請選擇計算方式");
		}

		private int GetSecondnumber()
		{
			TextBox txt = secondnumberTextBox;
			string title = "第二個數字";
			return GetInt(txt, title);
		}

		private int GetFirstnumber()
		{
			TextBox txt = firstnumbertextBox;
			string title = "第一個數字";
			return GetInt(txt, title);
		}
		private int GetInt(TextBox control,string title)
		{   
			string value= control.Text;
			bool isInt = int.TryParse(value, out int number);
			return isInt ? number : throw new Exception($"{title}必須填數值");
		}
	}
}
