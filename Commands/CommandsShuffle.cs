using System;
using System.ComponentModel.Design;

using Microsoft.VisualStudio.Shell;

using IAsyncServiceProvider = Microsoft.VisualStudio.Shell.IAsyncServiceProvider;
using Task = System.Threading.Tasks.Task;

namespace QMediaVSIX.Commands {
    /// <summary>
    /// Command handler
    /// </summary>
    internal sealed class CommandsShuffle {
        /// <summary>
        /// Command ID.
        /// </summary>
        public const int CommandId = 0x0104;

        /// <summary>
        /// Command menu group (command set GUID).
        /// </summary>
        public static readonly Guid CommandSet = new Guid("c788a5b7-c225-48d4-b6a8-781976fc5ba2");

        /// <summary>
        /// VS Package that provides this command, not null.
        /// </summary>
        readonly AsyncPackage _Package;

        /// <summary>
        /// Initialises a new instance of the <see cref="CommandsShuffle"/> class.
        /// Adds our command handlers for menu (commands must exist in the command table file)
        /// </summary>
        /// <param name="Package">Owner package, not null.</param>
        /// <param name="CommandService">Command service to add command to, not null.</param>
        CommandsShuffle(AsyncPackage Package, OleMenuCommandService CommandService) {
            _Package = Package ?? throw new ArgumentNullException(nameof(Package));
            CommandService = CommandService ?? throw new ArgumentNullException(nameof(CommandService));

            CommandID MenuCommandID = new CommandID(CommandSet, CommandId);
            MenuCommand MenuItem = new MenuCommand((_, __) => CommandsGlobal.CurrentSessionShuffleAsync(_Package as QMediaVSIXPackage).Invoke(), MenuCommandID);
            CommandService.AddCommand(MenuItem);
        }

        /// <summary>
        /// Gets the instance of the command.
        /// </summary>
        public static CommandsShuffle Instance {
            get;
            private set;
        }

        /// <summary>
        /// Gets the service provider from the owner package.
        /// </summary>
        IAsyncServiceProvider ServiceProvider => _Package;

        /// <summary>
        /// Initialises the singleton instance of the command.
        /// </summary>
        /// <param name="Package">Owner package, not null.</param>
        public static async Task InitializeAsync(AsyncPackage Package) {
            // Switch to the main thread - the call to AddCommand in CommandsShuffle's constructor requires
            // the UI thread.
            await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(Package.DisposalToken);

            OleMenuCommandService CommandService = await Package.GetServiceAsync(typeof(IMenuCommandService)) as OleMenuCommandService;
            Instance = new CommandsShuffle(Package, CommandService);
        }
    }
}
