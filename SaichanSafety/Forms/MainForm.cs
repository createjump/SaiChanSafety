﻿/*
 * Created by SharpDevelop.
 * User: 1062389
 * Date: 5/15/2015
 * Time: 1:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SaichanSafety
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		    
		}
		void NewAutoArmFileToolStripMenuItemClick(object sender, EventArgs e)
		{
			
			
		}
		void AboutSaichanToolStripMenuItemClick(object sender, EventArgs e)
		{
	   // //TODO: impliment about box (noep)
	    about Form1 = new about(); Form1.ShowDialog();
		}
		
	}
}
