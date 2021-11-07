// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ISplinePointKeyFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (SplinePointKeyFrame))]
  [Guid(253358854, 28726, 18767, 188, 60, 120, 13, 240, 204, 82, 74)]
  internal interface ISplinePointKeyFrame
  {
    KeySpline KeySpline { get; set; }
  }
}
