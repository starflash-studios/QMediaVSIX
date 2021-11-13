
using Microsoft.VisualStudio.Shell;

namespace QMediaVSIX.Commands;

/// <summary>
/// Command handler
/// </summary>
internal sealed class ShuffleCommand : SessionCommand<ShuffleCommand> {
    /// <summary>
    /// Command ID.
    /// </summary>
    public const int CommandId = 4180;

    /// <summary>
    /// Command menu group (command set GUID).
    /// </summary>
    public static readonly Guid CommandSet = new Guid("a36c982e-236d-489b-8703-7e1fc268d77c");

    /// <summary>
    /// Initialises a new instance of the <see cref="ShuffleCommand"/> class.
    /// Adds our command handlers for menu (commands must exist in the command table file)
    /// </summary>
    /// <param name="Package">Owner package, not null.</param>
    /// <param name="CommandService">Command service to add command to, not null.</param>
    public ShuffleCommand( AsyncPackage Package, OleMenuCommandService CommandService ) : base(Package, CommandService) { }

    public override void CtoAddToMenu( AsyncPackage Package, OleMenuCommandService CommandService ) { }

    // ReSharper disable once ReplaceAutoPropertyWithComputedProperty
    /// <summary>
    /// Gets the instance of the command.
    /// </summary>
    public new static ShuffleCommand? Instance { get; } = null;

    /// <inheritdoc />
    public override string Title => "ShuffleCommand";

    /// <inheritdoc />
    protected override int SelfCommandId => CommandId;

    /// <inheritdoc />
    protected override Guid SelfCommandSet => CommandSet;

    /// <summary>
    /// This function is the callback used to execute the command when the menu item is clicked.
    /// See the constructor to see how the menu item is associated with this function using
    /// OleMenuCommandService service and MenuCommand class.
    /// </summary>
    /// <param name="Sender">Event sender.</param>
    /// <param name="E">Event args.</param>
    public override void Execute( object Sender, EventArgs E ) {
        if ( Current is { } C ) {
            C.IsShuffleActive = !C.IsShuffleActive;
        } else {
            Debug.WriteLine("Attempted to shuffle, but no session was active.");
        }
    }
}