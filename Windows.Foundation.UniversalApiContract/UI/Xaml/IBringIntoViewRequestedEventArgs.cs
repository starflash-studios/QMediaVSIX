// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IBringIntoViewRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ExclusiveTo(typeof (BringIntoViewRequestedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(241344196, 8710, 19595, 148, 174, 189, 182, 106, 78, 191, 209)]
  internal interface IBringIntoViewRequestedEventArgs
  {
    UIElement TargetElement { get; set; }

    bool AnimationDesired { get; set; }

    Rect TargetRect { get; set; }

    double HorizontalAlignmentRatio { get; }

    double VerticalAlignmentRatio { get; }

    double HorizontalOffset { get; set; }

    double VerticalOffset { get; set; }

    bool Handled { get; set; }
  }
}
