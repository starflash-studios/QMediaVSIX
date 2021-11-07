// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IVisualTreeHelperStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (VisualTreeHelper))]
  [Guid(3881261252, 53853, 19229, 151, 31, 89, 111, 23, 241, 43, 170)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IVisualTreeHelperStatics
  {
    [DefaultOverload]
    [Overload("FindElementsInHostCoordinatesPoint")]
    IIterable<UIElement> FindElementsInHostCoordinates(
      Point intersectingPoint,
      UIElement subtree);

    [Overload("FindElementsInHostCoordinatesRect")]
    IIterable<UIElement> FindElementsInHostCoordinates(
      Rect intersectingRect,
      UIElement subtree);

    [Overload("FindAllElementsInHostCoordinatesPoint")]
    [DefaultOverload]
    IIterable<UIElement> FindElementsInHostCoordinates(
      Point intersectingPoint,
      UIElement subtree,
      bool includeAllElements);

    [Overload("FindAllElementsInHostCoordinatesRect")]
    IIterable<UIElement> FindElementsInHostCoordinates(
      Rect intersectingRect,
      UIElement subtree,
      bool includeAllElements);

    DependencyObject GetChild(DependencyObject reference, int childIndex);

    int GetChildrenCount(DependencyObject reference);

    DependencyObject GetParent(DependencyObject reference);

    void DisconnectChildrenRecursive(UIElement element);
  }
}
