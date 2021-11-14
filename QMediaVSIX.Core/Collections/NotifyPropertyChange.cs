#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

#endregion

namespace QMediaVSIX.Core.Collections;

public abstract class NotifyPropertyChange : INotifyPropertyChange {
	/// <inheritdoc />
	public event PropertyChangingEventHandler? PropertyChanging = delegate { };

	/// <inheritdoc />
	public event PropertyChangedEventHandler? PropertyChanged = delegate { };

	/// <inheritdoc />
	public void OnPropertyChanging( object? Sender, [CallerMemberName] string? PropertyName = null ) => PropertyChanging?.Invoke(Sender, new PropertyChangingEventArgs(PropertyName));

	/// <inheritdoc />
	public void OnPropertyChanged( object? Sender, [CallerMemberName] string? PropertyName = null ) => PropertyChanged?.Invoke(Sender, new PropertyChangedEventArgs(PropertyName));


	[SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Consistency")]
	public T GetValue<T>( T Value ) => Value;

	public void SetValue<T>( ref T Value, T NewValue, [CallerMemberName] string? PropertyName = null ) => NotifyPropertyChange_Extensions.SetValue(this, ref Value, NewValue, PropertyName);

	public void SetValue<T>( ref T Value, T NewValue, IEqualityComparer<T> EqualityComparer, [CallerMemberName] string? PropertyName = null ) => NotifyPropertyChange_Extensions.SetValue(this, ref Value, NewValue, EqualityComparer, PropertyName);

	public void SetValue<T>( ref T Value, T NewValue, Func<T, T, bool> EqualityComparer, [CallerMemberName] string? PropertyName = null ) => NotifyPropertyChange_Extensions.SetValue(this, ref Value, NewValue, EqualityComparer, PropertyName);

	public void SetValue<T>( ref IEnumerable<T> Value, IEnumerable<T> NewValue, [CallerMemberName] string? PropertyName = null ) => NotifyPropertyChange_Extensions.SetValue(this, ref Value, NewValue, PropertyName);

	public void ForceSetValue<T>( ref T Value, T NewValue, [CallerMemberName] string? PropertyName = null ) => NotifyPropertyChange_Extensions.ForceSetValue(this, ref Value, NewValue, PropertyName);

	//public void SetValue<T>( ref T? Value, T? NewValue, [CallerMemberName] string? PropertyName = null ) where T : struct => NotifyPropertyChange_Extensions.SetValue(this, ref Value, NewValue, PropertyName);
}