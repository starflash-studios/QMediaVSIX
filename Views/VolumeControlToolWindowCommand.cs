using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using Microsoft.VisualStudio.Shell;
using Task = System.Threading.Tasks.Task;

namespace QMediaVSIX.Views {
    /// <summary> Command handler. </summary>
    internal sealed class VolumeControlToolWindowCommand {
        /// <summary> Command ID. </summary>
        public const int CommandId = 256;

        /// <summary> Command menu group (command set GUID). </summary>
        public static readonly Guid CommandSet = new Guid("bbc379cd-65df-49db-a05c-756b6db0404b");

        /// <summary>
        /// VS Package that provides this command, not null.
        /// </summary>
        readonly AsyncPackage _Package;

        /// <summary> Initialises a new instance of the <see cref="VolumeControlToolWindowCommand"/> class.
        /// Adds our command handlers for menu (commands must exist in the command table file) </summary>
        /// <param name="Package">Owner package, not null.</param>
        /// <param name="CommandService">Command service to add command to, not null.</param>
        VolumeControlToolWindowCommand(AsyncPackage Package, OleMenuCommandService CommandService) {
            _Package = Package ?? throw new ArgumentNullException(nameof(Package));
            CommandService = CommandService ?? throw new ArgumentNullException(nameof(CommandService));

            CommandID MenuCommandID = new CommandID(CommandSet, CommandId);
            MenuCommand MenuItem = new MenuCommand(Execute, MenuCommandID);
            CommandService.AddCommand(MenuItem);
        }

        /// <summary> Gets the instance of the command. </summary>
        public static VolumeControlToolWindowCommand Instance {
            get;
            private set;
        }

        /// <summary> Gets the service provider from the owner package. </summary>
        IAsyncServiceProvider ServiceProvider => _Package;

        /// <summary> Initialises the singleton instance of the command. </summary>
        /// <param name="Package">Owner package, not null.</param>
        public static async Task InitializeAsync(AsyncPackage Package) {
            // Switch to the main thread - the call to AddCommand in VolumeControlToolWindowCommand's constructor requires
            // the UI thread.
            await Package.JoinableTaskFactory.SwitchToMainThreadAsync(Package.DisposalToken);

            OleMenuCommandService CommandService = await Package.GetServiceAsync(typeof(IMenuCommandService)) as OleMenuCommandService;
            Instance = new VolumeControlToolWindowCommand(Package, CommandService);
        }

        /// <summary> Shows the tool window when the menu item is clicked. </summary>
        /// <param name="Sender">The event sender.</param>
        /// <param name="E">The event args.</param>
        void Execute(object Sender, EventArgs E) {
            Debug.WriteLine("Executing...");
            _Package.JoinableTaskFactory.RunAsync(async delegate {
                Debug.WriteLine("\tcreating window...");
                ToolWindowPane Window = await _Package.ShowToolWindowAsync(typeof(VolumeControlToolWindow), 0, true, _Package.DisposalToken);
                if (Window?.Frame == null) {
                    throw new NotSupportedException("Cannot create tool window");
                }
                Debug.WriteLine($"\twindow created. {Window}");
            });
        }
    }
}
