#region Copyright (C) 2017-2021  Starflash Studios

// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html

#endregion

using System.ComponentModel;

using Microsoft.VisualStudio.Shell;

using QMediaVSIX.Core.MediaSource.Software;

namespace QMediaVSIX.Commands;

internal abstract class SessionPlaybackCommand<T> : SessionCommand<T> where T : SessionPlaybackCommand<T> {
    /// <inheritdoc />
    protected SessionPlaybackCommand( AsyncPackage Package, OleMenuCommandService CommandService ) : base(Package, CommandService) {
        SessionCommandManager.SlowPoll += ( S, _ ) => {
            ApplyChanges(SessionCommandManager.Active);
        };
        if ( Current is { } C ) {
            // ReSharper disable once VirtualMemberCallInConstructor
            ApplyChanges(C);
        }
    }

    public override void OnCurrentSessionChanged() {
        if ( Current is { } C ) {
            ApplyChanges(C);
        } else {
            SetCommandDisabled();
        }
    }

    public override void OnCurrentSessionPropertyChanged( object Sender, PropertyChangedEventArgs E ) => ApplyChanges(Current);

    public abstract void ApplyChanges( MediaSession? ChangedSession );

    // ReSharper disable once ReplaceAutoPropertyWithComputedProperty
    /// <summary>
    /// Gets the instance of the command.
    /// </summary>
    public new static SessionPlaybackCommand<T>? Instance { get; } = null;
}