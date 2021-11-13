using System.ComponentModel.Design;

using Microsoft.VisualStudio.Shell;

namespace QMediaVSIX.Commands;

/// <summary>
/// Command handler
/// </summary>
internal sealed class PlayAnchorCommand : SessionCommand<PlayAnchorCommand> {
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