// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnChannel6
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [Guid(1434728086, 48483, 18885, 171, 202, 93, 167, 120, 133, 85, 26)]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [ExclusiveTo(typeof (VpnChannel))]
  internal interface IVpnChannel6
  {
    ValueSet ActivateForeground(string packageRelativeAppId, ValueSet sharedContext);
  }
}
