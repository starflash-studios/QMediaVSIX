// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.INDLicenseFetchCompletedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Gets custom data from a PlayReady-ND license fetch operation. This custom data is an argument from a PlayReady-ND LicenseFetchCompleted event.</summary>
  /// <deprecated type="deprecate">INDLicenseFetchCompletedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [Guid(518195738, 4530, 17752, 136, 101, 227, 165, 22, 146, 37, 23)]
  [Deprecated("INDLicenseFetchCompletedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface INDLicenseFetchCompletedEventArgs
  {
    /// <summary>Gets custom data from a license fetch response.</summary>
    /// <returns>The custom data from the license fetch response.</returns>
    INDCustomData ResponseCustomData { [Deprecated("INDLicenseFetchCompletedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
