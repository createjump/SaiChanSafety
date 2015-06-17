/*
 * Created by SharpDevelop.
 * User: 1062389
 * Date: 5/15/2015
 * Time: 1:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SaichanSafety
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newAutoArmFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadAutoArmToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutSaichanToolStripMenuItem;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.button1 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newAutoArmFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadAutoArmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutSaichanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.ForeColor = System.Drawing.Color.Red;
			this.button1.Location = new System.Drawing.Point(420, 30);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(62, 20);
			this.button1.TabIndex = 0;
			this.button1.Text = "Arm!";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fileToolStripMenuItem,
			this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(495, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.newAutoArmFileToolStripMenuItem,
			this.loadAutoArmToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newAutoArmFileToolStripMenuItem
			// 
			this.newAutoArmFileToolStripMenuItem.Name = "newAutoArmFileToolStripMenuItem";
			this.newAutoArmFileToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.newAutoArmFileToolStripMenuItem.Text = "New AutoArm";
			this.newAutoArmFileToolStripMenuItem.Click += new System.EventHandler(this.NewAutoArmFileToolStripMenuItemClick);
			// 
			// loadAutoArmToolStripMenuItem
			// 
			this.loadAutoArmToolStripMenuItem.Name = "loadAutoArmToolStripMenuItem";
			this.loadAutoArmToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.loadAutoArmToolStripMenuItem.Text = "Load AutoArm ";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.aboutSaichanToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutSaichanToolStripMenuItem
			// 
			this.aboutSaichanToolStripMenuItem.Name = "aboutSaichanToolStripMenuItem";
			this.aboutSaichanToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.aboutSaichanToolStripMenuItem.Text = "About Saichan";
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(153, 25);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(104, 24);
			this.radioButton1.TabIndex = 2;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "radioButton1";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(495, 123);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.menuStrip1);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "SaichanSafety";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
