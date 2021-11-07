// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IPointKeyFrameStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [ExclusiveTo(typeof (PointKeyFrame))]
  [Guid(2513378087, 31077, 19436, 185, 251, 251, 233, 75, 101, 81, 142)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPointKeyFrameStatics
  {
    DependencyProperty ValueProperty { get; }

    DependencyProperty KeyTimeProperty { get; }
  }
}
