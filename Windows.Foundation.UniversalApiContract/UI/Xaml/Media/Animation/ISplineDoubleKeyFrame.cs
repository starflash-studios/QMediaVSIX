// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ISplineDoubleKeyFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SplineDoubleKeyFrame))]
  [Guid(14101816, 27435, 18499, 131, 142, 200, 177, 21, 238, 200, 1)]
  [WebHostHidden]
  internal interface ISplineDoubleKeyFrame
  {
    KeySpline KeySpline { get; set; }
  }
}
