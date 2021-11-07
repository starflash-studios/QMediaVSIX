// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.NDStartAsyncOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Indicates the asynchronous start options. This enumeration is a bitwise OR and is used by the StartAsync method.</summary>
  /// <deprecated type="deprecate">NDStartAsyncOptions is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("NDStartAsyncOptions is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  public enum NDStartAsyncOptions
  {
    /// <summary>If set, the transmitter's certificate will be presented to the caller through a RegistrationCompleted event for verification. The caller should set a flag to accept or reject it. If not set, **RegistrationCompleted** will not contain the certificate.</summary>
    MutualAuthentication = 1,
    /// <summary>If set and the *LicenseFetchDescriptor* parameter is **null** for StartAsync, then **StartAsync** will wait for **OnContentIDReceived** from either NDDownloadEngineNotifier or NDStreamParserNotifier. After **OnContententIDReceived**, the received *LicenseFetchDescriptor* is used to perform the license fetch. If not set and the *LicenseFetchDescriptor* parameter is **null** for **StartAsync**, then **StartAsync** assumes you already acquired the license beforehand and will not do a license fetch.</summary>
    WaitForLicenseDescriptor = 2,
  }
}
