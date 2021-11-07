// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnChannelActivityStateChangedArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1031079269, 64960, 19390, 162, 59, 69, 255, 252, 109, 151, 161)]
  [ExclusiveTo(typeof (VpnChannelActivityStateChangedArgs))]
  internal interface IVpnChannelActivityStateChangedArgs
  {
    VpnChannelActivityEventType ActivityState { get; }
  }
}
