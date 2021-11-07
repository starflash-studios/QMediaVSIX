// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IColorKeyFrameStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (ColorKeyFrame))]
  [Guid(3225661081, 8460, 17167, 157, 165, 223, 16, 130, 105, 32, 85)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IColorKeyFrameStatics
  {
    DependencyProperty ValueProperty { get; }

    DependencyProperty KeyTimeProperty { get; }
  }
}
