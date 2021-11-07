// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IScrollViewer4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2020585668, 20649, 23109, 138, 146, 123, 243, 114, 225, 144, 152)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (ScrollViewer))]
  internal interface IScrollViewer4
  {
    bool ReduceViewportForCoreInputViewOcclusions { get; set; }

    double HorizontalAnchorRatio { get; set; }

    double VerticalAnchorRatio { get; set; }

    bool CanContentRenderOutsideBounds { get; set; }

    event TypedEventHandler<ScrollViewer, AnchorRequestedEventArgs> AnchorRequested;
  }
}
