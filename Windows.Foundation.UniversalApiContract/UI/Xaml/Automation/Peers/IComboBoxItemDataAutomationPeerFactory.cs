// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IComboBoxItemDataAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [Guid(346608886, 18074, 16826, 157, 147, 68, 161, 165, 93, 168, 114)]
  [ExclusiveTo(typeof (ComboBoxItemDataAutomationPeer))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IComboBoxItemDataAutomationPeerFactory
  {
    ComboBoxItemDataAutomationPeer CreateInstanceWithParentAndItem(
      object item,
      ComboBoxAutomationPeer parent,
      object baseInterface,
      out object innerInterface);
  }
}
