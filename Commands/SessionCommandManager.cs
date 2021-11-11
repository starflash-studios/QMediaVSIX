#region Copyright (C) 2017-2021  Starflash Studios

// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html

#endregion

using QMediaVSIX.Controls;
using QMediaVSIX.Core.MediaSource.Software;

namespace QMediaVSIX.Commands;

[InstanceProvider(nameof(Instance), nameof(Init))]
public class SessionCommandManager : NotifyPropertyChange {

    // ReSharper disable once ReplaceAutoPropertyWithComputedProperty
    public static SessionCommandManager? Instance { get; } = null;

    public static SessionCommandManager Init() => new SessionCommandManager();

    static MediaSession? _Active = null;
    public static MediaSession? Active {
        get => _Active;
        set {
            if (Instance is null ) {
                //If no instance is created yet, there's no reason to raise property change notifications as there will be no receivers anyways. Just change the value and return.
                _Active = value;
                return;
            }
            if ( value != _Active ) {
                Instance.RaisePropertyChanging();
                _Active = value;
                Instance.RaisePropertyChanged();
            }
        }
    }

    public SessionCommandManager() {
        MediaSessionManager.CurrentSessionChanged += ( _, E ) => Active = E;
    }
}