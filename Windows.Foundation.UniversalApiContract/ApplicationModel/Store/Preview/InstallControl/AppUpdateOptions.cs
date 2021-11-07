// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.AppUpdateOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  /// <summary>Provides options you can use in several method overloads of the AppInstallManager class for searching for app updates.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(393216, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class AppUpdateOptions : IAppUpdateOptions, IAppUpdateOptions2
  {
    /// <summary>Creates and initializes a new instance of the AppUpdateOptions class.</summary>
    [MethodImpl]
    public extern AppUpdateOptions();

    /// <summary>Gets or sets the catalog ID of the app to be queried for updates.</summary>
    /// <returns>The catalog ID of the app to be queried for updates.</returns>
    public extern string CatalogId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies whether to allow a forced restart of the app that is being queried for updates.</summary>
    /// <returns>True to allow a forced restart of the app; otherwise, false.</returns>
    public extern bool AllowForcedAppRestart { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the updates should be automatically downloaded and installed if they are found.</summary>
    /// <returns>True to automatically queue up, download and install app updates if any are found. False adds the updates to the install queue in a paused state.</returns>
    public extern bool AutomaticallyDownloadAndInstallUpdateIfFound { [MethodImpl] get; [MethodImpl] set; }
  }
}
