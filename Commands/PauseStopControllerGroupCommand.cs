#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using Windows.Media.Control;

using Microsoft.VisualStudio.Shell;

#endregion

namespace QMediaVSIX.Commands;

/// <summary>
/// Command handler
/// </summary>
internal sealed class PauseStopControllerGroupCommand : SimpleGroupCommand<PauseStopControllerGroupCommand> {
    /// <summary>
    /// Command ID.
    /// </summary>
    public const int CommandId = 4151;

    const int
        CommandPause = 4152,
        CommandStop  = 4153;

    /// <inheritdoc />
    public override int MinCommandId => CommandPause;

    /// <inheritdoc />
    public override int MaxCommandId => CommandStop;

    /// <summary>
    /// Command menu group (command set GUID).
    /// </summary>
    public static readonly Guid CommandSet = new Guid("a36c982e-236d-489b-8703-7e1fc268d77c");

    /// <inheritdoc />
    protected override int SelfCommandId => CommandId;

    /// <inheritdoc />
    protected override Guid SelfCommandSet => CommandSet;

    public PauseStopControllerGroupCommand( AsyncPackage Package, OleMenuCommandService CommandService ) : base(Package, CommandService) { }


    // ReSharper disable once ReplaceAutoPropertyWithComputedProperty
    /// <summary>
    /// Gets the instance of the command.
    /// </summary>
    public new static PauseStopControllerGroupCommand? Instance { get; } = null;

    /// <inheritdoc />
    public override string Title => "PauseStopControllerGroupCommand";

    /// <inheritdoc />
    public override bool IsChecked( int CmdId ) => CmdId switch {
        CommandPause => SessionCommandManager.Active?.PlaybackStatus == GlobalSystemMediaTransportControlsSessionPlaybackStatus.Paused,
        CommandStop  => SessionCommandManager.Active?.PlaybackStatus is GlobalSystemMediaTransportControlsSessionPlaybackStatus.Stopped or GlobalSystemMediaTransportControlsSessionPlaybackStatus.Closed,
        _            => throw new IndexOutOfRangeException($"{nameof(CmdId)} {CmdId} was an unexpected id at this time.")
    };

    /// <inheritdoc />
    public override void OnClick( OleMenuCommand CMD ) {
        if ( SessionCommandManager.Active is not { } A ) { return; }
        switch ( CMD.CommandID.ID ) {
            case CommandPause:
                A.Pause();
                //A.IsShuffleActive = A.IsShuffleActive != true;
                CMD.Checked = A.PlaybackStatus == GlobalSystemMediaTransportControlsSessionPlaybackStatus.Paused;
                Debug.WriteLine("Paused.");
                break;
            case CommandStop:
                A.Stop();
                //A.AutoRepeatMode = A.AutoRepeatMode == MediaPlaybackAutoRepeatMode.Track ? MediaPlaybackAutoRepeatMode.None : MediaPlaybackAutoRepeatMode.Track;
                CMD.Checked = A.PlaybackStatus is GlobalSystemMediaTransportControlsSessionPlaybackStatus.Stopped or GlobalSystemMediaTransportControlsSessionPlaybackStatus.Closed;
                Debug.WriteLine("Stopped.");
                break;
        }
    }

    //public override bool ShouldCommandBeEnabled( int CmdId ) => CmdId switch {
    //    >= CommandShuffle and <= CommandRepeatList => SessionCommandManager.Active is not null,
    //    _                                          => throw new IndexOutOfRangeException($"{nameof(CmdId)} {CmdId} was an unexpected id at this time.")
    //};

    public override bool ShouldCommandBeEnabled( int CmdId ) => CmdId switch {
        CommandPause => SessionCommandManager.Active is { } A && (A.IsPauseEnabled || A.IsPlayPauseToggleEnabled),
        CommandStop  => SessionCommandManager.Active?.IsStopEnabled ?? false,
        _            => throw new IndexOutOfRangeException($"{nameof(CmdId)} {CmdId} was an unexpected id at this time.")
    };

    //public override void OnCurrentSessionChanged() {
    //    if ( SessionCommandManager.Active is { } A ) {
    //        ChangeEnableable(Package, new CommandID(CommandSet, CommandShuffle), A.IsShuffleEnabled);
    //        ChangeEnableable(Package, new CommandID(CommandSet, CommandRepeatSingle), A.IsRepeatEnabled);
    //        ChangeEnableable(Package, new CommandID(CommandSet, CommandRepeatList), A.IsRepeatEnabled);
    //    } else {
    //        base.OnCurrentSessionChanged();
    //    }
    //}
}