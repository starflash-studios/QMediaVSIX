// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IProxyConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ExclusiveTo(typeof (ProxyConfiguration))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4013580468, 36868, 19926, 183, 216, 179, 229, 2, 244, 170, 208)]
  internal interface IProxyConfiguration
  {
    IVectorView<Uri> ProxyUris { get; }

    bool CanConnectDirectly { get; }
  }
}
