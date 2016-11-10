using Labirint2DWPF.Commands;
using System.Windows;
using System.Windows.Input;

namespace Labirint2DWPF.ViewModel
{
	public class Lvl2ViewModel : MainViewModelBase
	{
		public ICommand LevelFinished
		{
			get
			{
				return new LvlFinishedCommand();
			}
		}

		public ICommand CrossBorder
		{
			get
			{
				return new CrossBorder();
			}
		}
		public ICommand GetKey
		{
			get
			{
				return new GetKeyCommand();
			}
		}
	}
}
