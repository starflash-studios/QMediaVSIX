// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IAcrylicBrush
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Guid(2042351438, 52582, 20251, 168, 182, 205, 109, 41, 119, 193, 141)]
  [WebHostHidden]
  [ExclusiveTo(typeof (AcrylicBrush))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IAcrylicBrush
  {
    AcrylicBackgroundSource BackgroundSource { get; set; }

    Color TintColor { get; set; }

    double TintOpacity { get; set; }

    TimeSpan TintTransitionDuration { get; set; }

    bool AlwaysUseFallback { get; set; }
  }
}
