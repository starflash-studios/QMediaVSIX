// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnCustomPromptOptionSelector
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(999240921, 36545, 20117, 154, 78, 123, 166, 77, 56, 243, 48)]
  [ExclusiveTo(typeof (VpnCustomPromptOptionSelector))]
  internal interface IVpnCustomPromptOptionSelector : IVpnCustomPromptElement
  {
    IVector<string> Options { get; }

    uint SelectedIndex { get; }
  }
}
