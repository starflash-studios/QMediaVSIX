using System.ComponentModel.Design;
using System.Globalization;
using System.Threading.Tasks;

using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;

namespace QMediaVSIX.Commands {
	/// <summary>
	/// Command handler
	/// </summary>
	internal sealed class PlayCommand {
		/// <summary>
		/// Command ID.
		/// </summary>
		public const int CommandId = 256;

		/// <summary>
		/// Command menu group (command set GUID).
		/// </summary>
		public static readonly Guid CommandSet = new Guid("690fff23-ef42-44de-8421-46bc88d23bf9");

		/// <summary>
		/// The currently selected menu controller command
		/// </summary>
		int _CurrentMCCommand = 0;

		/// <summary>
		/// VS Package that provides this command, not null.
		/// </summary>
		readonly AsyncPackage _Package;

		/// <summary>
		/// Initialises a new instance of the <see cref="PlayCommand"/> class.
		/// Adds our command handlers for menu (commands must exist in the command table file)
		/// </summary>
		/// <param name="Package">Owner package, not null.</param>
		/// <param name="CommandService">Command service to add command to, not null.</param>
		PlayCommand( AsyncPackage Package, OleMenuCommandService CommandService ) {
			_Package = Package ?? throw new ArgumentNullException(nameof(Package));
			CommandService = CommandService ?? throw new ArgumentNullException(nameof(CommandService));

			CommandID MenuCommandID = new CommandID(CommandSet, CommandId);
			MenuCommand MenuItem = new MenuCommand(Execute, MenuCommandID);
			CommandService.AddCommand(MenuItem);

			for ( int I = CommandPackageGuids.cmdidMCItem1; I <= CommandPackageGuids.cmdidMCItem3; I++) {
				CommandID CMDID = new CommandID(new Guid(CommandPackageGuids.guidQMediaVSIXPackageCmdSet1), I);
				OleMenuCommand MC = new OleMenuCommand(OnMCItemClicked, CMDID);
				MC.BeforeQueryStatus += OnMCItemQueryStatus;
				CommandService.AddCommand(MC);
				// The first item is, by default, checked. 
				if ( CommandPackageGuids.cmdidMCItem1 == I ) {
					MC.Checked = true;
					_CurrentMCCommand = I;
				}
			}
		}

		void OnMCItemQueryStatus( object Sender, EventArgs E ) {
			if ( Sender is OleMenuCommand MC ) {
				MC.Checked = (MC.CommandID.ID == _CurrentMCCommand);
			}
		}

		void OnMCItemClicked( object Sender, EventArgs E ) {
			if ( Sender is OleMenuCommand MC ) {
				string Selection = MC.CommandID.ID switch {
					CommandPackageGuids.cmdidMCItem1 => "Menu controller Item 1",
					CommandPackageGuids.cmdidMCItem2 => "Menu controller Item 2",
					CommandPackageGuids.cmdidMCItem3 => "Menu controller Item 3",
					_                                => "Unknown command"
				};
				_CurrentMCCommand = MC.CommandID.ID;

				_ = ThreadHelper.JoinableTaskFactory.RunAsync( async () => {
					await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();
					IVsUIShell UIShell = await ServiceProvider.GetServiceAsync<IVsUIShell>() ?? throw new ArgumentNullException(nameof(UIShell));
					Guid CLSID = Guid.Empty;
					UIShell.ShowMessageBox(
						0,
						ref CLSID,
						"Test Tool Window Toolbar Package",
						string.Format(CultureInfo.CurrentCulture,
							"You selected {0}", Selection),
						string.Empty,
						0,
						OLEMSGBUTTON.OLEMSGBUTTON_OK,
						OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST,
						OLEMSGICON.OLEMSGICON_INFO,
						0,
						out _);
				});
			}
		}

		/// <summary>
		/// Gets the instance of the command.
		/// </summary>
		public static PlayCommand? Instance { get; private set; }

		/// <summary>
		/// Gets the service provider from the owner package.
		/// </summary>
		IAsyncServiceProvider ServiceProvider => _Package;

		/// <summary>
		/// Initialises the singleton instance of the command.
		/// </summary>
		/// <param name="Package">Owner package, not null.</param>
		public static async Task InitializeAsync( AsyncPackage Package ) {
			// Switch to the main thread - the call to AddCommand in PlayCommand's constructor requires
			// the UI thread.
			await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(Package.DisposalToken);

			//OleMenuCommandService CommandService = await Package.GetServiceAsync(typeof(IMenuCommandService)) as OleMenuCommandService;
			OleMenuCommandService CommandService = await Package.GetMenuCommandServiceAsync();
			Instance = new PlayCommand(Package, CommandService);
		}

		/// <summary>
		/// This function is the callback used to execute the command when the menu item is clicked.
		/// See the constructor to see how the menu item is associated with this function using
		/// OleMenuCommandService service and MenuCommand class.
		/// </summary>
		/// <param name="Sender">Event sender.</param>
		/// <param name="E">Event args.</param>
		void Execute( object Sender, EventArgs E ) {
			ThreadHelper.ThrowIfNotOnUIThread();
			string Message = string.Format(CultureInfo.CurrentCulture, "Inside {0}.MenuItemCallback()", GetType().FullName);
			const string Title = "PlayCommand";

			// Show a message box to prove we were here
			VsShellUtilities.ShowMessageBox(
				_Package,
				Message,
				Title,
				OLEMSGICON.OLEMSGICON_INFO,
				OLEMSGBUTTON.OLEMSGBUTTON_OK,
				OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST);
		}
	}
}
