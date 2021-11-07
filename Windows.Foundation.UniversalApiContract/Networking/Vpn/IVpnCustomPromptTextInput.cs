// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnCustomPromptTextInput
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [Guid(3386547317, 37180, 18389, 136, 186, 72, 252, 72, 147, 2, 53)]
  [ExclusiveTo(typeof (VpnCustomPromptTextInput))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVpnCustomPromptTextInput : IVpnCustomPromptElement
  {
    string PlaceholderText { set; get; }

    bool IsTextHidden { set; get; }

    string Text { get; }
  }
}
