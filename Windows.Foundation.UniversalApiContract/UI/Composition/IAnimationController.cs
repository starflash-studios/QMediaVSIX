// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IAnimationController
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(3375689682, 1826, 20319, 164, 226, 149, 16, 243, 212, 59, 247)]
  [WebHostHidden]
  [ExclusiveTo(typeof (AnimationController))]
  internal interface IAnimationController
  {
    float PlaybackRate { get; set; }

    float Progress { get; set; }

    AnimationControllerProgressBehavior ProgressBehavior { get; set; }

    void Pause();

    void Resume();
  }
}
