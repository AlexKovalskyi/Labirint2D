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
		public FormLevel1()
		{
			InitializeComponent();
		}

		private void start_game()
		{
			Point point;
			point = label_start.Location;
			point.Offset(label_start.Width / 2, label_start.Height / 2);
			Cursor.Position = PointToScreen(point);
			Sound.play_start();
		}

		private void FormLevel1_Shown(object sender, EventArgs e)
		{
			start_game();
		}

		private void label_finish_MouseEnter(object sender, EventArgs e)
		{
			DialogResult = System.Windows.Forms.DialogResult.OK;
		}
	}
}
