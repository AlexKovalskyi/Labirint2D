using System.Windows;

namespace Labirint2DWPF.Commands
{
	public class ExitCommand : CommandBase
	{
		public override void Execute(object parameters)
		{
			var response = MessageBox.Show("Do you really want to exit?", "Exiting...", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
			if (response == MessageBoxResult.Yes)
			{
				Application.Current.Shutdown();
			}
		}
	}
}
