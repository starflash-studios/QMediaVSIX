// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Management.Deployment;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  /// <summary>Provides options you can use in several method overloads of the AppInstallManager class for installing app updates.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Activatable(393216, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class AppInstallOptions : IAppInstallOptions, IAppInstallOptions2
  {
    /// <summary>Creates and initializes a new instance of the AppInstallOptions class.</summary>
    [MethodImpl]
    public extern AppInstallOptions();

    /// <summary>Gets or sets the catalog ID of the app to install.</summary>
    /// <returns>The catalog ID of the app to install.</returns>
    public extern string CatalogId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether to install the app to non-removable storage even if the user has configured apps to install to SD card, or whether to install the app to non-removable storage or SD card according to the user's settings.</summary>
    /// <returns>True to install the app to non-removable storage even if the user has configured apps to install to SD card; false to install the app to non-removable storage or SD card according to the user's settings.</returns>
    public extern bool ForceUseOfNonRemovableStorage { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether to allow a forced restart of the app that is being installed.</summary>
    /// <returns>True to allow a forced restart of the app that is being installed; otherwise, false.</returns>
    public extern bool AllowForcedAppRestart { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether to attempt to repair the installation of an app that is already installed.</summary>
    /// <returns>True to attempt to repair the installation of an app that is already installed; otherwise, false.</returns>
    public extern bool Repair { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the package storage volume where the app or app bundle will be installed.</summary>
    /// <returns>The package storage volume where the app or app bundle will be installed.</returns>
    public extern PackageVolume TargetVolume { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether to automatically launch the app after it is installed.</summary>
    /// <returns>True to automatically launch the app after it is installed; otherwise, false.</returns>
    public extern bool LaunchAfterInstall { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that determines whether the product being installed should be pinned to the desktop after installation is complete.</summary>
    /// <returns>True to pin the app to the desktop; otherwise, false.</returns>
    public extern bool PinToDesktopAfterInstall { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the product being installed should be pinned to the **Start** menu after installation is complete.</summary>
    /// <returns>True to pin the app to the **Start** menu; otherwise, false.</returns>
    public extern bool PinToStartAfterInstall { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the product being installed should be pinned to the taskbar after installation is complete.</summary>
    /// <returns>True to pin the app to the taskbar; otherwise, false.</returns>
    public extern bool PinToTaskbarAfterInstall { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the notification toast mode for when the app installation completes.</summary>
    /// <returns>A value that indicates whether the system will show a toast or not when an app completes its install. Choices include default, toast with or without a popup, and no toast. If the default is set, the system will choose the appropriate toast.</returns>
    public extern AppInstallationToastNotificationMode CompletedInstallToastNotificationMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the notification toast mode for when the app installation is in progress.</summary>
    /// <returns>A value that indicates whether the system will show a toast or not during app installation. Choices include default, toast with or without a popup, and no toast. If the default is set, the system will choose the appropriate toast.</returns>
    public extern AppInstallationToastNotificationMode InstallInProgressToastNotificationMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the application will be installed for all users.</summary>
    /// <returns>True to install the application for all users; false to install the application for the current user only.</returns>
    public extern bool InstallForAllUsers { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the installation of the app should pause after the download and staging step but not complete the final install.</summary>
    /// <returns>True to pause the install after the download and staging of the app but not complete the final app registration; otherwise, false.</returns>
    public extern bool StageButDoNotInstall { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the promotion campaign ID that is associated with the app to install.</summary>
    /// <returns>The promotion campaign ID that is associated with the app to install.</returns>
    public extern string CampaignId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the extended promotion campaign ID that is associated with the app to install.</summary>
    /// <returns>The extended promotion campaign ID that is associated with the app to install.</returns>
    public extern string ExtendedCampaignId { [MethodImpl] get; [MethodImpl] set; }
  }
}
