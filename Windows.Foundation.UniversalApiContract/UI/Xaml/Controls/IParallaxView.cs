// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IParallaxView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(1803877588, 16515, 23371, 188, 64, 217, 32, 78, 25, 180, 26)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ParallaxView))]
  internal interface IParallaxView
  {
    UIElement Child { get; set; }

    double HorizontalShift { get; set; }

    double HorizontalSourceEndOffset { get; set; }

    ParallaxSourceOffsetKind HorizontalSourceOffsetKind { get; set; }

    double HorizontalSourceStartOffset { get; set; }

    bool IsHorizontalShiftClamped { get; set; }

    bool IsVerticalShiftClamped { get; set; }

    double MaxHorizontalShiftRatio { get; set; }

    double MaxVerticalShiftRatio { get; set; }

    UIElement Source { get; set; }

    double VerticalShift { get; set; }

    double VerticalSourceEndOffset { get; set; }

    ParallaxSourceOffsetKind VerticalSourceOffsetKind { get; set; }

    double VerticalSourceStartOffset { get; set; }

    void RefreshAutomaticHorizontalOffsets();

    void RefreshAutomaticVerticalOffsets();
  }
}
