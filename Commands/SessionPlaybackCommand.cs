#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.ComponentModel;

using Microsoft.VisualStudio.Shell;

using QMediaVSIX.Core.MediaSource.Software;

#endregion

namespace QMediaVSIX.Commands;

internal abstract class SessionPlaybackCommand<T> : SessionCommand<T> where T : SessionPlaybackCommand<T> {
    /// <inheritdoc />
    protected SessionPlaybackCommand( AsyncPackage Package, OleMenuCommandService CommandService ) : base(Package, CommandService) {
        // ReSharper disable once VirtualMemberCallInConstructor
        ApplyChanges(SessionCommandManager.Active);
    }

    public override void OnCurrentSessionChanged() {
        if ( Current is { } C ) {
            ApplyChanges(C);
        } else {
            ApplyChanges(null);
        }
    }

    public override void OnCurrentSessionPropertyChanged( object Sender, PropertyChangedEventArgs E ) => ApplyChanges(Current);

    public abstract void ApplyChanges( MediaSession? ChangedSession );
}