using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp2
{
	public partial class PlayForm : Form
	{
		public int Score = 0;
		Random rnd = new Random();
		int count = 0;
		string playerN = "";
		PictureBox[] moleP;

		public PlayForm(string inputN)
		{
			InitializeComponent();
			playerN = inputN;

			HelloMessage();
			
			moleP = new PictureBox[] { PB_m1, PB_m2, PB_m3, PB_m4, PB_m5, PB_m6, PB_m7, PB_m8, PB_m9, PB_m10 };

			for (int i = 0; i < moleP.Length; i++)
			{
				moleP[i].Visible = false;
			}
		}
		private void HelloMessage()
		{
			L_showName.Text = "שלום" + playerN + "Score:" + Score;
		}
		private void L_showName_Click(object sender, EventArgs e)
		{

		}
		private void TMole_Tick(object sender, EventArgs e)
		{
			count++;
			if (count == 2)
			{
				for (int i = 0; i < moleP.Length; i++)
				{
					moleP[i].Visible = false;
				}
				int index = rnd.Next(0, moleP.Length);
				moleP[index].Visible = true;

				count = 0;
			}
		}

		private void moleHit(object sender, EventArgs e)
		{
			PictureBox clikedMole = (PictureBox)sender;
			if (clikedMole.Visible == true)
			{
				Score++;
				HelloMessage();
				clikedMole.Visible = false;
			}


		}
	}
}
