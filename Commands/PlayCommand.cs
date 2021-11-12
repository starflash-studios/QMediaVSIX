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

using Windows.Media.Control;

#endregion

namespace QMediaVSIX.Commands;

/// <summary>
/// Command handler
/// </summary>
internal sealed class PlayCommand : SessionPlaybackCommand<PlayCommand> {
    /// <summary>
    /// Command ID.
    /// </summary>
    public const int CommandId = 256;

    /// <summary>
    /// Command menu group (command set GUID).
    /// </summary>
    public static readonly Guid CommandSet = new Guid("a36c982e-236d-489b-8703-7e1fc268d77c");

    /// <inheritdoc />
    protected override int SelfCommandId => CommandId;

    /// <inheritdoc />
    protected override Guid SelfCommandSet => CommandSet;

    /// <summary>
    /// Initialises a new instance of the <see cref="PlayCommand"/> class.
    /// Adds our command handlers for menu (commands must exist in the command table file)
    /// </summary>
    /// <param name="Package">Owner package, not null.</param>
    /// <param name="CommandService">Command service to add command to, not null.</param>
    public PlayCommand( AsyncPackage Package, OleMenuCommandService CommandService ) : base(Package, CommandService) { }

    GlobalSystemMediaTransportControlsSessionPlaybackStatus? _LastStatus = null;
    void ApplyNewStatus( GlobalSystemMediaTransportControlsSessionPlaybackStatus? Status ) {
        if ( _LastStatus == Status ) { return; }
        _LastStatus = Status;
        if ( Status is null ) {
            SetCommandEnabled(false);
            return;
        }

        bool WillEnable = Status != GlobalSystemMediaTransportControlsSessionPlaybackStatus.Playing;
        if ( WillEnable ) { //Always disable the other command first.
            PauseCommand.Instance?.SetCommandEnabled(false);
            SetCommandEnabled(true);
        } else {
            SetCommandEnabled(false);
            PauseCommand.Instance?.SetCommandEnabled(true);
        }
    }

    /// <summary>
    /// Gets the instance of the command.
    /// </summary>
    public new static PlayCommand? Instance { get; set; }

    /// <inheritdoc />
    public override string Title => "PlayCommand";

    /// <inheritdoc />
    public override void Execute( object Sender, EventArgs E ) {
        if ( Current is { } C ) {
            Debug.WriteLine($"Playing {C}");
            //SetCommandDisabled();
            //PauseCommand.Instance?.SetCommandEnabled();
            C.Play();
        } else {
            Debug.WriteLine("Attempted to play, but no session was active.");
        }
    }

    /// <inheritdoc />
    public override void ApplyChanges( MediaSession? ChangedSession ) => ApplyNewStatus(ChangedSession?.PlaybackStatus);

    public override bool EnableButtonRelativeToSessionNullability => false;
}