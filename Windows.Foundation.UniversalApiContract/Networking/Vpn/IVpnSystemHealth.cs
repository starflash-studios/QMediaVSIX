// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnSystemHealth
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Vpn
{
  [Guid(2577987759, 49390, 20085, 129, 122, 242, 49, 174, 229, 18, 61)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VpnSystemHealth))]
  internal interface IVpnSystemHealth
  {
    Buffer StatementOfHealth { get; }
  }
}
