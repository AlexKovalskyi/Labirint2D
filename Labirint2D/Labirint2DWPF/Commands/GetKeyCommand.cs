using Labirint2DWPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Labirint2DWPF.Commands
{
	public class GetKeyCommand : CommandBase
	{
		public override void Execute(object parameters)
		{
			Levels.lvl2.btnkey.Visibility = Visibility.Hidden;
			Levels.lvl2.btndor.Visibility = Visibility.Hidden;
		}
	}
}
