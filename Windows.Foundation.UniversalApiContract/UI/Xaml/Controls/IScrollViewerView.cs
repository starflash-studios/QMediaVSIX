// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IScrollViewerView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ScrollViewerView))]
  [Guid(1693040129, 19906, 18750, 171, 232, 203, 211, 197, 119, 73, 14)]
  [WebHostHidden]
  internal interface IScrollViewerView
  {
    double HorizontalOffset { get; }

    double VerticalOffset { get; }

    float ZoomFactor { get; }
  }
}
