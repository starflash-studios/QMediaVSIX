#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.Runtime.CompilerServices;

#endregion

namespace QMediaVSIX.Core.Collections;

public static class NotifyPropertyChange_Extensions {

	public static T GetValue<T>( this INotifyCollectionChange _, T Value ) => Value;

	public static void SetValue<T>( this INotifyPropertyChange NPC, ref T Value, T NewValue, [CallerMemberName] string? PropertyName = null ) {
		static bool Check( T A, T B ) => A is not IEquatable<T> Eq || Eq.Equals(B);
		//return Value is null ? NewValue is null : NewValue is not null && Value.Equals(NewValue);
		SetVal(NPC, ref Value, NewValue, Check, PropertyName);
	}

	public static void SetValue<T>( this INotifyPropertyChange NPC, ref T Value, T NewValue, IEqualityComparer<T> EqualityComparer, [CallerMemberName] string? PropertyName = null )  {
		bool Check( T A, T B ) => EqualityComparer.Equals(A, B);
		SetVal(NPC, ref Value, NewValue, Check, PropertyName);
	}

	public static void SetValue<T>( this INotifyPropertyChange NPC, ref T Value, T NewValue, Func<T, T, bool> EqualityComparer, [CallerMemberName] string? PropertyName = null )  {
		SetVal(NPC, ref Value, NewValue, EqualityComparer, PropertyName);
	}

	public static void SetValue<T>( this INotifyPropertyChange NPC, ref IEnumerable<T> Value, IEnumerable<T> NewValue, [CallerMemberName] string? PropertyName = null )  {
		static bool Check( IEnumerable<T> A, IEnumerable<T> B ) => A.SequenceEqual(B);
		SetVal(NPC, ref Value, NewValue, Check, PropertyName);
	}

	internal static void SetVal<T>( this INotifyPropertyChange NPC, ref T Value, T NewValue, Func<T, T, bool> EqualityComparer, [CallerMemberName] string? PropertyName = null )  {
		if ( !( (Value is null ? NewValue is null : NewValue is not null) && EqualityComparer(Value, NewValue)) ) {
			//Debug.WriteLine("Raising Changing");
			NPC.OnPropertyChanging(NPC, PropertyName);
			//Debug.WriteLine("Changing Value");
			Debug.WriteLine($"{NPC.GetType().Name}.{PropertyName} changing from '{Value}' to '{NewValue}'");
			Value = NewValue;
			//Debug.WriteLine("Raising Changed");
			NPC.OnPropertyChanged(NPC, PropertyName);
		}
	}

	//public static void SetValue<T>( this INotifyPropertyChange NPC, ref T? Value, T? NewValue, bool CheckNullability, [CallerMemberName] string? PropertyName = null ) {
	//	bool Check( T? A, T? B ) => A is not IEquatable<T> Eq || Eq.Equals(B);
	//	//return Value is null ? NewValue is null : NewValue is not null && Value.Equals(NewValue);
	//	SetVal(NPC, ref Value, NewValue, Check, PropertyName);
	//}

	//public static void SetValue<T>( this INotifyPropertyChange NPC, ref T? Value, T? NewValue, bool CheckNullability,  IEqualityComparer<T> EqualityComparer, [CallerMemberName] string? PropertyName = null ) {
	//	bool Check( T A, T B ) => EqualityComparer.Equals(A, B);
	//	SetVal(NPC, ref Value, NewValue, Check, PropertyName);
	//}

	//public static void SetValue<T>( this INotifyPropertyChange NPC, ref T? Value, T? NewValue, bool CheckNullability, Func<T?, T?, bool> EqualityComparer, [CallerMemberName] string? PropertyName = null ) {
	//	SetVal(NPC, ref Value, NewValue, EqualityComparer, PropertyName);
	//}

	//public static void SetValue<T>( this INotifyPropertyChange NPC, ref IEnumerable<T?>? Value, IEnumerable<T?>? NewValue, bool CheckNullability, [CallerMemberName] string? PropertyName = null ) {
	//	static bool Check( IEnumerable<T?>? A, IEnumerable<T?>? B ) => A is null ? B is null : B is not null && A.SequenceEqual(B);
	//	SetVal(NPC, ref Value, NewValue, Check, PropertyName);
	//}

	//internal static void SetVal<T>( this INotifyPropertyChange NPC, ref T? Value, T? NewValue, Func<T?, T?, bool>? EqualityComparer, bool CheckNullability, [CallerMemberName] string? PropertyName = null ) {
	//	//!((!CheckNullability || (Value is null ? NewValue is null : NewValue is not null)) && EqualityComparer(Value, NewValue))
	//	if ( (!CheckNullability || Value is null ? NewValue is null : NewValue is not null)
	//	     && (EqualityComparer is not { } Eq || Eq(Value, NewValue)) ) {
	//		NPC.OnPropertyChanging(NPC, PropertyName);
	//		Value = NewValue;
	//		NPC.OnPropertyChanged(NPC, PropertyName);
	//	}
	//}

	public static void ForceSetValue<T>( this INotifyPropertyChange NPC, ref T Value, T NewValue, [CallerMemberName] string? PropertyName = null ) {
		NPC.OnPropertyChanging(NPC, PropertyName);
		Value = NewValue;
		NPC.OnPropertyChanged(NPC, PropertyName);
	}

	//public static void SetValue<T>( this INotifyPropertyChange NPC, ref T? Value, T? NewValue, [CallerMemberName] string? PropertyName = null ) where T : struct {
	//	static bool Check( T? A, T? B ) => A is null ? B is null : B is not null && (A is not IEquatable<T> Eq || Eq.Equals(B));
	//	//return Value is null ? NewValue is null : NewValue is not null && Value.Equals(NewValue);
	//	SetVal(NPC, ref Value, NewValue, Check, PropertyName);
	//}

}