using System.ComponentModel.Design;

using Windows.Media;

using Microsoft.VisualStudio.Shell;

namespace QMediaVSIX.Commands;

/// <summary>
/// Command handler
/// </summary>
internal sealed class ShuffleRepeatControllerGroupCommand : SessionCommand<ShuffleRepeatControllerGroupCommand> {
    /// <summary>
    /// Command ID.
    /// </summary>
    public const int CommandId = 4179;

    const int
        CommandShuffle      = 4180,
        CommandRepeatSingle = 4181,
        CommandRepeatList   = 4182;

    /// <summary>
    /// Command menu group (command set GUID).
    /// </summary>
    public static readonly Guid CommandSet = new Guid("a36c982e-236d-489b-8703-7e1fc268d77c");

    /// <inheritdoc />
    protected override int SelfCommandId => CommandId;

    /// <inheritdoc />
    protected override Guid SelfCommandSet => CommandSet;

    public ShuffleRepeatControllerGroupCommand( AsyncPackage Package, OleMenuCommandService CommandService ) : base(Package, CommandService) { }

    public override void CtoAddToMenu( AsyncPackage Package, OleMenuCommandService CommandService ) {
        base.CtoAddToMenu(Package, CommandService);
        for ( int I = CommandShuffle; I <= CommandRepeatList; I++ ) {
            CommandID CmdID = new CommandID(CommandSet, I);
            OleMenuCommand MC = new OleMenuCommand(MC_OnItemClicked, CmdID);
            MC.BeforeQueryStatus += MC_BeforeQueryStatus;
            CommandService.AddCommand(MC);
        }
    }

    static void MC_BeforeQueryStatus( object Sender, EventArgs E ) {
        OleMenuCommand CMD = (OleMenuCommand)Sender;
        Debug.WriteLine($"Query {CMD.CommandID}");
        // ReSharper disable once ConvertSwitchStatementToSwitchExpression
        switch ( CMD.CommandID.ID ) {
            case CommandShuffle:
                CMD.Checked = SessionCommandManager.Active?.IsShuffleActive ?? false;
                //CMD.Checked = true;
                break;
            case CommandRepeatSingle:
                CMD.Checked = SessionCommandManager.Active?.AutoRepeatMode == MediaPlaybackAutoRepeatMode.Track;
                //CMD.Checked = true;
                break;
            case CommandRepeatList:
                CMD.Checked = SessionCommandManager.Active?.AutoRepeatMode == MediaPlaybackAutoRepeatMode.List;
                //CMD.Checked = true;
                break;
        }
    }

    static void MC_OnItemClicked( object Sender, EventArgs E ) {
        //Debug.WriteLine("Click");
        if ( SessionCommandManager.Active is not { } A ) { return; }
        OleMenuCommand CMD = (OleMenuCommand)Sender;
        Debug.WriteLine($"Click from {CMD.CommandID}");
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

    public override void OnCurrentSessionChanged() {
        if ( SessionCommandManager.Active is { } A ) {
            ChangeEnableable(Package, new CommandID(CommandSet, CommandShuffle), A.IsShuffleEnabled);
            ChangeEnableable(Package, new CommandID(CommandSet, CommandRepeatSingle), A.IsRepeatEnabled);
            ChangeEnableable(Package, new CommandID(CommandSet, CommandRepeatList), A.IsRepeatEnabled);
        } else {
            base.OnCurrentSessionChanged();
        }
    }

    // ReSharper disable once ReplaceAutoPropertyWithComputedProperty
    /// <summary>
    /// Gets the instance of the command.
    /// </summary>
    public new static ShuffleRepeatControllerGroupCommand? Instance { get; } = null;

    /// <inheritdoc />
    public override string Title => "ShuffleRepeatControllerGroupCommand";

    /// <inheritdoc />
    public override void Execute( object Sender, EventArgs E ) {
        Debug.WriteLine("Huh?");
    }
}