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
	public partial class FormMenu : Form
	{
		public FormMenu()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button_start_Click(object sender, EventArgs e)
		{
			StartLevel1();
		}

		private void box_sound_CheckedChanged(object sender, EventArgs e)
		{
			if (box_sound.Checked)
			{
				Sound.sound_on();
				box_sound.Text = "Sound ON";
				Sound.play_key();
			}
			else
			{
				Sound.sound_of();
				box_sound.Text = "Sound OFF";
			}
		}

		private void button_exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void StartLevel1()
		{
			FormLevel1 level1 = new FormLevel1();
			DialogResult dr = level1.ShowDialog();
			if (dr == DialogResult.OK)
			{
				StartLevel2();
			}
		}
		private void StartLevel2()
		{
			FormLevel2 level2 = new FormLevel2();
			DialogResult dr = level2.ShowDialog();
			if (dr == DialogResult.OK)
			{
				StartYouWin();
			}
		}

		private void StartYouWin()
		{
			Sound.play_youwin();
			MessageBox.Show("You finished the game.");
		}
	}
}
