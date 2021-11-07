// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnCustomErrorBox
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [Guid(2663706546, 51522, 17071, 178, 35, 88, 139, 72, 50, 135, 33)]
  [ExclusiveTo(typeof (VpnCustomErrorBox))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVpnCustomErrorBox : IVpnCustomPrompt
  {
  }
}
