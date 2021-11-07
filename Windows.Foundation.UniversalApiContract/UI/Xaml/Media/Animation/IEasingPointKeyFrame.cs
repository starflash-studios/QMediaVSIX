// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IEasingPointKeyFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Guid(3016299392, 26728, 16933, 167, 11, 57, 129, 204, 11, 41, 71)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (EasingPointKeyFrame))]
  internal interface IEasingPointKeyFrame
  {
    EasingFunctionBase EasingFunction { get; set; }
  }
}
