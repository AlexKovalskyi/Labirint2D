using Labirint2DWPF.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Labirint2DWPF.ViewModel
{
	public class Lvl1ViewModel : MainViewModelBase
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
	}
}
