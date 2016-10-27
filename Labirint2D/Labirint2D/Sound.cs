using System.Media;

namespace Labirint2D
{
	static class Sound
	{
		static SoundPlayer sound_fail = new SoundPlayer(Properties.Resources.sound_fail);
		static SoundPlayer sound_key = new SoundPlayer(Properties.Resources.sound_key);
		static SoundPlayer sound_start = new SoundPlayer(Properties.Resources.sound_start);
		static SoundPlayer sound_youwin = new SoundPlayer(Properties.Resources.sound_youwin);
		static bool soundEnabled = true;

		public static void sound_on()
		{
			soundEnabled = true;
		}
		public static void sound_of()
		{
			soundEnabled = false;
		}

		public static void play_fail()
		{
			if(soundEnabled)
			sound_fail.Play();
		}
		public static void play_key()
		{
			if (soundEnabled)
				sound_key.Play();
		}
		public static void play_start()
		{
			if (soundEnabled)
				sound_start.Play();
		}
		public static void play_youwin()
		{
			if (soundEnabled)
				sound_youwin.Play();
		}
	}
}
