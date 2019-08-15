using System;
using System.Threading;
using Xamarin.Forms;

namespace App1.Base
{
    public class BaseViewModel : BaseNotify
    {
        public string Title
        {
            get => _title;
            set => SetPropertyChanged(ref _title, value);
        }
        private string _title;

        bool _isBusy;
        bool _isRefreshing;
        CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

        public bool IsRefreshing
        {
            get => _isRefreshing;
            set
            {
                SetPropertyChanged(ref _isRefreshing, value);
                SetPropertyChanged("IsNotRefreshing");
            }
        }

        public virtual bool IsBusy
        {
            get => _isBusy;
            set
            {
                SetPropertyChanged(ref _isBusy, value);
                SetPropertyChanged("IsNotBusy");
            }
        }

        public bool IsNotBusy => !IsBusy;

        public bool IsNotRefreshing => !IsRefreshing;

        public virtual void NotifyPropertiesChanged()
        {
        }
    }

    /// <summary>
    /// Helper class that enforces the flag will always get set to false
    /// </summary>
    public class Busy : IDisposable
    {
        readonly object _sync = new object();
        readonly BaseViewModel _viewModel;

        public Busy(BaseViewModel viewModel)
        {
            _viewModel = viewModel;
            Device.BeginInvokeOnMainThread(() =>
            {
                lock (_sync)
                {
                    _viewModel.IsBusy = true;
                }
            });
        }

        public void Dispose()
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                lock (_sync)
                {
                    _viewModel.IsBusy = false;
                }
            });
        }
    }

    /// <summary>
    /// Helper class that enforces the flag will always get set to false
    /// </summary>
    public class Refreshing : IDisposable
    {
        readonly object _sync = new object();
        readonly BaseViewModel _viewModel;

        public Refreshing(BaseViewModel viewModel)
        {
            _viewModel = viewModel;
            Device.BeginInvokeOnMainThread(() =>
            {
                lock (_sync)
                {
                    _viewModel.IsRefreshing = true;
                }
            });
        }

        public void Dispose()
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                lock (_sync)
                {
                    _viewModel.IsRefreshing = false;
                }
            });
        }

    }
}
