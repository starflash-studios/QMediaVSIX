// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ISplineColorKeyFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SplineColorKeyFrame))]
  [Guid(441080129, 8160, 18234, 142, 254, 67, 22, 216, 200, 98, 41)]
  [WebHostHidden]
  internal interface ISplineColorKeyFrame
  {
    KeySpline KeySpline { get; set; }
  }
}
