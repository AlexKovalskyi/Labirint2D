using System.Windows;
using Labirint2DWPF.ViewModel;

namespace Labirint2DWPF.Commands
{
	public class StartCommand : CommandBase
	{
		public override void Execute(object parameters)
		{
			Levels.lvl1.Show();
			Sound.play_start();
			Point point = Levels.lvl1.btnStart.TransformToAncestor(Levels.lvl1).Transform(new Point(0, 0));
			point = Levels.lvl1.btnStart.PointToScreen(point);
			PointControll.SetCursor((int)point.X, (int)point.Y);
		}

	}
}
