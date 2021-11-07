// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.INDTCPMessengerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ExclusiveTo(typeof (NDTCPMessenger))]
  [Guid(2111331582, 7065, 20328, 143, 130, 129, 119, 247, 206, 223, 43)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("INDTCPMessengerFactory is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  internal interface INDTCPMessengerFactory
  {
    [Deprecated("INDTCPMessengerFactory is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    NDTCPMessenger CreateInstance(string remoteHostName, uint remoteHostPort);
  }
}
