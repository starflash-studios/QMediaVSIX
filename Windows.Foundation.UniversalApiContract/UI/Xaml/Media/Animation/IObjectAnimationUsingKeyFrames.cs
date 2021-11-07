// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IObjectAnimationUsingKeyFrames
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (ObjectAnimationUsingKeyFrames))]
  [WebHostHidden]
  [Guid(860499346, 46922, 19556, 185, 166, 88, 188, 250, 49, 79, 34)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IObjectAnimationUsingKeyFrames
  {
    ObjectKeyFrameCollection KeyFrames { get; }

    bool EnableDependentAnimation { get; set; }
  }
}
