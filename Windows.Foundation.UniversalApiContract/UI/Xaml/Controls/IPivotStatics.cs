// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPivotStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (Pivot))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3995256820, 49501, 20467, 138, 148, 245, 13, 253, 251, 232, 153)]
  internal interface IPivotStatics
  {
    DependencyProperty TitleProperty { get; }

    DependencyProperty TitleTemplateProperty { get; }

    DependencyProperty HeaderTemplateProperty { get; }

    DependencyProperty SelectedIndexProperty { get; }

    DependencyProperty SelectedItemProperty { get; }

    DependencyProperty IsLockedProperty { get; }

    DependencyProperty SlideInAnimationGroupProperty { get; }

    PivotSlideInAnimationGroup GetSlideInAnimationGroup(
      FrameworkElement element);

    void SetSlideInAnimationGroup(FrameworkElement element, PivotSlideInAnimationGroup value);
  }
}
