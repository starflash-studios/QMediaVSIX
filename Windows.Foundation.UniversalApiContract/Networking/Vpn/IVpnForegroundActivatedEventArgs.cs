// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnForegroundActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [Guid(2243192240, 51931, 19824, 172, 146, 84, 58, 36, 220, 158, 188)]
  [ExclusiveTo(typeof (VpnForegroundActivatedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  internal interface IVpnForegroundActivatedEventArgs
  {
    string ProfileName { get; }

    ValueSet SharedContext { get; }

    VpnForegroundActivationOperation ActivationOperation { get; }
  }
}
