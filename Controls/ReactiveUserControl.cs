#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.Collections.Generic;
using System.ComponentModel;
using System.Reactive;
using System.Runtime.CompilerServices;
using System.Threading;

using ReactiveUI;

#endregion

namespace QMediaVSIX.Controls;

public abstract class ReactiveUserControl<TViewModel> : ReactiveUI.ReactiveUserControl<TViewModel>, IReactiveObject where TViewModel : class {

    readonly Lazy<Unit> _PropertyChangingEventsSubscribed;
    readonly Lazy<Unit> _PropertyChangedEventsSubscribed;

    /// <summary>
    /// Initialises a new instance of the <see cref="ReactiveObject"/> class.
    /// </summary>
    protected ReactiveUserControl() {
        _PropertyChangingEventsSubscribed = new Lazy<Unit>(
            () => {
                this.SubscribePropertyChangingEvents();
                return Unit.Default;
            },
            LazyThreadSafetyMode.PublicationOnly);
        _PropertyChangedEventsSubscribed = new Lazy<Unit>(
            () => {
                this.SubscribePropertyChangedEvents();
                return Unit.Default;
            },
            LazyThreadSafetyMode.PublicationOnly);
    }

    /// <inheritdoc/>
    public event PropertyChangingEventHandler? PropertyChanging {
        add {
            _ = _PropertyChangingEventsSubscribed.Value;
            PropertyChangingHandler += value;
        }
        remove => PropertyChangingHandler -= value;
    }

    /// <inheritdoc/>
    public event PropertyChangedEventHandler? PropertyChanged {
        add {
            _ = _PropertyChangedEventsSubscribed.Value;
            PropertyChangedHandler += value;
        }
        remove => PropertyChangedHandler -= value;
    }

    event PropertyChangingEventHandler? PropertyChangingHandler;

    event PropertyChangedEventHandler? PropertyChangedHandler;

    /// <inheritdoc/>
    void IReactiveObject.RaisePropertyChanging( PropertyChangingEventArgs Args ) =>
        PropertyChangingHandler?.Invoke(this, Args);

    /// <inheritdoc/>
    void IReactiveObject.RaisePropertyChanged( PropertyChangedEventArgs Args ) =>
        PropertyChangedHandler?.Invoke(this, Args);

    /// <inheritdoc cref="IReactiveObjectExtensions.RaiseAndSetIfChanged{TObj, TRet}(TObj, ref TRet, TRet, string?)"/>
    /// <param name="BackingField">A reference to the backing field for this
    /// property.</param>
    /// <param name="NewValue">The new value.</param>
    /// <param name="PropertyName">The name of the property, usually
    /// automatically provided through the CallerMemberName attribute.</param>
    public TRet RaiseAndSetIfChanged<TRet>( ref TRet BackingField, TRet NewValue, [CallerMemberName] string? PropertyName = null ) => IReactiveObjectExtensions.RaiseAndSetIfChanged(this, ref BackingField, NewValue, PropertyName);


    /// <inheritdoc cref="IReactiveObjectExtensions.RaisePropertyChanged{TSender}(TSender, string?)"/>
    /// <param name="PropertyName"> A string representing the name of the property that has been changed. Leave <see langword="null"/> to let the runtime set to caller member name. </param>
    public void RaisePropertyChanged( [CallerMemberName] string? PropertyName = null ) => IReactiveObjectExtensions.RaisePropertyChanged(this, PropertyName);


    /// <inheritdoc cref="IReactiveObjectExtensions.RaisePropertyChanging{TSender}(TSender, string?)"/>
    /// <param name="PropertyName"> A string representing the name of the property that has been changed. Leave <see langword="null"/> to let the runtime set to caller member name. </param>
    public void RaisePropertyChanging( [CallerMemberName] string? PropertyName = null ) => IReactiveObjectExtensions.RaisePropertyChanging(this, PropertyName);
}