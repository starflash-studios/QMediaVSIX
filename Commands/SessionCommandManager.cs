#region Copyright (C) 2017-2021  Starflash Studios

// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html

#endregion

using System.Threading.Tasks;

using Microsoft.VisualStudio.Shell;

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
                Debug.WriteLine($"Active session changed to {value}");
                _Active = value;
                Instance.RaisePropertyChanged();
            }
        }
    }

    public static Action<Func<Task>> AsyncRunner = null!;

    public SessionCommandManager() {
        if ( Instance is not null ) {
            throw new NotSupportedException("May not create multiple instances.");
        }
        AsyncRunner = Tk => _ = ThreadHelper.JoinableTaskFactory.RunAsync(Tk);
        foreach (MediaSession Session in MediaSessionManager.Sessions.Values ) {
            Session.AsyncRunner = AsyncRunner;
        }
        MediaSessionManager.SessionConnected += ( S, _ ) => {
            S.AsyncRunner = AsyncRunner;
        };
        MediaSessionManager.CurrentSessionChanged += ( _, E ) => Active = E;
    }
}