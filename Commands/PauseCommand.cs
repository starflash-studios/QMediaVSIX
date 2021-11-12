using System.ComponentModel;

using Microsoft.VisualStudio.Shell;

using QMediaVSIX.Core.MediaSource.Software;

using Windows.Media.Control;

namespace QMediaVSIX.Commands;

/// <summary>
/// Command handler
/// </summary>
internal sealed class PauseCommand : SessionPlaybackCommand<PauseCommand> {
    /// <summary>
    /// Command ID.
    /// </summary>
    public const int CommandId = 4177;

    /// <summary>
    /// Command menu group (command set GUID).
    /// </summary>
    public static readonly Guid CommandSet = new Guid("a36c982e-236d-489b-8703-7e1fc268d77c");

    /// <inheritdoc />
    protected override int SelfCommandId => CommandId;

    /// <inheritdoc />
    protected override Guid SelfCommandSet => CommandSet;

    public PauseCommand( AsyncPackage Package, OleMenuCommandService CommandService ) : base(Package, CommandService) { }

    /// <inheritdoc />
    public override void ApplyChanges( MediaSession? ChangedSession ) => ApplyNewStatus(ChangedSession?.PlaybackStatus);

    GlobalSystemMediaTransportControlsSessionPlaybackStatus? _LastStatus = null;
    void ApplyNewStatus( GlobalSystemMediaTransportControlsSessionPlaybackStatus? Status ) {
        if (_LastStatus == Status ) { return; }
        _LastStatus = Status;
        if ( Status is null ) {
            SetCommandEnabled(false);
            return;
        }

        bool WillEnable = Status != GlobalSystemMediaTransportControlsSessionPlaybackStatus.Paused;
        if ( WillEnable ) { //Always disable the other command first.
            SetCommandEnabled(false);
            PlayCommand.Instance?.SetCommandEnabled(true);
        } else {
            PlayCommand.Instance?.SetCommandEnabled(false);
            SetCommandEnabled(true);
        }
    }

    // ReSharper disable once ReplaceAutoPropertyWithComputedProperty
    /// <summary>
    /// Gets the instance of the command.
    /// </summary>
    public new static PauseCommand? Instance { get; } = null;

    /// <inheritdoc />
    public override string Title => "PauseCommand";

    /// <inheritdoc />
    public override void Execute( object Sender, EventArgs E ) {
        if ( Current is { } C ) {
            Debug.WriteLine($"Pausing {C}");
            C.Pause();
        } else {
            Debug.WriteLine("Attempted to pause, but no session was active.");
        }
    }

    public override bool EnableButtonRelativeToSessionNullability => false;
}