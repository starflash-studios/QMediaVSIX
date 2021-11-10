using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

using Microsoft.VisualStudio.Shell;

namespace QMediaVSIX.Commands;

internal abstract class SimpleCommand<T> : SimpleCommand where T : SimpleCommand {
    /// <inheritdoc />
    protected SimpleCommand( AsyncPackage Package, OleMenuCommandService CommandService ) : base(Package, CommandService) { }

    /// <summary>
    /// Initialises the singleton instance of the command.
    /// </summary>
    /// <param name="Package">Owner package, not null.</param>
    public static async Task InitializeAsync( AsyncPackage Package ) {
        // Switch to the main thread - the call to AddCommand in SkipNextCommand's constructor requires
        // the UI thread.
        await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(Package.DisposalToken);

        OleMenuCommandService CommandService = await Package.GetServiceAsync<IMenuCommandService, OleMenuCommandService>() ?? throw new ArgumentNullException(nameof(CommandService));

        Debug.WriteLine($"Constructing: {typeof(T)}");
        Instance = (SimpleCommand)typeof(T).GetConstructor(new[] { typeof(AsyncPackage), typeof(OleMenuCommandService) }).Invoke(new object[] {Package, CommandService});
        //Instance = new SimpleCommand<T>(Package, CommandService);
    }
}