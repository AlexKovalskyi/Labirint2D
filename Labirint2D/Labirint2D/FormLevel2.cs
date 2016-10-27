using System;
using System.Drawing;
using System.Windows.Forms;

namespace Labirint2D
{
	public partial class FormLevel2 : Form
	{
		public FormLevel2()
		{
			InitializeComponent();
		}

		private void startGame()
		{
			Point point;
			point = label_start.Location;
			point.Offset(label_start.Width / 2, label_start.Height / 2);
			Cursor.Position = PointToScreen(point);
			label_key.Visible = true;
			label_door.Visible = true;
			Sound.play_start();
			label_wal1.Visible = true;
			label_wal2.Visible = false;
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

		private void FormLevel2_Shown(object sender, EventArgs e)
		{
			startGame();
		}

		private void label1_MouseEnter(object sender, EventArgs e)
		{
			FinishGame();
		}

		private void label_key_MouseEnter(object sender, EventArgs e)
		{
			label_key.Visible = false;
			Sound.play_key();

		}

		private void label_door_MouseEnter(object sender, EventArgs e)
		{
			if (label_key.Visible)
			{
				FinishGame();
			}
			else
			{
				label_door.Visible = false;
				Sound.play_key();
			}
		}

		private void label_finish_MouseEnter(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			label_wal1.Visible = !label_wal1.Visible;
			label_wal2.Visible = !label_wal2.Visible;
		}
	}
}
