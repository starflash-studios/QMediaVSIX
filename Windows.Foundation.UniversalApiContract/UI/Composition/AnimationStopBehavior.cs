// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.AnimationStopBehavior
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Specifies the behavior of an animation when it stops.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  public enum AnimationStopBehavior
  {
    /// <summary>Leave the animation at its current value.</summary>
    LeaveCurrentValue,
    /// <summary>Reset the animation to its initial value.</summary>
    SetToInitialValue,
    /// <summary>Set the animation to its final value.</summary>
    SetToFinalValue,
  }
}
