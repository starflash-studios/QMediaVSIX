// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IAutomationPeerOverrides
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
  [Guid(3198762599, 56302, 20347, 175, 13, 167, 154, 174, 83, 51, 191)]
  [ExclusiveTo(typeof (AutomationPeer))]
  internal interface IAutomationPeerOverrides
  {
    object GetPatternCore(PatternInterface patternInterface);

    string GetAcceleratorKeyCore();

    string GetAccessKeyCore();

    AutomationControlType GetAutomationControlTypeCore();

    string GetAutomationIdCore();

    Rect GetBoundingRectangleCore();

    IVector<AutomationPeer> GetChildrenCore();

    string GetClassNameCore();

    Point GetClickablePointCore();

    string GetHelpTextCore();

    string GetItemStatusCore();

    string GetItemTypeCore();

    AutomationPeer GetLabeledByCore();

    string GetLocalizedControlTypeCore();

    string GetNameCore();

    AutomationOrientation GetOrientationCore();

    bool HasKeyboardFocusCore();

    bool IsContentElementCore();

    bool IsControlElementCore();

    bool IsEnabledCore();

    bool IsKeyboardFocusableCore();

    bool IsOffscreenCore();

    bool IsPasswordCore();

    bool IsRequiredForFormCore();

    void SetFocusCore();

    AutomationPeer GetPeerFromPointCore(Point point);

    AutomationLiveSetting GetLiveSettingCore();
  }
}
