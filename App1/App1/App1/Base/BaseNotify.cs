using App1.Extention;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace App1.Base
{
    //todo: проверить расширения!!! - ошибка. 
    public class BaseNotify : INotifyPropertyChanged, IDisposable
    {
        readonly Dictionary<string, List<Action>> _actions = new Dictionary<string, List<Action>>();

        public event PropertyChangedEventHandler PropertyChanged;

        public BaseNotify()
        {
            PropertyChanged += onPropertyChanged;
        }

        public virtual void Dispose()
        {
            ClearEvents();
        }

        public bool SetPropertyChanged<T>(ref T currentValue, T newValue, [CallerMemberName] string propertyName = "")
        {
            return PropertyChanged.SetProperty(this, ref currentValue, newValue, propertyName);
        }

        public void SetPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        void onPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            if (!_actions.TryGetValue(propertyChangedEventArgs.PropertyName, out var actionList))
            {
                return;
            }
            foreach (var action in actionList)
            {
                action();
            }
        }

        public void ClearEvents()
        {
            //Super awesome trick to wipe attached event handlers - +1 Clancey
            _actions.Clear();
            if (PropertyChanged == null)
            {
                return;
            }
            var invocation = PropertyChanged.GetInvocationList();
            foreach (var p in invocation)
            {
                PropertyChanged -= (PropertyChangedEventHandler)p;
            }
        }

        public bool SetProperty<T>(this PropertyChangedEventHandler handler, object sender, ref T currentValue, T newValue, [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(currentValue, newValue))
            {
                return false;
            }
            currentValue = newValue;

            if (sender is IDirty dirty)
            {
                dirty.IsDirty = true;
            }
            handler?.Invoke(sender, new PropertyChangedEventArgs(propertyName));
            return true;
        }
    }

    public interface IDirty
    {
        bool IsDirty { get; set; }
    }
}
