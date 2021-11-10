﻿using System.ComponentModel.Design;
using System.Threading.Tasks;

using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;

namespace QMediaVSIX.ToolWindows {
  /// <summary>
  /// Command handler
  /// </summary>
  internal sealed class VolumeMixerToolWindowCommand {
    /// <summary>
    /// Command ID.
    /// </summary>
    public const int CommandId = 257;

    /// <summary>
    /// Command menu group (command set GUID).
    /// </summary>
    public static readonly Guid CommandSet = new Guid("f69ab04e-226e-425f-8f7c-4ea38da690a8");

    /// <summary>
    /// VS Package that provides this command, not null.
    /// </summary>
    readonly AsyncPackage _Package;

    /// <summary>
    /// Initialises a new instance of the <see cref="VolumeMixerToolWindowCommand"/> class.
    /// Adds our command handlers for menu (commands must exist in the command table file)
    /// </summary>
    /// <param name="Package">Owner package, not null.</param>
    /// <param name="CommandService">Command service to add command to, not null.</param>
    VolumeMixerToolWindowCommand( AsyncPackage Package, OleMenuCommandService CommandService ) {
      _Package = Package ?? throw new ArgumentNullException(nameof(Package));
      CommandService = CommandService ?? throw new ArgumentNullException(nameof(CommandService));

      CommandID MenuCommandID = new CommandID(CommandSet, CommandId);
      MenuCommand MenuItem = new MenuCommand(Execute, MenuCommandID);
      CommandService.AddCommand(MenuItem);
    }

    /// <summary>
    /// Gets the instance of the command.
    /// </summary>
    public static VolumeMixerToolWindowCommand? Instance { get; private set; }

    /// <summary>
    /// Gets the service provider from the owner package.
    /// </summary>
    IAsyncServiceProvider ServiceProvider => _Package;

    /// <summary>
    /// Initialises the singleton instance of the command.
    /// </summary>
    /// <param name="Package">Owner package, not null.</param>
    public static async Task InitializeAsync( AsyncPackage Package ) {
      // Switch to the main thread - the call to AddCommand in VolumeMixerToolWindowCommand's constructor requires
      // the UI thread.
      await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(Package.DisposalToken);

      //OleMenuCommandService CommandService = await Package.GetServiceAsync<OleMenuCommandService>() ?? throw new ArgumentNullException(nameof(Package));
      //OleMenuCommandService CommandService = await Package.GetServiceAsync(typeof(IMenuCommandService)) as OleMenuCommandService;
      OleMenuCommandService CommandService = await Package.GetMenuCommandServiceAsync();
      Instance = new VolumeMixerToolWindowCommand(Package, CommandService);
    }

    /// <summary>
    /// Shows the tool window when the menu item is clicked.
    /// </summary>
    /// <param name="Sender">The event sender.</param>
    /// <param name="E">The event args.</param>
    void Execute( object Sender, EventArgs E ) {
      _ = _Package.JoinableTaskFactory.RunAsync(async delegate {
        ToolWindowPane Window = await _Package.ShowToolWindowAsync(typeof(VolumeMixerToolWindow), 0, true, _Package.DisposalToken);
        if ( Window?.Frame == null ) {
          throw new NotSupportedException("Cannot create tool window");
        }

        await _Package.JoinableTaskFactory.SwitchToMainThreadAsync();
        IVsWindowFrame WindowFrame = (IVsWindowFrame)Window.Frame;
        Microsoft.VisualStudio.ErrorHandler.ThrowOnFailure(WindowFrame.Show());
      });
    }
  }
}