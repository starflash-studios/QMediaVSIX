// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  /// <summary>Describes the status of an app that is in the installation queue.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AppInstallStatus : IAppInstallStatus, IAppInstallStatus2, IAppInstallStatus3
  {
    /// <summary>Gets the installation state of the current app.</summary>
    /// <returns>A value that specifies the installation state of the current app.</returns>
    public extern AppInstallState InstallState { [MethodImpl] get; }

    /// <summary>Gets the download size in bytes for the current app.</summary>
    /// <returns>The download size in bytes for the current app.</returns>
    public extern ulong DownloadSizeInBytes { [MethodImpl] get; }

    /// <summary>Gets the number of bytes that have been downloaded for the current app.</summary>
    /// <returns>The number of bytes that have been downloaded for the current app.</returns>
    public extern ulong BytesDownloaded { [MethodImpl] get; }

    /// <summary>Gets the completion percentage for the installation of the current app.</summary>
    /// <returns>The completion percentage for the installation of the current app.</returns>
    public extern double PercentComplete { [MethodImpl] get; }

    /// <summary>Gets the error code for an app that has encountered an installation failure.</summary>
    /// <returns>The error code for an app that has encountered an installation failure.</returns>
    public extern HResult ErrorCode { [MethodImpl] get; }

    /// <summary>Gets an object that identifies the user for which the app is being installed.</summary>
    /// <returns>An object that identifies the user for which the app is being installed.</returns>
    public extern User User { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the app can be launched, even if the app has not yet finished installing.</summary>
    /// <returns>True if the app can be launched; otherwise, false.</returns>
    public extern bool ReadyForLaunch { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether an app restart is pending.</summary>
    /// <returns>True if an app restart is pending; otherwise, false.</returns>
    public extern bool IsStaged { [MethodImpl] get; }
  }
}
