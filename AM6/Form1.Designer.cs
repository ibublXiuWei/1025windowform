namespace AM6
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.resultbutton = new System.Windows.Forms.Button();
			this.optionCbobox = new System.Windows.Forms.ComboBox();
			this.firstnumbertextBox = new System.Windows.Forms.TextBox();
			this.secondnumberTextBox = new System.Windows.Forms.TextBox();
			this.resultlabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// resultbutton
			// 
			this.resultbutton.Location = new System.Drawing.Point(493, 82);
			this.resultbutton.Name = "resultbutton";
			this.resultbutton.Size = new System.Drawing.Size(75, 23);
			this.resultbutton.TabIndex = 0;
			this.resultbutton.Text = "計算";
			this.resultbutton.UseVisualStyleBackColor = true;
			this.resultbutton.Click += new System.EventHandler(this.resultbutton_Click);
			// 
			// optionCbobox
			// 
			this.optionCbobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.optionCbobox.FormattingEnabled = true;
			this.optionCbobox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
			this.optionCbobox.Location = new System.Drawing.Point(210, 84);
			this.optionCbobox.Name = "optionCbobox";
			this.optionCbobox.Size = new System.Drawing.Size(121, 20);
			this.optionCbobox.TabIndex = 1;
			// 
			// firstnumbertextBox
			// 
			this.firstnumbertextBox.Location = new System.Drawing.Point(87, 83);
			this.firstnumbertextBox.Name = "firstnumbertextBox";
			this.firstnumbertextBox.Size = new System.Drawing.Size(100, 22);
			this.firstnumbertextBox.TabIndex = 2;
			// 
			// secondnumberTextBox
			// 
			this.secondnumberTextBox.Location = new System.Drawing.Point(354, 83);
			this.secondnumberTextBox.Name = "secondnumberTextBox";
			this.secondnumberTextBox.Size = new System.Drawing.Size(100, 22);
			this.secondnumberTextBox.TabIndex = 2;
			// 
			// resultlabel
			// 
			this.resultlabel.AutoSize = true;
			this.resultlabel.Location = new System.Drawing.Point(516, 127);
			this.resultlabel.Name = "resultlabel";
			this.resultlabel.Size = new System.Drawing.Size(33, 12);
			this.resultlabel.TabIndex = 3;
			this.resultlabel.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.resultlabel);
			this.Controls.Add(this.secondnumberTextBox);
			this.Controls.Add(this.firstnumbertextBox);
			this.Controls.Add(this.optionCbobox);
			this.Controls.Add(this.resultbutton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button resultbutton;
		private System.Windows.Forms.ComboBox optionCbobox;
		private System.Windows.Forms.TextBox firstnumbertextBox;
		private System.Windows.Forms.TextBox secondnumberTextBox;
		private System.Windows.Forms.Label resultlabel;
	}
}

