// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IColorKeyFrameFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Guid(1989925002, 40187, 19069, 150, 196, 161, 231, 222, 111, 219, 75)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ColorKeyFrame))]
  internal interface IColorKeyFrameFactory
  {
    ColorKeyFrame CreateInstance(object baseInterface, out object innerInterface);
  }
}
