using System.Media;

namespace Labirint2DWPF
{
	static class Sound
	{
		static SoundPlayer soundFail = new SoundPlayer(Properties.Resources.sound_fail);
		static SoundPlayer soundKey = new SoundPlayer(Properties.Resources.sound_key);
		static SoundPlayer soundStart = new SoundPlayer(Properties.Resources.sound_start);
		static SoundPlayer soundYouWin = new SoundPlayer(Properties.Resources.sound_youwin);
		static bool soundEnabled;

		public static void soundOn()
		{
			soundEnabled = true;
		}
		public static void soundOff()
		{
			soundEnabled = false;
		}

		public static void play_fail()
		{
			if (soundEnabled)
				soundFail.Play();
		}
		public static void play_key()
		{
			if (soundEnabled)
				soundKey.Play();
		}
		public static void play_start()
		{
			if (soundEnabled)
				soundStart.Play();
		}
		public static void play_youwin()
		{
			if (soundEnabled)
				soundYouWin.Play();
		}
	}
}
