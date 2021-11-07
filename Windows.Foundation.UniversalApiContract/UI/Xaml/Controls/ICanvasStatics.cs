// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICanvasStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1087265862, 10594, 17519, 170, 251, 76, 220, 72, 105, 57, 201)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Canvas))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICanvasStatics
  {
    [IndependentlyAnimatable]
    DependencyProperty LeftProperty { [IndependentlyAnimatable] get; }

    double GetLeft(UIElement element);

    void SetLeft(UIElement element, double length);

    [IndependentlyAnimatable]
    DependencyProperty TopProperty { [IndependentlyAnimatable] get; }

    double GetTop(UIElement element);

    void SetTop(UIElement element, double length);

    DependencyProperty ZIndexProperty { get; }

    int GetZIndex(UIElement element);

    void SetZIndex(UIElement element, int value);
  }
}
