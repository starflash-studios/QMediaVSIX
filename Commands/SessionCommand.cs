#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using Microsoft.VisualStudio.Shell;

using QMediaVSIX.Core.MediaSource.Software;

#endregion

namespace QMediaVSIX.Commands;

internal abstract class SessionCommand : SimpleCommand<SessionCommand> {
    /// <inheritdoc />
    protected SessionCommand( AsyncPackage Package, OleMenuCommandService CommandService ) : base(Package, CommandService) { }

    /// <summary>
    /// The current user-controlled <see cref="MediaSession"/>.
    /// </summary>
    public MediaSession? Current => SessionCommandManager.Active;
}