using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Labirint2DWPF.View;
using Labirint2DWPF.ViewModel;
using System.Windows.Input;
using Labirint2DWPF.View.Levels;

namespace Labirint2DWPF.Commands
{
	public class LvlFinishedCommand : CommandBase
	{
		public override void Execute(object parameters)
		{
			var response = MessageBox.Show($"Level  Finished! Do you want to continue?", "Victory!!", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
			if (response == MessageBoxResult.Yes)
			{
				Levels.numberOfLevel += 1;
				WindowLvl2 lvl2 = (WindowLvl2)Levels.windows[Levels.numberOfLevel];
				lvl2.Show();
				//Point point = lvl2.btnStart.TransformToAncestor(lvl2).Transform(new Point(0, 0));
				//point = lvl2.btnStart.PointToScreen(point);
				//SetCursor((int)point.X, (int)point.Y);
			}
			else
			{
				Application.Current.Shutdown();
			}
		}
	}
}
