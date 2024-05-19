/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 5/19/2024
 * Time: 3:39 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace panelAnimation
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
		public int n=2;
		public List<Panel>pl = new List<Panel>();
		public void addPanel(int x, int y)
		{
			pl.Add(new Panel());
			int i = pl.Count-1;
			pl[i].Left =x ;
			pl[i].Top = y;
			pl[i].Width = 170;
			pl[i].Height = 170;
			pl[i].BorderStyle = BorderStyle.FixedSingle;
			pl[i].BackgroundImage = Image.FromFile("c.jpg");
			pl[i].BackgroundImageLayout = ImageLayout.Stretch;
		}
		public void addPanelsToForm()
		{
			for(int i = 0 ; i < pl.Count ; i++)
			{
				this.Controls.Add(pl[i]);
				this.Controls[i+n].BackColor = Color.White;
			}
		}
		public void movePanelsUpOnForm()
		{
			for(int i = 0 ; i < pl.Count ; i++)
			{
				this.Controls[i+n].Top -=10;
			}
		}
		public void movePanelsDownOnForm()
		{
			for(int i = 0 ; i < pl.Count ; i++)
			{
				this.Controls[i+n].Top +=10;
			}
		}
		
		public void movePanelsLeftOnForm()
		{
			for(int i = 0 ; i < pl.Count ; i++)
			{
				this.Controls[i+n].Left -=10;
			}
		}
		public void movePanelsRightOnForm()
		{
			for(int i = 0 ; i < pl.Count ; i++)
			{
				this.Controls[i+n].Left +=10;
			}
		}
		
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			n = this.Controls.Count;
			for(int j = 0 ; j < 8 ; j++)
			{
				for(int i = 0 ; i < 2 ; i++)
				{
					addPanel(150+(j*160),150+(i*160));
				}
			}
			addPanelsToForm();
		}
		void Button1Click(object sender, EventArgs e)
		{
			movePanelsUpOnForm();
		}
		void Button2Click(object sender, EventArgs e)
		{
			movePanelsDownOnForm();
		}
		void Button4Click(object sender, EventArgs e)
		{
			movePanelsLeftOnForm();
		}
		void Button3Click(object sender, EventArgs e)
		{
			movePanelsRightOnForm();
		}
		
	}
}
