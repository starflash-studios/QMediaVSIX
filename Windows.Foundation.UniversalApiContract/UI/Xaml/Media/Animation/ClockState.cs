// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ClockState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Describes the potential states of an animation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum ClockState
  {
    /// <summary>The current animation changes in direct relation to the animation of its parent.</summary>
    Active,
    /// <summary>The animation continues and does not change in relation to the animation of its parent.</summary>
    Filling,
    /// <summary>The animation is stopped.</summary>
    Stopped,
  }
}
