﻿using System.ComponentModel.Design;
using System.Threading.Tasks;

using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;

using QMediaVSIX.Commands;

namespace QMediaVSIX.ToolWindows {
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
        public static readonly Guid CommandSet = new Guid("f69ab04e-226e-425f-8f7c-4ea38da690a8");

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
                Microsoft.VisualStudio.ErrorHandler.ThrowOnFailure(WindowFrame.Show());
            });
        }
    }
}
