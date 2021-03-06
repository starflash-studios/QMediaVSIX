#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System;
using System.ComponentModel.Design;
using Microsoft.VisualStudio.Shell;
using QMediaVSIX.i18n;
using Task = System.Threading.Tasks.Task;

#endregion

namespace QMediaVSIX.Commands {
    /// <summary> Command handler </summary>
    internal sealed class CommandsPlayPause {
        /// <summary> Command ID. </summary>
        public const int CommandId = 0x0100;

        /// <summary> Command menu group (command set GUID). </summary>
        public static readonly Guid CommandSet = new Guid("c788a5b7-c225-48d4-b6a8-781976fc5ba2");

        /// <summary> VS Package that provides this command, not null. </summary>
        readonly AsyncPackage _Package;
        /// <summary>
        /// Initialises a new instance of the <see cref="CommandsPlayPause"/> class.
        /// Adds our command handlers for menu (commands must exist in the command table file)
        /// </summary>
        /// <param name="Package">Owner package, not null.</param>
        /// <param name="CommandService">Command service to add command to, not null.</param>
        CommandsPlayPause( AsyncPackage Package, OleMenuCommandService CommandService ) {
            _Package = Package              ?? throw new ArgumentNullException(nameof(Package));
            CommandService = CommandService ?? throw new ArgumentNullException(nameof(CommandService));

            CommandID MenuCommandID = new CommandID(CommandSet, CommandId);
            OleMenuCommand MenuItem = new OleMenuCommand((_, __) => CommandsGlobal.CurrentSessionPlayPauseAsync(_Package as QMediaVSIXPackage).Invoke(), MenuCommandID) {
                Text = AppTranslations.CmdPlayPause.TooltipText
            };
            CommandService.AddCommand(MenuItem);
        }

        /// <summary> Gets the instance of the command. </summary>
        public static CommandsPlayPause Instance { get; private set; }

        /// <summary> Gets the service provider from the owner package. </summary>
        IAsyncServiceProvider ServiceProvider => _Package;

        /// <summary> Initialises the singleton instance of the command. </summary>
        /// <param name="Package">Owner package, not null.</param>
        public static async Task InitializeAsync( AsyncPackage Package ) {
            // Switch to the main thread - the call to AddCommand in CommandsPlayPause's constructor requires
            // the UI thread.
            await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(Package.DisposalToken);

            OleMenuCommandService CommandService = await Package.GetServiceAsync(typeof(IMenuCommandService)) as OleMenuCommandService;
            Instance = new CommandsPlayPause(Package, CommandService);
        }
    }
}