// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarPenButton
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (InkToolbarPenButton))]
  [Guid(3770158113, 45106, 16622, 162, 185, 80, 127, 108, 203, 130, 123)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IInkToolbarPenButton
  {
    IVector<Brush> Palette { get; set; }

    double MinStrokeWidth { get; set; }

    double MaxStrokeWidth { get; set; }

    Brush SelectedBrush { get; }

    int SelectedBrushIndex { get; set; }

    double SelectedStrokeWidth { get; set; }
  }
}
