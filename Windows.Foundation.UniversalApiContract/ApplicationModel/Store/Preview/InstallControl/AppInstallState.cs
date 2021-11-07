// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  /// <summary>Defines the app install states that are returned by the InstallState property of the AppInstallStatus class.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AppInstallState
  {
    /// <summary>The app install is pending.</summary>
    Pending,
    /// <summary>The app install is starting.</summary>
    Starting,
    /// <summary>The license is being acquired for the app.</summary>
    AcquiringLicense,
    /// <summary>The app is being downloaded.</summary>
    Downloading,
    /// <summary>The app data is being restored.</summary>
    RestoringData,
    /// <summary>The app is in the process of being installed.</summary>
    Installing,
    /// <summary>The app install is complete.</summary>
    Completed,
    /// <summary>The app install is canceled.</summary>
    Canceled,
    /// <summary>The app install was paused.</summary>
    Paused,
    /// <summary>The app install encountered an error.</summary>
    Error,
    /// <summary>The app install was paused because the battery is low.</summary>
    PausedLowBattery,
    /// <summary>The app install was paused because the app package was large enough to trigger a prompt for the user to download the app over Wi-Fi.</summary>
    PausedWiFiRecommended,
    /// <summary>The app install was paused because the app package was large enough to require the user to download the app over Wi-Fi.</summary>
    PausedWiFiRequired,
    /// <summary>The app is ready to download.</summary>
    ReadyToDownload,
  }
}
