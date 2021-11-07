// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnCustomTextBox
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VpnCustomTextBox))]
  [Guid(3668231114, 36643, 19766, 145, 241, 118, 217, 55, 130, 121, 66)]
  internal interface IVpnCustomTextBox : IVpnCustomPrompt
  {
    string DisplayText { set; get; }
  }
}
