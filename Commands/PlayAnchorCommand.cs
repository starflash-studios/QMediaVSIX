#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using Microsoft.VisualStudio.Shell;

#endregion

namespace QMediaVSIX.Commands;

/// <summary>
/// Command handler
/// </summary>
internal sealed class PlayAnchorCommand : MenuControllerAnchorCommand<PlayAnchorCommand> {
    /// <summary>
    /// Command ID.
    /// </summary>
    public const int CommandId = 5999;

    /// <summary>
    /// Command menu group (command set GUID).
    /// </summary>
    public static readonly Guid CommandSet = new Guid("a36c982e-236d-489b-8703-7e1fc268d77c");

    /// <inheritdoc />
    protected override int SelfCommandId => CommandId;

    /// <inheritdoc />
    protected override Guid SelfCommandSet => CommandSet;

    public PlayAnchorCommand( AsyncPackage Package, OleMenuCommandService CommandService ) : base(Package, CommandService) { }

    //public override void OnCurrentSessionChanged() {
    //    if ( SessionCommandManager.Active is { } A ) {
    //        ChangeEnableable(Package, new CommandID(CommandSet, CommandId), A.IsPlayEnabled);
    //    } else {
    //        base.OnCurrentSessionChanged();
    //    }
    //}

    // ReSharper disable once ReplaceAutoPropertyWithComputedProperty
    /// <summary>
    /// Gets the instance of the command.
    /// </summary>
    public new static PlayAnchorCommand? Instance { get; } = null;

    /// <inheritdoc />
    public override string Title => "PlayAnchorCommand";

    /// <inheritdoc />
    public override void Execute( object Sender, EventArgs E ) {
        if ( Current is { } C ) {
            Debug.WriteLine($"Playing {C}");
            C.Play();
        } else {
            Debug.WriteLine("Attempted to play, but no session was active.");
        }
    }

    public override void OnCurrentSessionChanged() { } //Ignore. This command should not be disabled.
}