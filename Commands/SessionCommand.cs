using Microsoft.VisualStudio.Shell;

namespace QMediaVSIX.Commands;

internal abstract class SessionCommand : SimpleCommand<SessionCommand> {
    /// <inheritdoc />
    protected SessionCommand( AsyncPackage Package, OleMenuCommandService CommandService ) : base(Package, CommandService) { }
}