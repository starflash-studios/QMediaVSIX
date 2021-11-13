#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.ComponentModel;
using System.ComponentModel.Design;

using Microsoft.VisualStudio.Shell;

using QMediaVSIX.Core.MediaSource.Software;

#endregion

namespace QMediaVSIX.Commands;

internal abstract class SessionCommand<T> : SimpleCommand<T> where T : SimpleCommand<T> {
    /// <inheritdoc />
    protected SessionCommand( AsyncPackage Package, OleMenuCommandService CommandService ) : base(Package, CommandService) {
        SessionCommandManager.RunWhenInitialised(I => {
            I.PropertyChanged += ( _, E ) => {
                Current = E.PropertyName switch {
                    nameof(SessionCommandManager.Active) => SessionCommandManager.Active,
                    _                                    => Current
                };
            };
            Current = SessionCommandManager.Active;
        });
    }

    MediaSession? _Current;
    /// <summary>
    /// The current user-controlled <see cref="MediaSession"/>.
    /// </summary>
    public MediaSession? Current {
        get {
            switch ( _Current ) {
                case { } C:
                    return C;
                default:
                    MediaSessionManager.RefreshCurrentSession();
                    return MediaSessionManager.Current;
            }
        }
        set {
            if (_Current == value ) { return; }
            RaisePropertyChanging();

            if ( value is { } Old ) {
                Old.PropertyChanged -= OnCurrentSessionPropertyChanged;
            }

            _Current = value;

            if ( value is { } New ) {
                New.PropertyChanged += OnCurrentSessionPropertyChanged;
                if ( EnableButtonRelativeToSessionNullability ) {
                    SetCommandEnabled();
                }
            } else if ( EnableButtonRelativeToSessionNullability ) {
                SetCommandDisabled();
            }

            OnCurrentSessionChanged();
            RaisePropertyChanged();
        }
    }

    public virtual bool EnableButtonRelativeToSessionNullability => true;

    public virtual void OnCurrentSessionPropertyChanged( object Sender, PropertyChangedEventArgs E ) { }

    public virtual void OnCurrentSessionChanged() { }
}