// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.IAutomationPropertiesStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;

namespace Windows.UI.Xaml.Automation
{
  [ExclusiveTo(typeof (AutomationProperties))]
  [Guid(964056191, 28809, 18433, 143, 29, 170, 183, 128, 144, 209, 160)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAutomationPropertiesStatics2
  {
    DependencyProperty AccessibilityViewProperty { get; }

    AccessibilityView GetAccessibilityView(DependencyObject element);

    void SetAccessibilityView(DependencyObject element, AccessibilityView value);

    DependencyProperty ControlledPeersProperty { get; }

    IVector<UIElement> GetControlledPeers(DependencyObject element);
  }
}
