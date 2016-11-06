using Labirint2DWPF.View.Levels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Labirint2DWPF.ViewModel
{
	static class Levels
	{
		public static List<Window> windows = new List<Window> { new WindowLvl1(), new WindowLvl2() };
		public static int numberOfLevel = 0;
		public static WindowLvl1 lvl1 = new WindowLvl1();
		public static WindowLvl2 lvl2 = new WindowLvl2();

	}
}
