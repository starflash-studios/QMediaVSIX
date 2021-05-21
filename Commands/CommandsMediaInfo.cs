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
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Resources;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using QMediaVSIX.i18n;
using IAsyncServiceProvider = Microsoft.VisualStudio.Shell.IAsyncServiceProvider;
using Task = System.Threading.Tasks.Task;

#endregion

namespace QMediaVSIX.Commands {
    /// <summary>
    /// Command handler
    /// </summary>
    internal sealed class CommandsMediaInfo {
        /// <summary>
        /// Command ID.
        /// </summary>
        public const int CommandId = 0x0101;

        /// <summary>
        /// Command menu group (command set GUID).
        /// </summary>
        public static readonly Guid CommandSet = new Guid("c788a5b7-c225-48d4-b6a8-781976fc5ba2");

        /// <summary>
        /// VS Package that provides this command, not null.
        /// </summary>
        readonly AsyncPackage _Package;

        /// <summary>
        /// Initialises a new instance of the <see cref="CommandsMediaInfo"/> class.
        /// Adds our command handlers for menu (commands must exist in the command table file)
        /// </summary>
        /// <param name="Package">Owner package, not null.</param>
        /// <param name="CommandService">Command service to add command to, not null.</param>
        CommandsMediaInfo(AsyncPackage Package, OleMenuCommandService CommandService) {
            _Package = Package ?? throw new ArgumentNullException(nameof(Package));
            CommandService = CommandService ?? throw new ArgumentNullException(nameof(CommandService));

            CommandID MenuCommandID = new CommandID(CommandSet, CommandId);
            OleMenuCommand MenuItem = new OleMenuCommand(Execute, MenuCommandID) {
                Text = AppTranslations.CmdMediaInfo.TooltipText
            };
            //MenuItem.BeforeQueryStatus += MenuItem_BeforeQueryStatus;

            //MenuItem.BeforeQueryStatus += OnBeforeQueryStatus;


            CommandService.AddCommand(MenuItem);

            //CommandsGlobal.OnSessionChange += OnMediaChanged;
        }

        //void OnBeforeQueryStatus(object Sender, EventArgs E) {
        //    if (Sender is not OleMenuCommand MC) { return; }

        //    //ResourceManager RM = new ResourceManager("Strings", typeof(TransUtil).Assembly);
        //    //Debug.WriteLine($"CurrentCulture: {CultureInfo.CurrentCulture}; CurrentUICulture: {CultureInfo.CurrentUICulture}; DefaultThreadCurrentCulture: {CultureInfo.DefaultThreadCurrentCulture}; DefaultThreadCurrentUICulture: {CultureInfo.DefaultThreadCurrentUICulture}");
        //    //ResourceSet RS = RM.GetResourceSet(CultureInfo.CurrentUICulture, false, false);
        //    //Debug.WriteLine($"The TestString for the current culture is as follows '{RS.GetString("TestString")}'");

        //    //Debug.WriteLine($"en-au: {TransUtil.EnAU}; ja-jp: {TransUtil.JaJP}; current: {TransUtil.Current}; current ui: {TransUtil.CurrentUI}");
        //    //Debug.WriteLine($"CmdMediaInfo: {AppTranslations.CmdMediaInfo}");
        //    MC.Text = AppTranslations.CmdMediaInfo.ButtonText;
        //    //MC.Text = 
        //}

        //static void MenuItem_BeforeQueryStatus(object Sender, EventArgs E) {
        //    if (Sender is OleMenuCommand OMC) {
        //        ThreadHelper.JoinableTaskFactory.RunAsync(async () => {
        //            FuzzyMediaInfo FMI = await FuzzyMediaInfo.GetAsync(CommandsGlobal.TransportControls);
        //            string Display = FMI.ToString();
        //            //Debug.WriteLine($"Will display: {Display} ({FMI})");
        //            await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();
        //            OMC.Text = Display;
        //            //foreach (object OMCProp in OMC.Properties) {
        //            //    Debug.WriteLine($"Got property: {OMCProp} ({OMCProp.GetType()})");
        //            //}
        //            //Debug.WriteLine("Done Display.");
        //        });
        //    }
        //}

        //~CommandsMediaInfo() {
        //    CommandsGlobal.OnSessionChange -= OnMediaChanged;
        //}

        /// <summary>
        /// Gets the instance of the command.
        /// </summary>
        public static CommandsMediaInfo Instance { get; private set; }

        /// <summary>
        /// Gets the service provider from the owner package.
        /// </summary>
        IAsyncServiceProvider ServiceProvider => _Package;

        /// <summary>
        /// Initialises the singleton instance of the command.
        /// </summary>
        /// <param name="Package">Owner package, not null.</param>
        public static async Task InitializeAsync(AsyncPackage Package) {
            // Switch to the main thread - the call to AddCommand in CommandsPlayPause's constructor requires
            // the UI thread.
            await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(Package.DisposalToken);

            OleMenuCommandService CommandService = await Package.GetServiceAsync(typeof(IMenuCommandService)) as OleMenuCommandService;
            Instance = new CommandsMediaInfo(Package, CommandService);
        }


        /// <summary>
        /// This function is the callback used to execute the command when the menu item is clicked.
        /// See the constructor to see how the menu item is associated with this function using
        /// OleMenuCommandService service and MenuCommand class.
        /// </summary>
        /// <param name="Sender">Event sender.</param>
        /// <param name="E">Event args.</param>
        [SuppressMessage("Usage", "VSTHRD100:Avoid async void methods", Justification = "<Pending>")]
        async void Execute(object Sender, EventArgs E) {
            FuzzyMediaInfo FMI = await FuzzyMediaInfo.GetAsync(CommandsGlobal.TransportControls);

            await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();
            VsShellUtilities.ShowMessageBox(_Package, FMI.GetSubheading(), FMI.GetHeading(), OLEMSGICON.OLEMSGICON_INFO, OLEMSGBUTTON.OLEMSGBUTTON_OK, OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST);
        }

        //public void OnMediaChanged(GSMTCSessionManager SessionManager, Windows.Media.Control.CurrentSessionChangedEventArgs ChangeArgs, GSMTCMediaProperties Media) {

        //}
    }
}
