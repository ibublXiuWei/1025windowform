namespace am4
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.form2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.form3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.維護會員ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.檢視會員ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.新增會員ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form2ToolStripMenuItem,
            this.form3ToolStripMenuItem,
            this.維護會員ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// form2ToolStripMenuItem
			// 
			this.form2ToolStripMenuItem.Name = "form2ToolStripMenuItem";
			this.form2ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.form2ToolStripMenuItem.Text = "Form2";
			this.form2ToolStripMenuItem.Click += new System.EventHandler(this.form2ToolStripMenuItem_Click);
			// 
			// form3ToolStripMenuItem
			// 
			this.form3ToolStripMenuItem.Name = "form3ToolStripMenuItem";
			this.form3ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.form3ToolStripMenuItem.Text = "Form3";
			this.form3ToolStripMenuItem.Click += new System.EventHandler(this.form3ToolStripMenuItem_Click);
			// 
			// 維護會員ToolStripMenuItem
			// 
			this.維護會員ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檢視會員ToolStripMenuItem,
            this.新增會員ToolStripMenuItem});
			this.維護會員ToolStripMenuItem.Name = "維護會員ToolStripMenuItem";
			this.維護會員ToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
			this.維護會員ToolStripMenuItem.Text = "維護會員(&M)";
			// 
			// 檢視會員ToolStripMenuItem
			// 
			this.檢視會員ToolStripMenuItem.Name = "檢視會員ToolStripMenuItem";
			this.檢視會員ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.檢視會員ToolStripMenuItem.Text = "檢視會員";
			// 
			// 新增會員ToolStripMenuItem
			// 
			this.新增會員ToolStripMenuItem.Name = "新增會員ToolStripMenuItem";
			this.新增會員ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.新增會員ToolStripMenuItem.Text = "新增會員";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem form2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem form3ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 維護會員ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 檢視會員ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 新增會員ToolStripMenuItem;
	}
}

