// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IContinuumNavigationTransitionInfoStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (ContinuumNavigationTransitionInfo))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1042668883, 45455, 19441, 179, 188, 146, 245, 22, 242, 153, 3)]
  [WebHostHidden]
  internal interface IContinuumNavigationTransitionInfoStatics
  {
    DependencyProperty ExitElementProperty { get; }

    DependencyProperty IsEntranceElementProperty { get; }

    bool GetIsEntranceElement(UIElement element);

    void SetIsEntranceElement(UIElement element, bool value);

    DependencyProperty IsExitElementProperty { get; }

    bool GetIsExitElement(UIElement element);

    void SetIsExitElement(UIElement element, bool value);

    DependencyProperty ExitElementContainerProperty { get; }

    bool GetExitElementContainer(ListViewBase element);

    void SetExitElementContainer(ListViewBase element, bool value);
  }
}
