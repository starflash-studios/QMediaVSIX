using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

using Microsoft.VisualStudio.Shell;

using ReactiveUI;

using Splat;

using Task = System.Threading.Tasks.Task;

namespace QMediaVSIX;

/// <summary>
/// This is the class that implements the package exposed by this assembly.
/// </summary>
/// <remarks>
/// <para>
/// The minimum requirement for a class to be considered a valid package for Visual Studio
/// is to implement the IVsPackage interface and register itself with the shell.
/// This package uses the helper classes defined inside the Managed Package Framework (MPF)
/// to do it: it derives from the Package class that provides the implementation of the
/// IVsPackage interface and uses the registration attributes defined in the framework to
/// register itself and its components with the shell. These attributes tell the pkgdef creation
/// utility what data to put into .pkgdef file.
/// </para>
/// <para>
/// To get loaded into VS, the package must be referred by &lt;Asset Type="Microsoft.VisualStudio.VsPackage" ...&gt; in .vsixmanifest file.
/// </para>
/// </remarks>
[PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true),
 Guid(PackageGuidString),
 ProvideMenuResource("Menus.ctmenu", 1),
 ProvideToolWindow(typeof(ToolWindows.VolumeMixerToolWindow)),
 SuppressMessage("Performance", "VSSDK003:Support async tool windows")]
public sealed class QMediaVSIXPackage : AsyncPackage {
    /// <summary>
    /// QMediaVSIXPackage GUID string.
    /// </summary>
    public const string PackageGuidString = "9d9c8b04-c51f-455b-977c-79478bd8fcd0";

    #region Package Members

    /// <summary>
    /// Initialisation of the package; this method is called right after the package is sited, so this is the place
    /// where you can put all the initialisation code that rely on services provided by VisualStudio.
    /// </summary>
    /// <param name="CancellationToken">A cancellation token to monitor for initialisation cancellation, which can occur when VS is shutting down.</param>
    /// <param name="Progress">A provider for progress updates.</param>
    /// <returns>A task representing the async work of package initialisation, or an already completed task if there is none. Do not return null from this method.</returns>
    protected override async Task InitializeAsync( CancellationToken CancellationToken, IProgress<ServiceProgressData> Progress ) {
        // When initialised asynchronously, the current thread may be a background thread at this point.
        // Do any initialisation that requires the UI thread after switching to the UI thread.
        await Task.Run(() => {
            Debug.WriteLine("Initialising listeners...");
            ThreadHelper.ThrowIfOnUIThread();
            Debug.WriteLine("On background thread.");
            Core.MediaSource.MediaSourceManager.Initialise();
            Debug.WriteLine("Initialised listeners.");
        }, CancellationToken);
        await JoinableTaskFactory.SwitchToMainThreadAsync(CancellationToken);
        Locator.CurrentMutable.RegisterViewsForViewModels(Assembly.GetCallingAssembly());
        await ToolWindows.VolumeMixerToolWindowCommand.InitializeAsync(this);
        await Commands.PlayCommand.InitializeAsync(this);
    }

    #endregion

    #region GUIDs

    public const string guidDynamicMenuPackageCmdSet = "6201e769-c57e-7f99-f12d-a71604f42187";
    public const uint cmdidMyCommand = 0x104;

    #endregion
}