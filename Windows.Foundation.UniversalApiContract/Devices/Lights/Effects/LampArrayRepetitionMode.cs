// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.Effects.LampArrayRepetitionMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Lights.Effects
{
  /// <summary>Defines constants that specify the repetition behavior for effect/playlist.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum LampArrayRepetitionMode
  {
    /// <summary>Specifies that the effect/playlist is run for the defined number of times.</summary>
    Occurrences,
    /// <summary>Specifies that the effect/playlist is run forever. Can only be stopped by stopping the playlist.</summary>
    Forever,
  }
}
