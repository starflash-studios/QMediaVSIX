// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IColorAnimationUsingKeyFrames
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [ExclusiveTo(typeof (ColorAnimationUsingKeyFrames))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4123534912, 5059, 17066, 154, 226, 126, 107, 81, 201, 47, 149)]
  internal interface IColorAnimationUsingKeyFrames
  {
    ColorKeyFrameCollection KeyFrames { get; }

    bool EnableDependentAnimation { get; set; }
  }
}
