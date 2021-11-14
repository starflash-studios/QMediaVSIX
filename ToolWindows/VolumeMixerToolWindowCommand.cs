#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;

using QMediaVSIX.Commands;

#endregion

namespace QMediaVSIX.ToolWindows; 

/// <summary>
/// Command handler
/// </summary>
internal sealed class VolumeMixerToolWindowCommand : SimpleCommand<VolumeMixerToolWindowCommand> {
    /// <summary>
    /// Command ID.
    /// </summary>
    public const int CommandId = 257;

    /// <summary>
    /// Command menu group (command set GUID).
    /// </summary>
    public static readonly Guid CommandSet = new Guid("a36c982e-236d-489b-8703-7e1fc268d77c");

    /// <inheritdoc />
    public override string Title => "Volume Mixer ToolWindow";

    /// <inheritdoc />
    protected override int SelfCommandId => CommandId;

    /// <inheritdoc />
    protected override Guid SelfCommandSet => CommandSet;

    /// <summary>
    /// Initialises a new instance of the <see cref="VolumeMixerToolWindowCommand"/> class.
    /// Adds our command handlers for menu (commands must exist in the command table file)
    /// </summary>
    /// <param name="Package">Owner package, not null.</param>
    /// <param name="CommandService">Command service to add command to, not null.</param>
    public VolumeMixerToolWindowCommand( AsyncPackage Package, OleMenuCommandService CommandService ) : base(Package, CommandService) { }

    /// <summary>
    /// Gets the instance of the command.
    /// </summary>
    public new static VolumeMixerToolWindowCommand? Instance { get; set; }
        
    /// <summary>
    /// Shows the tool window when the menu item is clicked.
    /// </summary>
    /// <param name="Sender">The event sender.</param>
    /// <param name="E">The event args.</param>
    public override void Execute( object Sender, EventArgs E ) {
        _ = Package.JoinableTaskFactory.RunAsync(async delegate {
            ToolWindowPane Window = await Package.ShowToolWindowAsync(typeof(VolumeMixerToolWindow), 0, true, Package.DisposalToken);
            if ( Window?.Frame == null ) {
                throw new NotSupportedException("Cannot create tool window");
            }

            await Package.JoinableTaskFactory.SwitchToMainThreadAsync();
            IVsWindowFrame WindowFrame = (IVsWindowFrame)Window.Frame;
            ErrorHandler.ThrowOnFailure(WindowFrame.Show());
        });
    }
}