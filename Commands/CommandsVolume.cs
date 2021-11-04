using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using AudioUtils;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using QMediaVSIX.i18n;
using QMediaVSIX.Views;
using IAsyncServiceProvider = Microsoft.VisualStudio.Shell.IAsyncServiceProvider;
using Task = System.Threading.Tasks.Task;

namespace QMediaVSIX.Commands {
    /// <summary>
    /// Command handler
    /// </summary>
    internal sealed class CommandsVolume {
        /// <summary>
        /// Command ID.
        /// </summary>
        public const int CommandId = 0x0106;

        /// <summary>
        /// Command menu group (command set GUID).
        /// </summary>
        public static readonly Guid CommandSet = new Guid("c788a5b7-c225-48d4-b6a8-781976fc5ba2");

        /// <summary>
        /// VS Package that provides this command, not null.
        /// </summary>
        readonly AsyncPackage _Package;

        /// <summary>
        /// Initialises a new instance of the <see cref="CommandsVolume"/> class.
        /// Adds our command handlers for menu (commands must exist in the command table file)
        /// </summary>
        /// <param name="Package">Owner package, not null.</param>
        /// <param name="CommandService">Command service to add command to, not null.</param>
        CommandsVolume( AsyncPackage Package, OleMenuCommandService CommandService ) {
            _Package = Package              ?? throw new ArgumentNullException(nameof(Package));
            CommandService = CommandService ?? throw new ArgumentNullException(nameof(CommandService));

            CommandID MenuCommandID = new CommandID(CommandSet, CommandId);
            OleMenuCommand MenuItem = new OleMenuCommand((_, __) => {
                Package.JoinableTaskFactory.RunAsync(async () => {
                    ToolWindowPane Window = await Package.ShowToolWindowAsync(typeof(VolumeControlToolWindow), 0, true, Package.DisposalToken);
                    if (Window?.Frame == null) {
                        throw new NotSupportedException("Cannot create tool window");
                    }

                    await Package.JoinableTaskFactory.SwitchToMainThreadAsync();
                    IVsWindowFrame WindowFrame = (IVsWindowFrame)Window.Frame;
                    ErrorHandler.ThrowOnFailure(WindowFrame.Show());
                });

                //ThreadHelper.JoinableTaskFactory.Run(() => {
                //new Thread(() => {
                //    ThreadHelper.ThrowIfOnUIThread($"{nameof(CommandsVolume)}.cto(AsyncPackage, OleMenuCommandService)");
                //    Debug.WriteLine("Displaying volumes.");

                //    List<AudioProgram> LAP = AudioProgram.GetAudioPrograms().ToList();
                //    for (int I = 0; I < LAP.Count; I++) {
                //        Debug.WriteLine($"{I} ... {LAP[I]}");
                //    }

                //    Debug.WriteLine("Displayed all volumes.");

                //    //return Task.CompletedTask;
                //}).Start();
                

            }, MenuCommandID) {
                Text = AppTranslations.CmdVolume.TooltipText
            };
            CommandService.AddCommand(MenuItem);
        }

        /// <summary>
        /// Gets the instance of the command.
        /// </summary>
        public static CommandsVolume Instance { get; private set; }

        /// <summary>
        /// Gets the service provider from the owner package.
        /// </summary>
        IAsyncServiceProvider ServiceProvider => _Package;

        /// <summary> Initialises the singleton instance of the command. </summary>
        /// <param name="Package">Owner package, not null.</param>
        public static async Task InitializeAsync( AsyncPackage Package ) {
            // Switch to the main thread - the call to AddCommand in CommandsSkipRev's constructor requires
            // the UI thread.
            await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(Package.DisposalToken);

            OleMenuCommandService CommandService = await Package.GetServiceAsync(typeof(IMenuCommandService)) as OleMenuCommandService;
            Instance = new CommandsVolume(Package, CommandService);
        }
    }
}