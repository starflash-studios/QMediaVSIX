// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IDoubleAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (DoubleAnimation))]
  [Guid(2124365145, 3847, 19401, 151, 125, 3, 118, 63, 248, 21, 79)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDoubleAnimation
  {
    IReference<double> From { get; set; }

    IReference<double> To { get; set; }

    IReference<double> By { get; set; }

    EasingFunctionBase EasingFunction { get; set; }

    bool EnableDependentAnimation { get; set; }
  }
}
