// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.AnimationDelayBehavior
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Specifies the animation delay behavior.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  public enum AnimationDelayBehavior
  {
    /// <summary>Does not compute anything in animation nor holds the value of composition object property. If a DelayTime is specified, it delays starting the animation according to delay time and after delay has expired it applies animation to the object property.</summary>
    SetInitialValueAfterDelay,
    /// <summary>Applies the initial value of the animation (i.e. the value at Keyframe 0) to the object before the delay time is elapsed (when there is a DelayTime specified), it then delays starting the animation according to the DelayTime.</summary>
    SetInitialValueBeforeDelay,
  }
}
