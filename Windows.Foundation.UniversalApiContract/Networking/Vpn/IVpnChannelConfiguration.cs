// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnChannelConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ExclusiveTo(typeof (VpnChannelConfiguration))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(237886626, 8210, 20452, 177, 121, 140, 101, 44, 109, 16, 126)]
  internal interface IVpnChannelConfiguration
  {
    string ServerServiceName { get; }

    IVectorView<HostName> ServerHostNameList { get; }

    string CustomField { get; }
  }
}
