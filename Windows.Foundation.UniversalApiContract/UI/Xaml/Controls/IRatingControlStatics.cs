// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRatingControlStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(3496137625, 44421, 19484, 178, 196, 53, 221, 68, 50, 39, 94)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (RatingControl))]
  internal interface IRatingControlStatics
  {
    DependencyProperty CaptionProperty { get; }

    DependencyProperty InitialSetValueProperty { get; }

    DependencyProperty IsClearEnabledProperty { get; }

    DependencyProperty IsReadOnlyProperty { get; }

    DependencyProperty MaxRatingProperty { get; }

    DependencyProperty PlaceholderValueProperty { get; }

    DependencyProperty ItemInfoProperty { get; }

    DependencyProperty ValueProperty { get; }
  }
}
