// Decompiled with JetBrains decompiler
// Type: Windows.Media.Casting.CastingPlaybackTypes
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Casting
{
  /// <summary>Indicates the capabilities of a particular casting device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum CastingPlaybackTypes : uint
  {
    /// <summary>The casting device does not support playback.</summary>
    None = 0,
    /// <summary>The casting device supports audio playback.</summary>
    Audio = 1,
    /// <summary>The casting device supports video playback.</summary>
    Video = 2,
    /// <summary>The casting device supports image playback.</summary>
    Picture = 4,
  }
}
