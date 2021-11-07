// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.INDClientFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [Guid(1045683554, 65256, 17695, 176, 212, 247, 6, 204, 163, 224, 55)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("INDClientFactory is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (NDClient))]
  internal interface INDClientFactory
  {
    [Deprecated("INDClientFactory is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    NDClient CreateInstance(
      INDDownloadEngine downloadEngine,
      INDStreamParser streamParser,
      INDMessenger pMessenger);
  }
}
