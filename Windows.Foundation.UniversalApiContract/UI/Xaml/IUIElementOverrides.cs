// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IUIElementOverrides
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (UIElement))]
  [Guid(1619865373, 30808, 19179, 137, 228, 181, 78, 44, 126, 211, 211)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IUIElementOverrides
  {
    AutomationPeer OnCreateAutomationPeer();

    void OnDisconnectVisualChildren();

    IIterable<IIterable<Point>> FindSubElementsForTouchTargeting(
      Point point,
      Rect boundingRect);
  }
}
