using Labirint2DWPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Labirint2DWPF.Commands
{
	public class CrossBorder : CommandBase
	{
		public override void Execute(object parameters)
		{
			var response = MessageBox.Show("You failed mission. Try again?", "Message", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
			if (response == MessageBoxResult.Yes)
			{
				Levels.windows[Levels.numberOfLevel].Show();
			}
			else
			{
				Application.Current.Shutdown();
			}
		}
	}
}
