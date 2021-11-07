// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.INDSendResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Provides the result, in the form of a response message, from the PlayReady-ND messenger.</summary>
  /// <deprecated type="deprecate">INDSendResult is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3815265559, 42372, 18333, 144, 183, 214, 137, 199, 191, 124, 128)]
  [Deprecated("INDSendResult is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  public interface INDSendResult
  {
    /// <summary>Gets the response message from a messenger.</summary>
    /// <returns>The response message.</returns>
    byte[] Response { [Deprecated("INDSendResult is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
