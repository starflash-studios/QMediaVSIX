using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading;

using Microsoft.VisualStudio.Shell;

using Task = System.Threading.Tasks.Task;

namespace QMediaVSIX {
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
     ProvideOptionPage(typeof(OptionPageGrid), "QMediaVSIX", "Main", 0, 0, true)]
    [ProvideMenuResource("Menus.ctmenu", 1)]
    public sealed class QMediaVSIXPackage : AsyncPackage {
        /// <summary>
        /// QMediaVSIXPackage GUID string.
        /// </summary>
        public const string PackageGuidString = "1ddfb4c3-5267-4a30-927d-62e83facb999";

        #region Package Members

        /// <summary>
        /// Initialisation of the package; this method is called right after the package is sited, so this is the place
        /// where you can put all the initialisation code that rely on services provided by VisualStudio.
        /// </summary>
        /// <param name="CT">A cancellation token to monitor for initialisation cancellation, which can occur when VS is shutting down.</param>
        /// <param name="Progress">A provider for progress updates.</param>
        /// <returns>A task representing the async work of package initialisation, or an already completed task if there is none. Do not return null from this method.</returns>
        protected override async Task InitializeAsync(CancellationToken CT, IProgress<ServiceProgressData> Progress) {
            // When initialised asynchronously, the current thread may be a background thread at this point.
            // Do any initialisation that requires the UI thread after switching to the UI thread.
            await JoinableTaskFactory.SwitchToMainThreadAsync(CT);

            await Commands.CommandsGlobal.PrepareAsync(); //Prepare media-detection utilities

            await Commands.CommandsPlayPause.InitializeAsync(this);
            await Commands.CommandsMediaInfo.InitializeAsync(this);
            await Commands.CommandsSkipFwd.InitializeAsync(this);
            await Commands.CommandsSkipRev.InitializeAsync(this);
            await Commands.CommandsShuffle.InitializeAsync(this);
            await Commands.CommandsRepeat.InitializeAsync(this);
        }

        ~QMediaVSIXPackage() {
            Commands.CommandsGlobal.Destruct();
        }

        #endregion

        public int FallbackDelay => (GetDialogPage(typeof(OptionPageGrid)) as OptionPageGrid).FallbackDelay;
    }

    public class OptionPageGrid : DialogPage {
        [Category("QMediaVSIX"),
         DisplayName("Fallback Delay"),
         Description("The delay before the extension falls back to media keys.\nIf controlling a media source fails, the extension waits for some time to ensure it wasn't just lagging, and then manually invokes keyboard media keys (which may control the wrong media source by accident.)\n\nSet to '0' to use exclusively media keys, and any negative values to disable the fallback entirely.")]
        public int FallbackDelay { get; set; } = 2000;
    }
}
