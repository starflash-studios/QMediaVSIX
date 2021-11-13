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

internal abstract class SessionCommand<T> : SimpleCommand<T> where T : SimpleCommand<T> {
    /// <inheritdoc />
    protected SessionCommand( AsyncPackage Package, OleMenuCommandService CommandService ) : base(Package, CommandService) {
        //MediaSessionManager.CurrentSessionChanged += ( _, MS, MSE ) => {
        //    if ( MSE is not null ) {
        //        MSE.PropertyChanged -= OnCurrentSessionPropertyChanged;
        //    }
        //    if ( MS is not null ) {
        //        MS.PropertyChanged += OnCurrentSessionPropertyChanged;
        //    }
        //    OnCurrentSessionChanged();
        //};
        SessionCommandManager.RunWhenInitialised( I => {
            I.PropertyChanged += ( _, E ) => {
                switch ( E.PropertyName ) {
                    case nameof(SessionCommandManager.Active):
                        OnCurrentSessionChanged();
                        break;
                }
            };
        });
    }

    /// <summary>
    /// The current user-controlled <see cref="MediaSession"/>.
    /// </summary>
    public MediaSession? Current => SessionCommandManager.Active;

    public virtual void OnCurrentSessionPropertyChanged( object Sender, PropertyChangedEventArgs E ) { }

    public virtual void OnCurrentSessionChanged() {
        //Debug.WriteLine($"OnCurrentSessionChanged() on {GetType().GetTypeName()}");
        SetCommandEnabled(Current switch { { } => true, _ => false });
    }
}