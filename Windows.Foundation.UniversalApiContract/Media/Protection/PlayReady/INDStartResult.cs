// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.INDStartResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Core;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Provides the StartAsync result that contains the created PlayReady-ND  instance.</summary>
  /// <deprecated type="deprecate">INDStartResult is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [Guid(2046224750, 62735, 16405, 139, 164, 194, 188, 52, 78, 189, 78)]
  [Deprecated("INDStartResult is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface INDStartResult
  {
    /// <summary>Gets the  object for the data that the transmitter streams.</summary>
    /// <returns>The newly-created  object.</returns>
    MediaStreamSource MediaStreamSource { [Deprecated("INDStartResult is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
