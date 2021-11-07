// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.AudioNodeEmitterSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  /// <summary>Specifies settings flags for the creation of an AudioNodeEmitter.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum AudioNodeEmitterSettings : uint
  {
    /// <summary>No settings.</summary>
    None = 0,
    /// <summary>Processing of Doppler effects based on the DopplerVelocity of the emitter is disabled.</summary>
    DisableDoppler = 1,
  }
}
