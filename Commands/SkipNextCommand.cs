﻿#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.ComponentModel.Design;

using Microsoft.VisualStudio.Shell;

#endregion

namespace QMediaVSIX.Commands;

/// <summary>
/// Command handler
/// </summary>
internal sealed class SkipNextCommand : SessionCommand<SkipNextCommand> {
    /// <summary>
    /// Command ID.
    /// </summary>
    public const int CommandId = 4130;

    /// <summary>
    /// Command menu group (command set GUID).
    /// </summary>
    public static readonly Guid CommandSet = new Guid("a36c982e-236d-489b-8703-7e1fc268d77c");


    /// <inheritdoc />
    protected override int SelfCommandId => CommandId;

    /// <inheritdoc />
    protected override Guid SelfCommandSet => CommandSet;

    /// <summary>
    /// Initialises a new instance of the <see cref="SkipNextCommand"/> class.
    /// Adds our command handlers for menu (commands must exist in the command table file)
    /// </summary>
    /// <param name="Package">Owner package, not null.</param>
    /// <param name="CommandService">Command service to add command to, not null.</param>
    public SkipNextCommand( AsyncPackage Package, OleMenuCommandService CommandService ) : base(Package, CommandService) { }

    public override void OnCurrentSessionChanged() {
        if ( SessionCommandManager.Active is { } A ) {
            ChangeEnableable(Package, new CommandID(CommandSet, CommandId), A.IsNextEnabled);
        } else {
            base.OnCurrentSessionChanged();
        }
    }

    /// <summary>
    /// Gets the instance of the command.
    /// </summary>
    public new static SkipNextCommand? Instance { get; set; }

    /// <summary>
    /// The title of the command.
    /// </summary>
    public override string Title => "Skip Next";

    public override void Execute( object Sender, EventArgs E ) {
        Debug.WriteLine($"Skipping to next in {Current?.ToString() ?? "<NULL>"}");
        Current?.SkipNext();
    }
}