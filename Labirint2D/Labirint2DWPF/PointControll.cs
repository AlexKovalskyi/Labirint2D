using System.Runtime.InteropServices;

namespace Labirint2DWPF
{
	static class PointControll
	{
		[DllImport("User32.dll")]
		private static extern bool SetCursorPos(int x, int y);
		public static void SetCursor(int x, int y)
		{
			SetCursorPos(x, y);
		}
	}
}
