// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IScrollBar
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(4118472394, 53670, 19344, 164, 233, 84, 223, 27, 168, 210, 236)]
  [ExclusiveTo(typeof (ScrollBar))]
  internal interface IScrollBar
  {
    Orientation Orientation { get; set; }

    double ViewportSize { get; set; }

    ScrollingIndicatorMode IndicatorMode { get; set; }

    event ScrollEventHandler Scroll;
  }
}
