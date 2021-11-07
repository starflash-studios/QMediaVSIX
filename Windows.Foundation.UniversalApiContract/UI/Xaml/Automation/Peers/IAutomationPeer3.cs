// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IAutomationPeer3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [Guid(3553606007, 132, 16855, 162, 33, 40, 21, 141, 59, 195, 44)]
  [ExclusiveTo(typeof (AutomationPeer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAutomationPeer3
  {
    object Navigate(AutomationNavigationDirection direction);

    object GetElementFromPoint(Point pointInWindowCoordinates);

    object GetFocusedElement();

    void ShowContextMenu();

    IVectorView<AutomationPeer> GetControlledPeers();

    IVector<AutomationPeerAnnotation> GetAnnotations();

    void SetParent(AutomationPeer peer);

    void RaiseTextEditTextChangedEvent(
      AutomationTextEditChangeType automationTextEditChangeType,
      IVectorView<string> changedData);

    int GetPositionInSet();

    int GetSizeOfSet();

    int GetLevel();

    void RaiseStructureChangedEvent(
      AutomationStructureChangeType structureChangeType,
      AutomationPeer child);
  }
}
