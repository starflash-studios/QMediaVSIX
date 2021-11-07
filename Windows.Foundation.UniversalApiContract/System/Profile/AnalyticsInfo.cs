// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.AnalyticsInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.Profile
{
  /// <summary>Provides information about the device for profiling purposes.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IAnalyticsInfoStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IAnalyticsInfoStatics2), 393216, "Windows.Foundation.UniversalApiContract")]
  public static class AnalyticsInfo
  {
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IMapView<string, string>> GetSystemPropertiesAsync(
      IIterable<string> attributeNames);

    /// <summary>Gets version info about the device family.</summary>
    /// <returns>Version info about the device family.</returns>
    public static extern AnalyticsVersionInfo VersionInfo { [MethodImpl] get; }

    /// <summary>Gets the device form factor running Windows 10. For example, the app could be running on a phone, tablet, desktop, and so on.</summary>
    /// <returns>The device form factor.</returns>
    public static extern string DeviceForm { [MethodImpl] get; }
  }
}
