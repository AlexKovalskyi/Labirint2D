using System.Windows.Input;
using Labirint2DWPF.Commands;

namespace Labirint2DWPF.ViewModel
{
	public class MainViewModel : MainViewModelBase 
	{
		private bool isSoundEnable = true;
		private string soundOn = "Sound ON";
		private string soundOff = "Sound Off";

		public bool IsSoundEnable
		{
			get
			{
				return isSoundEnable;
			}
			set
			{
				isSoundEnable = value;
				if (isSoundEnable == true)
				{
					SoundStatus = soundOn;
					Sound.soundOn();
				}
				else
				{
					SoundStatus = soundOff;
					Sound.soundOff();
				}
				Sound.play_key();
				OnPropertyChanged(nameof(IsSoundEnable));
				OnPropertyChanged(nameof(SoundStatus));
			}
		}

		public string SoundStatus
		{
			get
			{
				if (isSoundEnable == true)
				{
					return soundOn;
				}
				else
				{
					return soundOff;
				}
			}
			set { }
		}
		public ICommand ExitCommand
		{
			get
			{
				return new ExitCommand();
			}
		}
		public ICommand StartCommand
		{
			get
			{
				return new StartCommand();
			}
		}
	}
}
