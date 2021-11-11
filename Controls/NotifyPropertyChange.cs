#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.Collections.Generic;
using System.Runtime.CompilerServices;

using QMediaVSIX.Core.Collections;

using ReactiveUI;

#endregion

namespace QMediaVSIX.Controls;

public abstract class NotifyPropertyChange : ReactiveObject, INotifyPropertyChange {
    ///// <inheritdoc/>
    //void IReactiveObject.RaisePropertyChanging( PropertyChangingEventArgs args ) =>
    //	PropertyChangingHandler?.Invoke(this, args);

    ///// <inheritdoc/>
    //void IReactiveObject.RaisePropertyChanged( PropertyChangedEventArgs args ) =>
    //	PropertyChangedHandler?.Invoke(this, args);

    /// <inheritdoc />
    public void OnPropertyChanging( object? Sender, [CallerMemberName] string? PropertyName = null ) => (Sender as NotifyPropertyChange)?.RaisePropertyChanging(PropertyName);

    /// <inheritdoc cref="OnPropertyChanging(object?, string?)"/>
    public void OnPropertyChanging( [CallerMemberName] string? PropertyName = null ) => OnPropertyChanging(this, PropertyName);

    /// <inheritdoc cref="IReactiveObjectExtensions.RaisePropertyChanging{TSender}(TSender, string?)"/>
    /// <param name="PropertyName"> A string representing the name of the property that is being changed. Leave <see langword="null"/> to let the runtime set to caller member name. </param>
    public void RaisePropertyChanging( [CallerMemberName] string? PropertyName = null ) => ((IReactiveObject)this).RaisePropertyChanging(PropertyName);

    /// <inheritdoc />
    public void OnPropertyChanged( object? Sender, [CallerMemberName] string? PropertyName = null ) => (Sender as NotifyPropertyChange)?.RaisePropertyChanged(PropertyName);

    /// <inheritdoc cref="OnPropertyChanged(object?, string?)"/>
    /// <param name="PropertyName"> A string representing the name of the property that has been changed. Leave <see langword="null"/> to let the runtime set to caller member name. </param>
    public void OnPropertyChanged( [CallerMemberName] string? PropertyName = null ) => OnPropertyChanged(this, PropertyName);

    /// <inheritdoc cref="IReactiveObjectExtensions.RaisePropertyChanged{TSender}(TSender, string?)"/>
    public void RaisePropertyChanged( [CallerMemberName] string? PropertyName = null ) => ((IReactiveObject)this).RaisePropertyChanged(PropertyName);

    /// <inheritdoc cref="IReactiveObjectExtensions.RaiseAndSetIfChanged{TObj, TRet}(TObj, ref TRet, TRet, string?)"/>
    /// <param name="BackingField">A Reference to the backing field for this property.</param>
    /// <param name="NewValue">The new value.</param>
    /// <param name="PropertyName">The name of the property, usually automatically provided through the <see cref="CallerMemberNameAttribute"/>.</param>
    public TRet RaiseAndSetIfChanged<TRet>( ref TRet BackingField, TRet NewValue, [CallerMemberName] string? PropertyName = null ) => ((IReactiveObject)this).RaiseAndSetIfChanged(ref BackingField, NewValue, PropertyName);
}