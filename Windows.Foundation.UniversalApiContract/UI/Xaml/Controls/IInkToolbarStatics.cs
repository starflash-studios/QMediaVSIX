// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2746520507, 52047, 20075, 163, 61, 241, 30, 122, 41, 94, 250)]
  [ExclusiveTo(typeof (InkToolbar))]
  [WebHostHidden]
  internal interface IInkToolbarStatics
  {
    DependencyProperty InitialControlsProperty { get; }

    DependencyProperty ChildrenProperty { get; }

    DependencyProperty ActiveToolProperty { get; }

    DependencyProperty InkDrawingAttributesProperty { get; }

    DependencyProperty IsRulerButtonCheckedProperty { get; }

    DependencyProperty TargetInkCanvasProperty { get; }
  }
}
