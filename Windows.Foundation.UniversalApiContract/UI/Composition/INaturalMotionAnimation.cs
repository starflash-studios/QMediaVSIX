// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.INaturalMotionAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [Guid(1133371693, 30363, 18465, 169, 73, 40, 74, 101, 71, 232, 115)]
  [WebHostHidden]
  [ExclusiveTo(typeof (NaturalMotionAnimation))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface INaturalMotionAnimation
  {
    AnimationDelayBehavior DelayBehavior { get; set; }

    TimeSpan DelayTime { get; set; }

    AnimationStopBehavior StopBehavior { get; set; }
  }
}
