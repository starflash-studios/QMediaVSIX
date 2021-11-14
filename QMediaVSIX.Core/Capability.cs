#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

namespace QMediaVSIX.Core;

public class Capability : ICapability {

	public static readonly Capability None = new Capability(false, () => throw new NotImplementedException());

	public Capability( bool Available, Action Activate ) {
		this.Available = Available;
		_Act = Activate;
	}

	/// <inheritdoc />
	public bool Available { get; }

	readonly Action _Act;

	/// <inheritdoc />
	public void Activate() => _Act();
}