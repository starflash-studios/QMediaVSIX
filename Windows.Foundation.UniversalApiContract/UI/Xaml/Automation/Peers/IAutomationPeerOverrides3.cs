// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IAutomationPeerOverrides3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3069232301, 19769, 18918, 187, 145, 217, 36, 238, 253, 133, 56)]
  [ExclusiveTo(typeof (AutomationPeer))]
  internal interface IAutomationPeerOverrides3
  {
    object NavigateCore(AutomationNavigationDirection direction);

    object GetElementFromPointCore(Point pointInWindowCoordinates);

    object GetFocusedElementCore();

    IVector<AutomationPeerAnnotation> GetAnnotationsCore();

    int GetPositionInSetCore();

    int GetSizeOfSetCore();

    int GetLevelCore();
  }
}
