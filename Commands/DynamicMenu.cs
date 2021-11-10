using System.ComponentModel.Design;

using EnvDTE;

using EnvDTE80;

using Microsoft.VisualStudio.Shell;

namespace QMediaVSIX.Commands;

public class DynamicMenu {
	// ReSharper disable once PrivateFieldCanBeConvertedToLocalVariable
	DTE2 _Dte2;
	//int _RootItemId = 0;

	readonly AsyncPackage _Package;

	/// <summary>
	/// Gets the service provider from the owner package.
	/// </summary>
	IAsyncServiceProvider ServiceProvider => _Package;

	public DynamicMenu( AsyncPackage Package ) {
		_Package = Package ?? throw new ArgumentNullException(nameof(Package));
		_Dte2 = null!;

		_ = ThreadHelper.JoinableTaskFactory.RunAsync(
			async () => {
				OleMenuCommandService? CommandService = await ServiceProvider.GetServiceAsync<IMenuCommandService, OleMenuCommandService>();
				if ( CommandService is not null ) {
					// Add the DynamicItemMenuCommand for the expansion of the root item into N items at run time.
					CommandID DynamicItemRootId = new CommandID(new Guid(QMediaVSIXPackage.guidDynamicMenuPackageCmdSet), (int)QMediaVSIXPackage.cmdidMyCommand);
					DynamicItemMenuCommand DynamicMenuCommand = new DynamicItemMenuCommand(
						DynamicItemRootId,
						IsValidDynamicItem,
						OnInvokedDynamicItem,
						OnBeforeQueryStatusDynamicItem);
					CommandService.AddCommand(DynamicMenuCommand);
				}

				_Dte2 = await ServiceProvider.GetServiceAsync<DTE, DTE2>() ?? throw new ArgumentNullException(nameof(_Dte2));
			});

		async void OnInvokedDynamicItem( object Sender, EventArgs Args ) {
			await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();
			DynamicItemMenuCommand InvokedCommand = (DynamicItemMenuCommand)Sender;
			// If the command is already checked, we don't need to do anything
			if ( InvokedCommand.Checked ) {
				return;
			}

			// Find the project that corresponds to the command text and set it as the startup project
			Projects? Projects = _Dte2.Solution.Projects;
			// ReSharper disable once ForeachCanBePartlyConvertedToQueryUsingAnotherGetEnumerator
			foreach ( Project Proj in Projects ) {
				if ( InvokedCommand.Text.Equals(Proj.Name) ) {
					_Dte2.Solution.SolutionBuild.StartupProjects = Proj.FullName;
					return;
				}
			}
		}

		async void OnBeforeQueryStatusDynamicItem( object Sender, EventArgs Args ) {
			await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();
			DynamicItemMenuCommand MatchedCommand = (DynamicItemMenuCommand)Sender;
			MatchedCommand.Enabled = true;
			MatchedCommand.Visible = true;

			// Find out whether the command ID is 0, which is the ID of the root item.
			// If it is the root item, it matches the constructed DynamicItemMenuCommand,
			// and IsValidDynamicItem won't be called.
			bool ISRootItem = MatchedCommand.MatchedCommandId == 0;

			// The index is set to 1 rather than 0 because the Solution.Projects collection is 1-based.
			int IndexForDisplay = ISRootItem ? 1 : MatchedCommand.MatchedCommandId - (int) QMediaVSIXPackage.cmdidMyCommand + 1;

			MatchedCommand.Text = _Dte2.Solution.Projects.Item(IndexForDisplay).Name;

			Array StartupProjects = (Array)_Dte2.Solution.SolutionBuild.StartupProjects;
			string StartupProject = System.IO.Path.GetFileNameWithoutExtension((string)StartupProjects.GetValue(0));

			// Check the command if it isn't checked already selected
			MatchedCommand.Checked = MatchedCommand.Text == StartupProject;

			// Clear the ID because we are done with this item.
			MatchedCommand.MatchedCommandId = 0;
		}

		bool IsValidDynamicItem( int CommandID ) =>
			// The match is valid if the command ID is >= the id of our root dynamic start item
			// and the command ID minus the ID of our root dynamic start item
			// is less than or equal to the number of projects in the solution.
			CommandID >= (int)QMediaVSIXPackage.cmdidMyCommand && CommandID - (int)QMediaVSIXPackage.cmdidMyCommand < _Dte2.Solution.Projects.Count;
	}
}