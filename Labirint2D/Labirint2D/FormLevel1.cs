using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint2D
{
	public partial class FormLevel1 : Form
	{
		int leftBoxes;
		public FormLevel1()
		{
			InitializeComponent();
		}

		private void startGame()
		{
			Point point;
			point = label_start.Location;
			point.Offset(label_start.Width / 2, label_start.Height / 2);
			Cursor.Position = PointToScreen(point);
			Sound.play_start();
			leftBoxes = 3;
			label_box1.Visible = true;
			label_box2.Visible = true;
			label_box3.Visible = true;
		}

		private void FinishGame()
		{
			Sound.play_fail();
			DialogResult dr = MessageBox.Show("You failed mission. Try again?", "Message", MessageBoxButtons.YesNo);
			if (dr == DialogResult.Yes)
			{
				startGame();
			}
			else
			{
				DialogResult = DialogResult.Abort;
			}
		}

		private void FormLevel1_Shown(object sender, EventArgs e)
		{
			startGame();
		}

		private void label_finish_MouseEnter(object sender, EventArgs e)
		{
			if(leftBoxes ==0)
			DialogResult = DialogResult.OK;
		}

		private void label3_MouseEnter(object sender, EventArgs e)
		{
			FinishGame();
		}

		private void label_box2_MouseEnter(object sender, EventArgs e)
		{
			Sound.play_key();
			leftBoxes--;
			((Label)sender).Visible = false;
		}
	}
}
