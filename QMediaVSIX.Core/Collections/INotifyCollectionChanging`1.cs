#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

namespace QMediaVSIX.Core.Collections;

public interface INotifyCollectionChanging<T> : INotifyCollectionChanging {
	#pragma warning disable CS0109 //Member does not hide an inherited member; new keyword is not required
	public new delegate void CollectionItemChangingEventArgs( object Sender, T? Item );
	public new event CollectionItemChangingEventArgs CollectionItemChanging;
	#pragma warning restore CS0109
}