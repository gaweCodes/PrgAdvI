using System;
using System.Windows.Input;

namespace MvvmDemo
{
    public class RelayCommand : ICommand
    {
        readonly Action _targetExecuteMethod;
        readonly Func<bool> _targetCanExecuteMethod;
        public RelayCommand(Action executeMethod)
        {
            _targetExecuteMethod = executeMethod;
        }
        public RelayCommand(Action executeMethod, Func<bool> canExecuteMethod)
        {
            _targetExecuteMethod = executeMethod;
            _targetCanExecuteMethod = canExecuteMethod;
        }
        public void RaiseCanExecuteChanged() => CanExecuteChanged(this, EventArgs.Empty);
        bool ICommand.CanExecute(object parameter)
        {
            if (_targetCanExecuteMethod != null) return _targetCanExecuteMethod();
            return _targetExecuteMethod != null;
        }
        public event EventHandler CanExecuteChanged = delegate { };
        void ICommand.Execute(object parameter) => _targetExecuteMethod?.Invoke();
    }
    public class RelayCommand<T> : ICommand
    {
        readonly Action<T> _targetExecuteMethod;
        readonly Func<T, bool> _targetCanExecuteMethod;
        public RelayCommand(Action<T> executeMethod) => _targetExecuteMethod = executeMethod;
        public RelayCommand(Action<T> executeMethod, Func<T, bool> canExecuteMethod)
        {
            _targetExecuteMethod = executeMethod;
            _targetCanExecuteMethod = canExecuteMethod;
        }
        public void RaiseCanExecuteChanged() => CanExecuteChanged(this, EventArgs.Empty);
        bool ICommand.CanExecute(object parameter)
        {
            if (_targetCanExecuteMethod == null) return _targetExecuteMethod != null;
            var tparm = (T)parameter;
            return _targetCanExecuteMethod(tparm);
        }
        public event EventHandler CanExecuteChanged = delegate { };
        void ICommand.Execute(object parameter) => _targetExecuteMethod?.Invoke((T) parameter);
    }
}
