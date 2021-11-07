// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IRadioButtonAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ExclusiveTo(typeof (RadioButtonAutomationPeer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1228981501, 15752, 18890, 143, 49, 146, 65, 135, 175, 11, 254)]
  [WebHostHidden]
  internal interface IRadioButtonAutomationPeerFactory
  {
    RadioButtonAutomationPeer CreateInstanceWithOwner(
      RadioButton owner,
      object baseInterface,
      out object innerInterface);
  }
}
