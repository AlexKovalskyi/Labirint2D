using Labirint2DWPF.View.Levels;
using Labirint2DWPF.ViewModel;
using System.Windows;

namespace Labirint2DWPF.Commands
{
	public class CrossBorder : CommandBase
	{
		public override void Execute(object parameters)
		{
			Sound.play_fail();
			var response = MessageBox.Show("You failed mission. Try again?", "Message", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
			if (Levels.windows[Levels.numberOfLevel] is WindowLvl1)
			{
				if (response == MessageBoxResult.Yes)
				{
					Levels.lvl1.Show();
					Point point = Levels.lvl1.btnStart.TransformToAncestor(Levels.lvl1).Transform(new Point(0, 0));
					point = Levels.lvl1.btnStart.PointToScreen(point);
					PointControll.SetCursor((int)point.X, (int)point.Y);
				}
				else
				{
					Application.Current.Shutdown();
				}
			}
			else if (Levels.windows[Levels.numberOfLevel] is WindowLvl2)
			{
				if (response == MessageBoxResult.Yes)
				{
					Levels.lvl2.Show();
					Levels.lvl2.btnkey.Visibility = Visibility.Visible;
					Levels.lvl2.btndor.Visibility = Visibility.Visible;
					Point point = Levels.lvl2.btnStart.TransformToAncestor(Levels.lvl2).Transform(new Point(0, 0));
					point = Levels.lvl2.btnStart.PointToScreen(point);
					PointControll.SetCursor((int)point.X, (int)point.Y);
				}
				else
				{
					Application.Current.Shutdown();
				}
			}
		}
	}
}
