/*
 * Created by SharpDevelop.
 * User: Joey Pence
 * Date: 6/17/2015
 * Time: 9:24 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SaichanSafety
{
	/// <summary>
	/// Description of about.
	/// </summary>
	public partial class about : Form
	{
		public about()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
