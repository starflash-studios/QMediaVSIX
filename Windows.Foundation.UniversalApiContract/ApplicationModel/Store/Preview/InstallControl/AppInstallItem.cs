// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  /// <summary>Represents an app that is in the installation queue.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AppInstallItem : 
    IAppInstallItem,
    IAppInstallItem2,
    IAppInstallItem3,
    IAppInstallItem4,
    IAppInstallItem5
  {
    /// <summary>Gets the product ID for the current app.</summary>
    /// <returns>The product ID for the current app.</returns>
    public extern string ProductId { [MethodImpl] get; }

    /// <summary>Gets the package family name for the current app.</summary>
    /// <returns>The package family name for the current app.</returns>
    public extern string PackageFamilyName { [MethodImpl] get; }

    /// <summary>Gets the type of the current app install.</summary>
    /// <returns>A value that indicates whether the app is being installed, updated, or repaired.</returns>
    public extern AppInstallType InstallType { [MethodImpl] get; }

    /// <summary>Indicates whether the current app install was initiated by the user.</summary>
    /// <returns>True if the current app install was initiated by the user; otherwise, false.</returns>
    public extern bool IsUserInitiated { [MethodImpl] get; }

    /// <summary>Gets the installation status of the current app.</summary>
    /// <returns>A value that specifies the installation status of the current app.</returns>
    [MethodImpl]
    public extern AppInstallStatus GetCurrentStatus();

    /// <summary>Cancels the installation of the current app.</summary>
    [MethodImpl]
    public extern void Cancel();

    /// <summary>Pauses the installation of the current app.</summary>
    [MethodImpl]
    public extern void Pause();

    /// <summary>Restarts the installation of the current app.</summary>
    [MethodImpl]
    public extern void Restart();

    /// <summary>Occurs when the installation of the current app has finished.</summary>
    public extern event TypedEventHandler<AppInstallItem, object> Completed;

    /// <summary>Occurs when the installation status of the current app has changed.</summary>
    public extern event TypedEventHandler<AppInstallItem, object> StatusChanged;

    /// <summary>Cancels the installation of the current app, with the option to generate telemetry data.</summary>
    /// <param name="correlationVector">A correlation vector string that can be used to generate telemetry data.</param>
    [Overload("CancelWithTelemetry")]
    [MethodImpl]
    public extern void Cancel(string correlationVector);

    /// <summary>Pauses the installation of the current app, with the option to generate telemetry data.</summary>
    /// <param name="correlationVector">A correlation vector string that can be used to generate telemetry data.</param>
    [Overload("PauseWithTelemetry")]
    [MethodImpl]
    public extern void Pause(string correlationVector);

    /// <summary>Restarts the installation of the current app, with the option to generate telemetry data.</summary>
    /// <param name="correlationVector">A correlation vector string that can be used to generate telemetry data.</param>
    [Overload("RestartWithTelemetry")]
    [MethodImpl]
    public extern void Restart(string correlationVector);

    /// <summary>Retrieves information about app installs that are children of the current app install. This property only returns a value if the current app install is the parent of other app installs that are part of a the same app bundle.</summary>
    /// <returns>A collection of AppInstallItem objects that represent the children app installs of the current app install.</returns>
    public extern IVectorView<AppInstallItem> Children { [MethodImpl] get; }

    /// <summary>Indicates whether the current app install is part of an app bundle, and therefore pausing or canceling the app install might affect other items in the installation queue.</summary>
    /// <returns>True if the current app install is part of an app bundle, and therefore pausing or canceling the app install might affect other items in the installation queue; otherwise, false.</returns>
    public extern bool ItemOperationsMightAffectOtherItems { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the app that is in the installation queue will be automatically launched after it is installed.</summary>
    /// <returns>True if the app in the installation queue will be automatically launched after it is installed; otherwise, false.</returns>
    public extern bool LaunchAfterInstall { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the product being installed should be pinned to the desktop after installation is complete.</summary>
    /// <returns>True to pin the app to the desktop; otherwise, false.</returns>
    public extern bool PinToDesktopAfterInstall { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the product being installed should be pinned to the **Start** menu after installation is complete.</summary>
    /// <returns>True to pin the app to the **Start** menu; otherwise, false.</returns>
    public extern bool PinToStartAfterInstall { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the product being installed should be pinned to the taskbar after installation is complete.</summary>
    /// <returns>True to pin the app to the taskbar; otherwise, false.</returns>
    public extern bool PinToTaskbarAfterInstall { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the notification toast mode for when the app installation completes.</summary>
    /// <returns>An object that indicates whether the system will show a toast or not when an app completes its install. The choices include default, toast with or without a popup, and no toast. If the default is set, the system will choose the appropriate toast.</returns>
    public extern AppInstallationToastNotificationMode CompletedInstallToastNotificationMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the notification toast mode for when the app installation is in progress.</summary>
    /// <returns>A value that indicates whether the system will show a toast or not during app installation. Choices include default, toast with or without a popup, and no toast. If the default is set, the system will choose the appropriate toast.</returns>
    public extern AppInstallationToastNotificationMode InstallInProgressToastNotificationMode { [MethodImpl] get; [MethodImpl] set; }
  }
}
