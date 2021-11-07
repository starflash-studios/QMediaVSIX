// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnCustomPromptBooleanInput
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ExclusiveTo(typeof (VpnCustomPromptBooleanInput))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3301549726, 65351, 17703, 159, 39, 164, 146, 146, 1, 153, 121)]
  internal interface IVpnCustomPromptBooleanInput : IVpnCustomPromptElement
  {
    bool InitialValue { set; get; }

    bool Value { get; }
  }
}
