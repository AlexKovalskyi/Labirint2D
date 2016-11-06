using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Labirint2DWPF.Commands
{
	public abstract class CommandBase : ICommand
	{
		public Action<object> _execute;
		public Predicate<object> _canExecute;

		public CommandBase()
		{

		}
		public CommandBase(Action<object> execute)
			: this(execute, null)
		{
		}

		public CommandBase(Action<object> execute, Predicate<object> canExecute)
		{
			if (execute == null)
				throw new ArgumentNullException(nameof(execute), "Argument must not be null.");

			_execute = execute;
			_canExecute = canExecute;
		}

		public virtual event EventHandler CanExecuteChanged
		{
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}

		public abstract void Execute(object parameters);

		public virtual bool CanExecute(object parameter)
		{
			var result = _canExecute == null ? true : _canExecute(parameter);

			return result;
		}
	}
}
