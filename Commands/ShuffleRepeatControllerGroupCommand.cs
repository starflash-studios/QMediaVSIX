#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using Windows.Media;

using Microsoft.VisualStudio.Shell;

#endregion

namespace QMediaVSIX.Commands;

/// <summary>
/// Command handler
/// </summary>
internal sealed class ShuffleRepeatControllerGroupCommand : SimpleGroupCommand<ShuffleRepeatControllerGroupCommand> {
    /// <summary>
    /// Command ID.
    /// </summary>
    public const int CommandId = 4179;

    const int
        CommandShuffle      = 4180,
        CommandRepeatSingle = 4181,
        CommandRepeatList   = 4182;

    /// <inheritdoc />
    public override int MinCommandId => CommandShuffle;

    /// <inheritdoc />
    public override int MaxCommandId => CommandRepeatList;

    /// <summary>
    /// Command menu group (command set GUID).
    /// </summary>
    public static readonly Guid CommandSet = new Guid("a36c982e-236d-489b-8703-7e1fc268d77c");

    /// <inheritdoc />
    protected override int SelfCommandId => CommandId;

    /// <inheritdoc />
    protected override Guid SelfCommandSet => CommandSet;

    public ShuffleRepeatControllerGroupCommand( AsyncPackage Package, OleMenuCommandService CommandService ) : base(Package, CommandService) { }


    // ReSharper disable once ReplaceAutoPropertyWithComputedProperty
    /// <summary>
    /// Gets the instance of the command.
    /// </summary>
    public new static ShuffleRepeatControllerGroupCommand? Instance { get; } = null;

    /// <inheritdoc />
    public override string Title => "ShuffleRepeatControllerGroupCommand";

    /// <inheritdoc />
    public override bool IsChecked( int CmdId ) => CmdId switch {
        CommandShuffle => SessionCommandManager.Active?.IsShuffleActive ?? false,
        CommandRepeatSingle => SessionCommandManager.Active?.AutoRepeatMode == MediaPlaybackAutoRepeatMode.Track,
        CommandRepeatList => SessionCommandManager.Active?.AutoRepeatMode == MediaPlaybackAutoRepeatMode.List,
        _ => throw new IndexOutOfRangeException($"{nameof(CmdId)} {CmdId} was an unexpected id at this time.")
    };

    /// <inheritdoc />
    public override void OnClick( OleMenuCommand CMD ) {
        if ( SessionCommandManager.Active is not { } A ) { return; }
        switch ( CMD.CommandID.ID ) {
            case CommandShuffle:
                A.IsShuffleActive = A.IsShuffleActive != true;
                CMD.Checked = A.IsShuffleActive ?? false;
                Debug.WriteLine($"Shuffle mode set to {A.IsShuffleActive}");
                break;
            case CommandRepeatSingle:
                A.AutoRepeatMode = A.AutoRepeatMode == MediaPlaybackAutoRepeatMode.Track ? MediaPlaybackAutoRepeatMode.None : MediaPlaybackAutoRepeatMode.Track;
                CMD.Checked = A.AutoRepeatMode == MediaPlaybackAutoRepeatMode.Track;
                Debug.WriteLine($"Auto repeat mode set to {A.AutoRepeatMode}");
                break;
            case CommandRepeatList:
                A.AutoRepeatMode = A.AutoRepeatMode == MediaPlaybackAutoRepeatMode.List ? MediaPlaybackAutoRepeatMode.None : MediaPlaybackAutoRepeatMode.List;
                CMD.Checked = A.AutoRepeatMode == MediaPlaybackAutoRepeatMode.List;
                Debug.WriteLine($"Auto repeat mode set to {A.AutoRepeatMode}");
                break;
        }
    }

    //public override bool ShouldCommandBeEnabled( int CmdId ) => CmdId switch {
    //    >= CommandShuffle and <= CommandRepeatList => SessionCommandManager.Active is not null,
    //    _                                          => throw new IndexOutOfRangeException($"{nameof(CmdId)} {CmdId} was an unexpected id at this time.")
    //};

    public override bool ShouldCommandBeEnabled( int CmdId ) => CmdId switch {
        CommandShuffle      => SessionCommandManager.Active?.IsShuffleEnabled ?? false,
        CommandRepeatSingle => SessionCommandManager.Active?.IsRepeatEnabled  ?? false,
        CommandRepeatList   => SessionCommandManager.Active?.IsRepeatEnabled  ?? false,
        _                   => throw new IndexOutOfRangeException($"{nameof(CmdId)} {CmdId} was an unexpected id at this time.")
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