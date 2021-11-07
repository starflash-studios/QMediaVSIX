// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IAutomationPeerOverrides5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ExclusiveTo(typeof (AutomationPeer))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(746880133, 30750, 18935, 159, 239, 185, 225, 77, 1, 71, 7)]
  [WebHostHidden]
  internal interface IAutomationPeerOverrides5
  {
    bool IsPeripheralCore();

    bool IsDataValidForFormCore();

    string GetFullDescriptionCore();

    IIterable<AutomationPeer> GetDescribedByCore();

    IIterable<AutomationPeer> GetFlowsToCore();

    IIterable<AutomationPeer> GetFlowsFromCore();
  }
}
