/*
 * Created by SharpDevelop.
 * User: USER
 * Date: 02/03/2022
 * Time: 15.24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tugas4
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
	
		
		void Button1Click(object sender, EventArgs e)
		{
			MessageBox.Show ("Nama : " + this.textBox1.Text + "\nNIM : " + this.textBox2.Text + "\nKelas : " + this.textBox3.Text + "\nMata Kuliah : " + this.textBox4.Text,"Data");
		}
	}
}
