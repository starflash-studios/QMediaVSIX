#region Copyright (C) 2017-2021  Starflash Studios

// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html

#endregion

using System.Runtime.CompilerServices;

using QMediaVSIX.Core.Collections;

using ReactiveUI;

namespace QMediaVSIX.Views;

public abstract class NotifyPropertyChange : ReactiveObject, INotifyPropertyChange {
  ///// <inheritdoc/>
  //void IReactiveObject.RaisePropertyChanging( PropertyChangingEventArgs args ) =>
  //	PropertyChangingHandler?.Invoke(this, args);

  ///// <inheritdoc/>
  //void IReactiveObject.RaisePropertyChanged( PropertyChangedEventArgs args ) =>
  //	PropertyChangedHandler?.Invoke(this, args);

  /// <inheritdoc />
  public void OnPropertyChanging( object? Sender, [CallerMemberName] string? PropertyName = null ) => (Sender as NotifyPropertyChange)?.RaisePropertyChanging(PropertyName);

  /// <inheritdoc />
  public void OnPropertyChanged( object? Sender, [CallerMemberName] string? PropertyName = null ) => (Sender as NotifyPropertyChange)?.RaisePropertyChanged(PropertyName);
}