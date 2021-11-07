// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IHandwritingViewStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3145526992, 52319, 16388, 184, 200, 20, 46, 25, 95, 6, 24)]
  [ExclusiveTo(typeof (HandwritingView))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IHandwritingViewStatics
  {
    DependencyProperty PlacementTargetProperty { get; }

    DependencyProperty PlacementAlignmentProperty { get; }

    DependencyProperty IsOpenProperty { get; }

    DependencyProperty AreCandidatesEnabledProperty { get; }
  }
}
