// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.AnimationDirection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Specifies the play direction of an animation.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum AnimationDirection
  {
    /// <summary>Play the animation from start to end.</summary>
    Normal,
    /// <summary>Play the animation in reverse from end to start.</summary>
    Reverse,
    /// <summary>Alternate between normal and reverse playback.</summary>
    Alternate,
    /// <summary>Alternate between reverse and normal playback.</summary>
    AlternateReverse,
  }
}
