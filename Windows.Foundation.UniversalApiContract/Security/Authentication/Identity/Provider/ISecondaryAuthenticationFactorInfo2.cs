// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.ISecondaryAuthenticationFactorInfo2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Provider
{
  [Guid(349798819, 64550, 20471, 171, 195, 72, 232, 42, 81, 42, 10)]
  [ExclusiveTo(typeof (SecondaryAuthenticationFactorInfo))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Deprecated("SecondaryAuthenticationFactorInfo is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  internal interface ISecondaryAuthenticationFactorInfo2 : ISecondaryAuthenticationFactorInfo
  {
    SecondaryAuthenticationFactorDevicePresenceMonitoringMode PresenceMonitoringMode { [Deprecated("PresenceMonitoringMode is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 458752, "Windows.Foundation.UniversalApiContract")] get; }

    [RemoteAsync]
    [Deprecated("UpdateDevicePresenceAsync is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 458752, "Windows.Foundation.UniversalApiContract")]
    IAsyncAction UpdateDevicePresenceAsync(
      SecondaryAuthenticationFactorDevicePresence presenceState);

    bool IsAuthenticationSupported { [Deprecated("IsAuthenticationSupported is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 458752, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
