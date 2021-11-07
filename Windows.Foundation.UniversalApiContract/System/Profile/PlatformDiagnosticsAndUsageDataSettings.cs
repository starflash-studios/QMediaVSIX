// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.PlatformDiagnosticsAndUsageDataSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Profile
{
  /// <summary>Provides access to settings for collecting diagnostic data and an event to subscribe to changes to the platform diagnostics and usage data collection level settings.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IPlatformDiagnosticsAndUsageDataSettingsStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public static class PlatformDiagnosticsAndUsageDataSettings
  {
    /// <summary>Gets the current data collection level.</summary>
    /// <returns>The current data collection level.</returns>
    public static extern PlatformDataCollectionLevel CollectionLevel { [MethodImpl] get; }

    /// <summary>Occurs when the data collection level has changed.</summary>
    public static extern event EventHandler<object> CollectionLevelChanged;

    /// <summary>Returns a Boolean value indicating if the requested data collection level can be enabled.</summary>
    /// <param name="level">The desired data collection level.</param>
    /// <returns>Returns true if the requested data collection level can be enabled, otherwise false.</returns>
    [MethodImpl]
    public static extern bool CanCollectDiagnostics(PlatformDataCollectionLevel level);
  }
}
