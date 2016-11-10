using System;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Labirint2DWPF.View.Levels
{
	/// <summary>
	/// Interaction logic for WindowLvl2.xaml
	/// </summary>
	public partial class WindowLvl2 : Window
	{
		public WindowLvl2()
		{
			InitializeComponent();

			var bitmapSource = Imaging.CreateBitmapSourceFromHBitmap(Properties.Resources.key.GetHbitmap(), IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
			btnkey.Background = new ImageBrush(bitmapSource);
		}
	}
}
