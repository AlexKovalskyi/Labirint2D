using Labirint2DWPF.View.Levels;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Windows;
using Labirint2DWPF.View;

namespace Labirint2DWPF.Commands
{
	public class StartCommand : CommandBase
	{
		private Window window;

		public StartCommand(Window window)
		{
			this.window = window;
		}

		public override void Execute(object parameters)
		{
			if (window is WindowLvl1)
			{
				WindowLvl1 lvl1 = (WindowLvl1)window;
				lvl1.Show();
				Point point = lvl1.btnStart.TransformToAncestor(lvl1).Transform(new Point(0, 0));
				point = lvl1.btnStart.PointToScreen(point);
				SetCursor((int)point.X, (int)point.Y);
			}
			else if(window is WindowLvl2)
			{
				//WindowLvl2 lvl2 = (WindowLvl2)window;
				//lvl2.Show();
				//Point point = lvl2.btnStart.TransformToAncestor(lvl2).Transform(new Point(0, 0));
				//point = lvl2.btnStart.PointToScreen(point);
				//SetCursor((int)point.X, (int)point.Y);
			}
			
		}
		[DllImport("User32.dll")]
		private static extern bool SetCursorPos(int x, int y);
		public static void SetCursor(int x, int y)
		{
			SetCursorPos(x,y);
		}
	}
}
