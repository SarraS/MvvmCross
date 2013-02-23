using System;
using System.Collections.Specialized;
using System.ComponentModel;
using Cirrious.MvvmCross.Binding.WeakSubscription;

namespace Cirrious.MvvmCross.Binding.ExtensionMethods
{
    public static class MvxWeakSubscriptionExtensionMethods
    {
        public static MvxNotifyPropertyChangedEventSubscription WeakSubscribe(this INotifyPropertyChanged source, EventHandler<PropertyChangedEventArgs> eventHandler)
        {
            return new MvxNotifyPropertyChangedEventSubscription(source, eventHandler);
        }

        public static MvxNotifyCollectionChangedEventSubscription WeakSubscribe(this INotifyCollectionChanged source, EventHandler<NotifyCollectionChangedEventArgs> eventHandler)
        {
            return new MvxNotifyCollectionChangedEventSubscription(source, eventHandler);
        }
    }
}