#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

using EnvDTE;

using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;

using QMediaVSIX.Commands;
using QMediaVSIX.Core.MediaSource;
using QMediaVSIX.Core.MediaSource.Software;
using QMediaVSIX.ToolWindows;
using QMediaVSIX.Types;

using ReactiveUI;

using Splat;

#endregion

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
[ PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true),
  Guid(PackageGuidString),
  ProvideAutoLoad(UIContextGuids80.ToolboxInitialized, PackageAutoLoadFlags.BackgroundLoad),
  ProvideMenuResource("Menus.ctmenu", 1),
  SuppressMessage("Performance", "VSSDK003:Support async tool windows"),
  ProvideToolWindow(typeof(VolumeMixerToolWindow))]
public sealed class QMediaVSIXPackage : AsyncPackage {

    public static AsyncPackage Instance { get; private set; } = null!;

    #region GUIDs

    /// <summary>
    /// QMediaVSIXPackage GUID string.
    /// </summary>
    public const string PackageGuidString = "9d9c8b04-c51f-455b-977c-79478bd8fcd0";

    public const string
        guidQMediaVSIXPackageToolWindowCmdSet = "f69ab04e-226e-425f-8f7c-4ea38da690a8",
        guidQMediaVSIXPackageToolbarItemCmdSet = "a36c982e-236d-489b-8703-7e1fc268d77c";

    public const uint cmdidPlayCommand = 6000;

    #endregion

    #region Package Members

    /// <summary>
    /// Initialisation of the package; this method is called right after the package is sited, so this is the place
    /// where you can put all the initialisation code that rely on services provided by VisualStudio.
    /// </summary>
    /// <param name="CancellationToken">A cancellation token to monitor for initialisation cancellation, which can occur when VS is shutting down.</param>
    /// <param name="Progress">A provider for progress updates.</param>
    /// <returns>A task representing the async work of package initialisation, or an already completed task if there is none. Do not return null from this method.</returns>
    protected override async Task InitializeAsync( CancellationToken CancellationToken, IProgress<ServiceProgressData> Progress ) {
        Instance = this;
        // When initialised asynchronously, the current thread may be a background thread at this point.
        // Do any initialisation that requires the UI thread after switching to the UI thread.
        await Task.Run(() => {
            //Debug.WriteLine("Initialising listeners...");
            ThreadHelper.ThrowIfOnUIThread();
            //Debug.WriteLine("On background thread.");
            MediaSourceManager.EnableEcosystems = false;
            MediaSourceManager.Initialise();
            //Debug.WriteLine("Initialised listeners.");
        }, CancellationToken);
        await JoinableTaskFactory.SwitchToMainThreadAsync(CancellationToken);
        //await ToolWindows.VolumeMixerToolWindowCommand.InitializeAsync(this);
        //await SimpleCommandExtensions.InitializeAllInAssemblyAsync(this);
        await InstanceProviderAttribute.ConstructAllInstanceTypesAsync();
        Locator.CurrentMutable.RegisterViewsForViewModels(Assembly.GetCallingAssembly());

        if ( await ServiceProvider.GetServiceAsync(typeof(DTE)) is DTE Dte ) {
            void UpdateCommands( Window _, Window __ ) {
                Debug.WriteLine("]]]Updating Commands[[[");
                if ( MediaSessionManager.Current is { } C ) {
                    if (PlayCommand.Instance is { } PC ) {
                        Debug.WriteLine("]]]Updated through instance.[[[");
                        PC.ChangeChosenOption(C);
                    } else {
                        Debug.WriteLine("]]]Updated through property.[[[");
                        SessionCommandManager.Active = C;
                    }
                } else {
                    SessionCommandManager.Active = null;
                }
                Dte.Events.WindowEvents.WindowActivated -= UpdateCommands;
            }

            Dte.Events.WindowEvents.WindowActivated += UpdateCommands;
        }
    }

    IAsyncServiceProvider ServiceProvider => this;

    //TODO: Pause command as menu controller (pause/stop)
    //TODO:     - make play more generic? menu item as subclass?
    //TODO: Other commands (either in 'Additional Media Controls' toolbar, or just as raw commands only)
    //TODO: Playback position slider (In toolbar? if not, at least ToolWindow?)

    #endregion
}