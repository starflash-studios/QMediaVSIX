// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IRevealBrush
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (RevealBrush))]
  [Guid(540451053, 33393, 17304, 144, 25, 37, 135, 32, 147, 241, 63)]
  internal interface IRevealBrush
  {
    Color Color { get; set; }

    ApplicationTheme TargetTheme { get; set; }

    bool AlwaysUseFallback { get; set; }
  }
}
