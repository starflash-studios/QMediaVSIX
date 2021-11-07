// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.AudioEffect
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Effects
{
  /// <summary>Represents an audio effect.</summary>
  [DualApiPartition(version = 1)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  public sealed class AudioEffect : IAudioEffect
  {
    /// <summary>Gets the type of the audio effect.</summary>
    /// <returns>The type of the audio effect</returns>
    public extern AudioEffectType AudioEffectType { [MethodImpl] get; }
  }
}
