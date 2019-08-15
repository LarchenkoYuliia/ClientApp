using App1.Base;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace App1.Extention
{
    public static class BaseNotify
    {
        //Just adding some new funktionality to System.ComponentModel
        public static bool SetProperty<T>(this PropertyChangedEventHandler handler, object sender, ref T currentValue, T newValue, [CallerMemberName] string propertyName = "")
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
}
