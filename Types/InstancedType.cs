#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

namespace QMediaVSIX.Types;

[InstanceProvider(nameof(Instance), "Init")]
public abstract class InstancedType {
    // ReSharper disable once ReplaceAutoPropertyWithComputedProperty
    public static InstancedType? Instance { get; } = null;

    ///// <summary>
    ///// Constructor used for <see cref="Instance"/> construction and initialisation.
    ///// </summary>
    ///// <returns>A newly constructed <see cref="InstancedType"/>.</returns>
    //public abstract InstancedType Init();
}