using System.Windows;
using Labirint2DWPF.ViewModel;
using Labirint2DWPF.View.Levels;

namespace Labirint2DWPF.Commands
{
	public class LvlFinishedCommand : CommandBase
	{
		public override void Execute(object parameters)
		{
			var response = MessageBox.Show($"Level  Finished! Do you want to continue?", "Victory!!", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
			if (Levels.windows[Levels.numberOfLevel] is WindowLvl1)
			{
				if (response == MessageBoxResult.Yes)
				{
					Levels.lvl1.Close();
					Levels.lvl2.Show();

					Sound.play_start();
					Point point = Levels.lvl2.btnStart.TransformToAncestor(Levels.lvl2).Transform(new Point(0, 0));
					point = Levels.lvl2.btnStart.PointToScreen(point);
					PointControll.SetCursor((int)point.X, (int)point.Y);
					Levels.numberOfLevel += 1;
				}
				else
				{
					Application.Current.Shutdown();
				}
			}
			else if(Levels.windows[Levels.numberOfLevel] is WindowLvl2)
			{
				Sound.play_youwin();
				if (response == MessageBoxResult.Yes)
				{
					MessageBox.Show($"Level {Levels.numberOfLevel +1} Finished! You Finished the game!  GOOD LUCK!!", "Victory!!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
					if (response == MessageBoxResult.OK)
					{
						Application.Current.Shutdown();
					}
					else
					{
						Application.Current.Shutdown();
					}

				}
				else
				{
					Application.Current.Shutdown();
				}
			}
		}
	}
}
